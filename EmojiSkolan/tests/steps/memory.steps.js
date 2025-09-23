import { Given, When, Then, Before, After } from '@cucumber/cucumber';
import { chromium } from 'playwright';
import assert from 'node:assert';

let browser, page;

// Launch browser before each scenario
Before(async () => {
  browser = await chromium.launch({ headless: false }); // Set headless: false to see the browser
  page = await browser.newPage();
});

// Close browser after each scenario
After(async () => {
  if (browser) {
    await browser.close();
  }
});

// Navigate to the start page
Given('I am on the start page', async () => {
  await page.goto('http://localhost:5173');
});

// Verify that all 16 cards are face down at the beginning
Then('the board should be displayed with all cards face down', async () => {
  await page.waitForFunction(() => document.querySelectorAll('.card:not(.flipped)').length === 16);
  const allCards = await page.$$('.card:not(.flipped)');
  assert.strictEqual(
    allCards.length,
    16,
    `Expected 16 face-down cards, but found ${allCards.length}`
  );
});

// Systematically play through the memory game as a guest
When('I play through the game like a guest', { timeout: 150000 }, async () => {
  await page.waitForSelector('.card', { state: 'visible' });

  const matchedIndices = new Set(); // Track which card indices have been matched
  const cards = await page.$$('.card'); // Get all card elements

  // Loop through each card and compare it with every other card after it
  for (let i = 0; i < cards.length; i++) {
    if (matchedIndices.has(i)) continue; // Skip if already matched

    for (let j = i + 1; j < cards.length; j++) {
      if (matchedIndices.has(j)) continue; // Skip if already matched

      const firstCard = cards[i];
      const secondCard = cards[j];

      // Click both cards
      await firstCard.click({ force: true });
      await page.waitForTimeout(300);
      await secondCard.click({ force: true });
      await page.waitForTimeout(1000); // Wait for match animation

      // Check if both cards now have the "matched" class
      const firstClass = await firstCard.getAttribute('class');
      const secondClass = await secondCard.getAttribute('class');

      const isMatch = firstClass?.includes('matched') && secondClass?.includes('matched');

      if (isMatch) {
        console.log(`✅ Match: card ${i} and ${j}`);
        matchedIndices.add(i);
        matchedIndices.add(j);
        await page.waitForTimeout(500); // Short pause before next pair
        break; // Move on to next i
      } else {
        console.log(`❌ No match: card ${i} and ${j}`);
        await page.waitForTimeout(1500); // Let cards flip back
      }
    }
  }

  console.log('🎉 All cards have been tested!');
});

// Verify that the registration prompt appears after completing the game
Then('I should be asked to register to continue playing', async () => {
  const allowedMessages = [
    'Bra jobbat! Vill du spara din poäng? Registrera dig nu genom att klicka på registrera! 🡇',
  ];

  // Wait until one of the expected messages appears in the instruction box
  await page.waitForFunction(
    (messages) => {
      const el = document.querySelector('.instruction-box-content');
      if (!el) return false;
      return messages.some((msg) => el.textContent.includes(msg));
    },
    allowedMessages,
    { timeout: 10000 } // Wait up to 10 seconds
  );

  // Read the actual message and assert that it's one of the expected ones
  const text = await page.textContent('.instruction-box-content');
  console.log('Instruction box content:', text);

  const matchesOne = allowedMessages.some((msg) => text.includes(msg));
  assert(matchesOne, `Expected registration prompt, but got: ${text}`);
});
