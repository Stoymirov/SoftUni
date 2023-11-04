using System.Runtime.InteropServices.ComTypes;

int n = int.Parse(Console.ReadLine());
Dictionary<string, Person> myMap = new Dictionary<string, Person>();


for (int i = 0; i < n; i++)
{
   
    List<string> input = Console.ReadLine().Split().ToList();

    string command = input[0];
    string username = input[1];
    
    switch (command)
    {
        case "register":
            string licensePlateNumber = input[2];
            Person person = new Person(username,licensePlateNumber);

    }
}

foreach (var VARIABLE in myMap)
{
    Console.WriteLine($"{VARIABLE.Key} => {VARIABLE.Value}");
}


class Person
{
 public Person (string name, string plate)
  {
      Name = name;
      Plate = plate;
  }
    public string Name { get; set; }
    public string Plate { get; set; }
}