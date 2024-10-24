using _05._Cards;

List<string> cards = new List<string>();

string[] input = Console.ReadLine()
    .Split(", ");

for (int i = 0; i < input.Length; i++)
{
    string[] currentPair = input[i].Split(" ");

    try
    {
        string face = GetCardFace(currentPair[0]);

        CardSuit cardSuit = GetCardSuit(currentPair[1]);

        Card card = new Card(face, cardSuit);

        cards.Add(card.ToString());
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(" ", cards));

string GetCardFace(string v)
{
    switch (v)
    {
        case "2":
            return "2";
        case "3":
            return "3";
        case "4":
            return "4";
        case "5":
            return "5";
        case "6":
            return "6";
        case "7":
            return "7";
        case "8":
            return "8";
        case "9":
            return "9";
        case "10":
            return "10";
        case "J":
            return "J";
        case "Q":
            return "Q";
        case "K":
            return "K";
        case "A":
            return "A";
        default:
            throw new ArgumentException("Invalid card!");
    }
}

CardSuit GetCardSuit(string v)
{
    switch (v)
    {
        case "S":
            return CardSuit.Spades;
        case "H":
            return CardSuit.Hearts;
        case "D":
            return CardSuit.Diamonds;
        case "C":
            return CardSuit.Clubs;
        default:
            throw new ArgumentException("Invalid card!");
    }
}