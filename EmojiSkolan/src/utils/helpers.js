export function createShuffledCards(emojis, level) {
  const cards = [];

  const matchColors = [
    'match-color-1',
    'match-color-2',
    'match-color-3',
    'match-color-4',
    'match-color-5',
    'match-color-6',
    'match-color-7',
    'match-color-8',
  ];

  // filter emojis by levelId
  const filteredEmojis = emojis.filter((emoji) => emoji.levelId === level);

  // Shuffle the order and take max 8 emojis
  const shuffledEmojis = filteredEmojis.sort(() => Math.random() - 0.5).slice(0, 8);

  // Shuffle the color order
  const shuffledColors = matchColors.sort(() => Math.random() - 0.5);

  shuffledEmojis.forEach((emoji, idx) => {
    const colorClass = shuffledColors[idx % shuffledColors.length];
    cards.push(
      {
        id: emoji.id,
        type: 'emoji',
        content: emoji.symbol,
        isTurnedOver: false,
        isMatched: false,
        matchColor: colorClass,
        isEmoji: true,
      },
      {
        id: emoji.id,
        type: 'text',
        content: emoji.description,
        isTurnedOver: false,
        isMatched: false,
        matchColor: colorClass,
        isEmoji: false,
      }
    );
  });

  // Fisher-Yates shuffle
  for (let i = cards.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [cards[i], cards[j]] = [cards[j], cards[i]];
  }

  return cards;
}
