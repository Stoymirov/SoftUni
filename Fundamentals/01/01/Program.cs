int peopleWaiting = int.Parse(Console.ReadLine());

List<int> myList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int peopleLeft = 0;
int totalFreeSpaces = myList.Count*4;


   int poepleLeft = totalFreeSpaces - peopleWaiting;
   for (int i = 0; i < myList.Count; i++)
   {
       int takenPlaces =myList.ElementAt(i);
       int neededPeopleToFill = 4 - takenPlaces;
       if (peopleWaiting >= neededPeopleToFill)
       {
           myList[i] +=neededPeopleToFill;
           peopleWaiting -= neededPeopleToFill;
       }
       else if (peopleWaiting < totalFreeSpaces)
       {
           myList[i] += peopleWaiting;
           peopleWaiting -= totalFreeSpaces = 0;
       }
   }

if (myList.Exists(x => x < 4))
{
    Console.WriteLine("The lift has empty spots!");
    Console.WriteLine(string.Join(" ",myList));
} 
else if(!myList.Exists(x => x < 4) && peopleWaiting==0)
{
    Console.WriteLine(string.Join(" ", myList));
}
else
{
    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
    Console.WriteLine(string.Join(" ", myList));
} 

