using _04._Prototype___Abstract_Class.Models;

SandwichMenu sandwichMenu = new SandwichMenu();

sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tommato");
sandwichMenu["PB&J"] = new Sandwich("Wheat", "", "", "Peanut Butter, Jelly");
sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tommato");

sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tommato, Onion, Olives");
sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
sandwichMenu["Vegeterian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tommato, Olives, Spinach");

Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
Sandwich sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
Sandwich sandwich3 = sandwichMenu["Vegeterian"].Clone() as Sandwich;