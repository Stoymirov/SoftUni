using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Plant> myDictionary = new Dictionary<string, Plant>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split("<->").ToArray();
    string plantName = input[0];
    int rarity = int.Parse(input[1]);
    if (myDictionary.ContainsKey(plantName))
    {
        myDictionary[plantName].Rarity = rarity;
    }
    else
    {
        Plant newPlant = new Plant();
        newPlant.Rarity = rarity;
        newPlant.Name = plantName;
        myDictionary.Add(plantName,newPlant);
    }
}
string command = "";

while ((command = Console.ReadLine()) != "Exhibition")
{
    string pattern = @" - |: ";
    string[] array = Regex.Split(command,pattern);
    string plant = array[1];
    switch (array[0])
    {
        case "Rate":
            if (myDictionary.ContainsKey(plant))
            {
                double rating = double.Parse(array[2]);
                myDictionary[plant].Rating += rating;
                myDictionary[plant].timesOfAddedRating++;
            }
            else
            {
                Console.WriteLine("error");
            }

            break;
        case "Update":
            if (myDictionary.ContainsKey(plant))
            {
                int newRarity = int.Parse(array[2]);
                myDictionary[plant].Rarity = newRarity;
            }
            else {
                Console.WriteLine("error");
            }

            break;
        case "Reset":
            if (myDictionary.ContainsKey(plant))
            {
                myDictionary[plant].Rating = 0;
                myDictionary[plant].timesOfAddedRating = 0;
            }
            else
            {
                Console.WriteLine("error");
            }

            break;
    }
}

Console.WriteLine("Plants for the exhibition:");
foreach (var plant in myDictionary)
{
    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AvarageRating():f2}");
}

class Plant
{
 
   public string Name { get; set; }
    public int Rarity {get; set; }
   public double Rating {get; set; }
   public int timesOfAddedRating { get; set; }

   public double AvarageRating()
   {
       if(timesOfAddedRating!=0)
       return Rating / timesOfAddedRating;
       else
       {
           return 0.00;
       }
   }
}