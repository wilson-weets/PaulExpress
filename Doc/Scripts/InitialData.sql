-- Shop
INSERT INTO Shop (Name, Address)
VALUES ("Les délices de l'Impériale", "1 Avenue de la Garde Impériale, Braine l'Alleud (1420)");

-- Sauces

-- Supplements

-- PaymentMethod
INSERT INTO PaymentMethod(Name)
VALUES("Cash")
INSERT INTO PaymentMethod(Name)
VALUES("Virement")

--Sandwich 
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Club", "Spécialités", "Jambon, fromage, oeuf, tomates, carottes, salade, mayo", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Club spécal", "Spécialités", "Club avec sauce andalouse", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Club chicken", "Spécialités", "Filet de poulet, emmental, oeuf, tomates, salade, andalouse", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Rustachou", "Spécialités", "Chorizo, emmental, oeur, tomates, carottes, salade, mayo", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Club med", "Spécialités", "Pesto vert, jambon italien, tomates, mozzarella, roquette", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Traditionnel", "Spécialités", "Jambon italien, mozzarella, tomates, huile d'olive", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le St-Tropez", "Spécialités", "Thon, pêche, salade/roquette", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Turkey", "Spécialités", "Filet de poulet, pêche, roquette, cocktail", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le British", "Spécialités", "Filet de poulet, jambon d'ardennes, tomates, carottes, salade, mayo", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L' U.S.A", "Spécialités", "Américain, tomates, carottes, salade/roquette", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Chicago", "Spécialités", "Boulette, tomates, salade, sauce au choix", 3.5, true)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Tyrolien", "Spécialités", "Fromage, pain de viande, oeuf, tomates, salade, moutarde", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Suisse", "Spécialités", "Emmental, salade de viande, tomates, salade/roquette", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Normand", "Spécialités", "Brie, noix, miel, salade", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Liégeois", "Spécialités", "Brie, syrop de Liège, pommes, roquette", 3.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Délice", "Spécialités", "Filet de poulet, lard grillé, oeuf, tomates, andalouse", 3.5, false)

INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Rital", "Spécialités", "Philadelphia, jambon italien, tomates sechées, roquette", 3.8, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le St-Hubert", "Spécialités", "Pâté de campagne, tomates, salade/roquette", 3.8, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Crête", "Spécialités", "Féta; olives, tomates, tomates sechées, salade/roquette", 3.8, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Fresh", "Spécialités", "Philadelphia, légumes grillés, roquette", 3.8, false)

INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Paysan", "Gourmands", "Pain de viande, lard grillé, tomates sechées, parmesan, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Savoyard", "Gourmands", "Reblochon, lard grillé, tomates, salade", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L'Extra Chicago", "Gourmands", "Boulette chaude, fromage, maïs, tomates, salade, sauce au choix", 4, true)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Frenchy", "Gourmands", "Confiture de figues, brie, lard grillé, pomme, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L'original", "Gourmands", "Poulet grillé, mangue, moutarde au miel, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Tombeur", "Gourmands", "Poulet grillé, pesto rouge, tomates sechées, aubergines grillées, parmesan, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Crispy", "Gourmands", "Burger, cheddar, carottes, tomates, oignons frits, salade", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Milanais", "Gourmands", "Salami, coppa, olive, tomatess et aubergines grillées, copeaux de parmesan", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Némo", "Gourmands", "Philadelphia, saumon fumé, tomates, salade", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Nordique", "Gourmands", "Saumon fumé, oignons frais, persil, citron", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L'Atlantique", "Gourmands", "Saumon fumé, mozzarella, tomates, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Caprèse", "Gourmands", "Brie aux herbes, saumon fumé, tomates, salade", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Gourmand", "Gourmands", "Saumon, philadelphia, mangue, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L'Extra U.S.A", "Gourmands", "Américain, fromage, mayo, oeufs, tomates, carottes, maïs, salade", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L'Emiliano", "Gourmands", "Brie aux poivres, jambin italien, tomates sechées, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Rustique", "Gourmands", "Chèvre, jambon italien, pommes, salade", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Salé-Sucré", "Gourmands", "Chèvre, lard, miel", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Romain", "Gourmands", "Jambon italien, tomates echées, parmesan, roquette, huile", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Méridional", "Gourmands", "Pesto vert, jambon italien, chèvre, poivre, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Régal", "Gourmands", "Philadelphia, coppa, tomates sechées, roquette", 4, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Christmas", "Gourmands", "Terrine de gibier, confiture d'oignons, pain d'épices, roquette", 4, false)

INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Royal", "Gourmands", "Rosbief, lard grillé, carottes, tomates, oeufs, andalouse", 4.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Crispy à l'Italienne", "Gourmands", "Burger, mozzarella, coppa, roquette, tomates séchée", 4.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Petit poivré", "Gourmands", "Pain de viande maison, fromage, tomates, oeufs, salade, sauce au poivre", 4.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Toufou", "Gourmands", "Blanc de poulet, coppa grillée, tomates sechées, sauce au poivre, roquette", 4.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "L'Impérial", "Gourmands", "Rosbief, tomates sechées, parmesan, roquette, huile d'olive", 4.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Buffalo", "Gourmands", "Rosbief, carottes, oigons frais, roquette, moutarde", 4.5, false)
INSERT INTO Sandwich(ShopId, Name, Categorie, Ingredients, UnitPrice, CanSelectSauce)
VALUES(1, "Le Fresh Chicken", "Gourmands", "Philadelphia, blanc de poulet, légumes grillés, roquette", 4.5, false)


