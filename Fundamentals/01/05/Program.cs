double money = double.Parse(Console.ReadLine());
List<int> drums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> referenceList = (drums).ToList();

string command = "";
bool controlerForMoney = false;
while((command = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    
    for (int i = 0; i < drums.Count; i++)
    {
        drums[i] -= int.Parse(command);
        if (drums[i] <= 0 & money - 3 * referenceList[i] <0)
        {
            drums.RemoveAt(i);
            referenceList.RemoveAt(i);
            i--;
        }
        else if (drums[i] <= 0 & money - 3 * referenceList[i] >= 0)
        {
            drums[i] = referenceList[i];
            money -= 3* referenceList[i];
            
        }
    }
}
Console.WriteLine(string.Join(" ",drums));
Console.WriteLine($"Gabsy has {money:f2}lv.");