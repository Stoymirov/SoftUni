using System.Collections;
using System.Threading.Channels;


List<string[]> collection =Console.ReadLine().Split(",").Select(x=>x.Trim().Split(" ")).ToList();


List<Card> collection2 = new List<Card>();

foreach (var c in collection)
{
    try
    {
        Card card = new Card(c[0], c[1]);
        collection2.Add(card);
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

}

Console.WriteLine(string.Join(" ",collection2));


class Card
{
    private string suit;
    private string face;

    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }
    public string Face
    {
        get => face;
        set
        {
            if (value !=  "2" && value != "3" && value != "4" && value != "5" 
                &&value != "6" && value != "7" && value != "8" && value != "9"
                &&value != "10" && value != "J" && value != "Q" && value != "K"&& value !="A")
            {
                throw new ArgumentException("Invalid card!");
            }
            face = value;
        }
    }

    public string Suit
    {
        get => suit;
        set
        {
            if (value != "S" && value != "H" && value != "D" && value != "C")
            {
                throw new ArgumentException("Invalid card!");
            }

            suit = value;
        }
    }

    public override string ToString()
    {
        switch (Suit)
        {
            case "H":
                return $"[{Face}\u2665]";
            case "D":
                return $"[{Face}\u2666]";
            case "S":
                return $"[{Face}\u2660]";
            case "C":
                return $"[{Face}\u2663]";
            default:
                return "Invalid card!";
        }
       
    }
}
