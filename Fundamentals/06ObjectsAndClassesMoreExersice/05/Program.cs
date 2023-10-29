using System;

List<Person> people = new List<Person>();
List<Product> products = new List<Product>();

string[] arrayOfPeople = Console.ReadLine().Split(";").ToArray();
string[] arrayOfProducts = Console.ReadLine().TrimEnd(';').Split(";").ToArray();

foreach (string item in arrayOfPeople)
{
    Person person = new Person();
    string[] arr = item.Split("=").ToArray();
    person.Name = arr[0];
    person.Money = double.Parse(arr[1]);
    people.Add(person);
}
for (int n = 0;n<arrayOfProducts.Length;n++) { 
    Product product = new Product();
    string[] arr = arrayOfProducts[n].Split('=');
    product.Name = arr[0];
    product.Cost = double.Parse(arr[1]);
    products.Add(product);
}
string command = "";
while ((command = Console.ReadLine()) != "END")
{
    //Person person = new Person();
    string[] arr = command.Split();
    string personFromInput = arr[0];
    string productFromInput = arr[1];

    Product product = products.FirstOrDefault(x => x.Name == productFromInput);
    Person person = people.FirstOrDefault(x=>x.Name == personFromInput);
    product.PersonBuy(product,person);
}
foreach (Person person in people)
{
    if (person.Products.Count > 0)
    {
        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p=>p.Name))}");
    }
    else { Console.WriteLine($"{person.Name} - Nothing bought"); }
}




class Person
{
  public  Person()
    {
        Products = new List<Product>();
    }
    public string Name { get; set; }
    public double Money { get; set; }

   public  List<Product> Products { get; set; }
   }
class Product
{
  
    public string Name { get; set; }
    public double Cost { get; set; }

    public void PersonBuy(Product product, Person person)
    {
         
        if (person.Money >= Cost)
        {
            person.Money -= Cost;
            person.Products.Add(product);
            Console.WriteLine($"{person.Name} bought {Name}");
        }
        else
        {
        Console.WriteLine($"{person.Name} can't afford {Name}");
        }
    }

}