using libCommerciauxV2;

ServiceCommercial sc;
Commercial c1;
sc = new ServiceCommercial();
c1 = new Commercial("Dupond", "Jean", 7, 'B');
sc.ajouterCommercial(c1);
sc.ajouterNote(c1, new DateTime(2013, 11, 15), 100);      // ajoute un frais de transport 
//sc.ajouterNote(c1, new DateTime(2013, 11, 21), 15.5);     // ajoute une note de repas 
//sc.ajouterNote(c1, new DateTime(2013, 11, 25), 105, '2');  // ajoute une nuité 
//Console.WriteLine($"il y a {sc.nbFraisNonRembourses()} frais non remboursés");
PersisteCommercial.sauve(sc,"bonjour.json");