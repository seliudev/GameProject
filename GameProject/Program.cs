using GameProject;

GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
gamerManager.Add(new Gamer { 
    ID = 1, BirthYear = 1968, 
    FirstName = "Dell", 
    LastName = "Conagher", 
    IdentityNumber = 12345 
});


