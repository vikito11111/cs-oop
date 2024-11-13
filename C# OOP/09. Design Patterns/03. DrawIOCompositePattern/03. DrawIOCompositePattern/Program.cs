using _03._DrawIOCompositePattern;
using _03._DrawIOCompositePattern.Shapes;

Shape page = new Shape(new Position(0, 0));

Shape leftAd = new Shape(new Position(0, 0));
Rectangle leftRectangle = new Rectangle(new Position(10, 5), 20, 5);
Line leftLine = new Line(new Position(15, 5), 20);
Text leftText = new Text(new Position(17, 5), "The best offer!");
Line leftSecondLine = new Line(new Position(19, 5), 20);

leftRectangle.AddChild(leftLine);
leftRectangle.AddChild(leftText);
leftRectangle.AddChild(leftSecondLine);

leftAd.AddChild(leftRectangle);

leftAd.Draw();

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(100);

    leftAd.Move(Direction.Right);

    Console.Clear();

    leftAd.Draw();
}