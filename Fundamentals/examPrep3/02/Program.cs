using System.Text.RegularExpressions;

string input =Console.ReadLine();
Regex regex = new Regex(@"(\||#)(?<item>[A-Za-z ]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d+)\1");

List<Product> products = new List<Product>();
MatchCollection matches = regex.Matches(input);
foreach (Match match in matches)
{
    Product product = new Product();
    product.Calories = int.Parse(match.Groups["calories"].Value);
    product.Item =(match.Groups["item"].Value);
    product.Date =(match.Groups["date"].Value);
    products.Add(product);
}

int totalCalories = products.Sum(x => x.Calories);
int survivalDays = totalCalories / 2000;
Console.WriteLine($"You have food to last you for: {survivalDays} days!");
foreach (var product in products)
{
    Console.WriteLine($"Item: {product.Item}, Best before: {product.Date}, Nutrition: {product.Calories}");
}

class Product
{
    public string Item { get; set; }
    public int Calories {get; set; }
    public string Date {get; set; }
}