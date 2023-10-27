int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    
string[] Phrases = new string[]
{
    "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
    "Exceptional product.", "I can't live without this product."
};
string[] Events = new string[]
{
    "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
};
string[] Author = new string[]
{
    "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
};
string[] City = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

string randomPhrase = RandomMethod(Phrases);
string randomEvent = RandomMethod(Events);
string randomAuthor = RandomMethod(Author);
string randomCity = RandomMethod(City);

string format = $"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}";


Console.WriteLine(format);
}
static string RandomMethod(string[] myArray)
{
    Random random = new Random();
    int randomIndex = random.Next(myArray.Length);
    return myArray[randomIndex];
}