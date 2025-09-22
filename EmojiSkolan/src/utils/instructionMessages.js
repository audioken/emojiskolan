const messages = {
  welcomeGuest: [
    'Välkommen! Spela som gäst genom att välja en bricka.',
  ],
  pleaseRegister: [
    'Bra jobbat! Vill du spara din poäng? Registrera dig nu genom att klicka på registrera! 🡇',
    'Bra jobbat! Registrera dig för att spara dina framsteg genom att klicka på registrera! 🡇',
  ],
  registrationSuccess: [
    'Registrering lyckades! Logga in för att börja spela.',
  ],
  newGame: [
    'Starta ett spel genom att välja en bricka!',
    'Redo för en ny spelomgång? Välj en bricka!',
    'Nytt spel, nya möjligheter! Välj en bricka!',
  ],
  selectCard: [
    'Välj en bricka och försök matcha',
    'Dags att välja ännu en bricka!',
    'Vilken bricka tar du nu?',
  ],
  selectEmoji: [
    'Välj en bricka till och hitta en matchande beskrivning till denna emoji!',
    'Hitta en beskrivning som passar till den här emojin genom att välja en bricka!',
    'Kan du hitta rätt beskrivning till den här emojin? Välj en bricka!',
  ],
  selectDescription: [
    'Välj en bricka till och hitta en matchande emoji till denna beskrivning!',
    'Hitta en emoji som passar till den här beskrivningen genom att välja en bricka!',
    'Kan du hitta rätt emoji till den här beskrivningen? Välj en bricka!',
  ],
  matchFail: [
    'Oops, det var fel. Försök igen!',
    'Inte riktigt rätt. Testa en gång till!',
    'Missade den här gången – du fixar det nästa gång!',
  ],
  matchSuccess: [
    'Bra jobbat! Du hittade rätt matchning. Fortsätt jakten!',
    'Snyggt! Du klarade den. Fortsätt så!',
    'Toppen! En match till i hamn!',
  ],
  newRound: ['Välja ett kort!'],
  gameWon: [
    `Grattis! Du har vunnit spelet! Klicka på bästa resultat 🡅 för att se dina poäng.`,
    `Fantastiskt! Du klarade spelet! Klicka på bästa resultat 🡅 för att se dina poäng.`,
    `Du är en mästare! Spelet är ditt! Klicka på bästa resultat 🡅 för att se dina poäng.`,
  ],
  login: ['Skriv in ditt användarnamn och lösenord och klicka sedan på Logga in.'],
  register: ['Redo att bli medlem? Registrera dig nu genom att fylla i hela formuläret.'],
  profile: ['Här kan du uppdatera dina profiluppgifter.'],
  profileUpdateSuccess: ['Din profil har uppdaterats!'],
  highscore: [
    'Här kan du se dina bästa resultat för varje nivå. Välj en nivå för att börja spela igen!',
  ],
  training: ['Här kan du träna på betydelsen av olika emojis!'],
  forgottenPasswordPrompt: [
    'Vänligen fyll i den e-postadress du vill skapa ett nytt lösenord för.',
  ],
  forgottenPasswordNoUser: ['Ingen användare hittades med denna e-post.'],
  forgottenPasswordSuccess: ['Ditt nya lösenord har skapats!'],
  forgottenPasswordError: ['Något gick fel, försök igen.'],
  pageNotFound: [
    'Hoppsan! Den här sidan finns inte.',
    '404 - Sidan kunde inte hittas.',
    'Du verkar ha gått vilse. Prova att gå tillbaka till startsidan!',
  ],
};

// export an object with a get method to fetch a random message from the array
const instructionMessages = {
  get(type) {
    const arr = messages[type];
    if (!arr) return '';
    if (Array.isArray(arr)) {
      const i = Math.floor(Math.random() * arr.length);
      return arr[i];
    }
    return arr;
  },
};

export default instructionMessages;
