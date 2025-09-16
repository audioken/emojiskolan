// const instructionMessages = {
//     matchSuccess: "Bra jobbat! Du hittade rätt matchning. Fortsätt jakten genom att välja nästa kort!",
//     matchFail: "Oops, det var fel. Försök igen!",
//     selectCard: "Välj ett till kort och försök matcha",
//     newRound: "Välja ett kort!",
//     gameWon: "Grattis! Du har vunnit spelet!",
//     newGame: "Starta ett spel genom att välja ett kort!"
// }

// export default instructionMessages;

// KOD NÄR VI KAN ÄNDRA I BOARD
const messages = {
  welcomeGuest: [
    "Välkommen! Spela som gäst genom att välja ett kort.",
    "Hej där! Välj ett kort för att börja spela som gäst.",
  ],
  pleaseRegister: [
    "Bra jobbat! Vill du spara din poäng? Registrera dig nu!",
    "Du är grym! Registrera dig för att spara dina framsteg.",
  ],
  newGame: [
    "Starta ett spel genom att välja ett kort!",
    "Redo för en ny spelomgång? Välj ett kort!",
    "Nytt spel, nya möjligheter! Välj ett kort!",
  ],
  selectCard: [
    "Välj ett till kort och försök matcha",
    "Dags att välja ännu ett kort!",
    "Vilket kort tar du nu?",
  ],
  matchFail: [
    "Oops, det var fel. Försök igen!",
    "Inte riktigt rätt. Testa en gång till!",
    "Missade den här gången – du fixar det nästa gång!",
  ],
  matchSuccess: [
    "Bra jobbat! Du hittade rätt matchning. Fortsätt jakten!",
    "Snyggt! Du klarade den. Fortsätt så!",
    "Toppen! En match till i hamn!",
  ],
  newRound: ["Välja ett kort!"],
  gameWon: [
    "Grattis! Du har vunnit spelet!",
    "Fantastiskt! Du klarade spelet!",
    "Du är en mästare! Spelet är ditt!",
  ],
  login: [
    "Skriv in ditt användarnamn och lösenord och klicka sedan på Logga in.",
  ],
  register: [
    "Redo att bli medlem? Registrera dig nu genom att fylla i hela formuläret.",
  ],
  profile: [
    "Här kan du uppdatera dina profiluppgifter.",
  ],
  highscore: [
    "Här kan du se dina bästa resultat för varje nivå. Välj en nivå för att börja spela igen!",
  ],
  training: [
    "Här kan du träna på betydelsen av olika emojis!",
  ],
  forgottenPasswordPrompt: [
    "Vänligen fyll i den e-postadress du vill skapa ett nytt lösenord för.",
  ],
  forgottenPasswordNoUser: [
    "Ingen användare hittades med denna e-post."
  ],
  forgottenPasswordSuccess: [
    "Ditt nya lösenord har skapats!"
  ],
  forgottenPasswordError: [
    "Något gick fel, försök igen."
  ],
};

// Exportera ett objekt med en get-metod
const instructionMessages = {
  get(type) {
    const arr = messages[type];
    if (!arr) return "";
    if (Array.isArray(arr)) {
      const i = Math.floor(Math.random() * arr.length);
      return arr[i];
    }
    return arr;
  }
};

export default instructionMessages;