﻿using _05._Composite_Component.Models;

var phone = new SingleGift("Phone", 256);
phone.CalculateTotalPrice();
Console.WriteLine();

var rootBox = new CompositeGift("RootBox", 0);
var truckToy = new SingleGift("Truck", 289);
var plainToy = new SingleGift("Plain", 587);
rootBox.Add(truckToy);
rootBox.Add(plainToy);

var childBox = new CompositeGift("ChildBox", 0);
var soldierToy = new SingleGift("Soldier", 200);
childBox.Add(soldierToy);

rootBox.Add(childBox);

Console.WriteLine($"Total price of this composite present is : {rootBox.CalculateTotalPrice()}");