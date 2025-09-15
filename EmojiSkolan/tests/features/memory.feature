Feature: As a guest, I want to see the whole board and then be able to 
play a full game and see the registration instruction

Scenario: Open the board
  Given I am on the start page
  Then the board should be displayed with all cards face down

Scenario: Play through the full board as a guest
  Given I am on the start page
  When I play through the game like a guest
  Then I should be asked to register to continue playing
