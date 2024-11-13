using _02._Prototype_Design_Pattern___ICloneable;

Square square = new Square();

square.Width = 48;
square.Page = new Page() { Number = 100 };

Square clonedSquare = (Square)square.Clone();

clonedSquare.Width *= 2;
clonedSquare.Page.Number *= 2;

Console.WriteLine($"Original square: {square.Width} width.");
Console.WriteLine($"Cloned square: {clonedSquare.Width} width.");

Console.WriteLine($"Original square page number: {square.Page.Number} width.");
Console.WriteLine($"Cloned square page number: {clonedSquare.Page.Number} width.");