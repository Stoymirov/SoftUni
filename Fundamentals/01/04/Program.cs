List<int> list1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();


List<int> list2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();

bool listIterationsAreComplete = false;

int smallerLenght = Math.Min(list1.Count, list2.Count);
for (int i = 0; i < smallerLenght; i++)
{



    result.Add(list1[i]);




    result.Add(list2[list2.Count-1-i]);

}

int constraint1 = 0;
int constraint2 = 0;
if(list1.Count >list2.Count) 
{
    constraint1 = list1[^1];
    constraint2 = list1[^2];
}
else
{
    constraint1 = list2[0];
    constraint2 = list2[1];
}

if (constraint1 > constraint2)
{
    (constraint2, constraint1) = (constraint1, constraint2);
}
List<int> resultList = new List<int>();
foreach (var i in result)
{
    if (i > constraint1 && i < constraint2)
    {
        resultList.Add(i);
    }
}

resultList.Sort();
Console.WriteLine(string.Join(" ",resultList));















//for (int i = constraint1+1; i < constraint2; i++)
//{
//    if (result.Contains(i))
//    {
//        List<int> tempInts = new List<int>();
        
//        resultList.Add(i);
        
//    }
//}