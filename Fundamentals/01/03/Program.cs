//tryparse

string input = Console.ReadLine();
List<char> myList =  new List<char>();
myList.AddRange(input);
List<int> intigers = new List<int>();
List<char> strings = new List<char>();
for (int i = 0; i < myList.Count; i++)
{
    int number;
    bool successParse = int.TryParse((myList[i]).ToString(), out number);
    
        if (successParse)
        {
            intigers.Add(number);
        }
        else 
        {
        strings.Add(myList[i]);
        }
    
}

List<int> takeCountList = new List<int>();
List<int> SkipCountList = new List<int>();
takeCountList = new List<int>();
SkipCountList = new List<int>();
for (int i = 0; i < intigers.Count; i++)
{
    if (i % 2 == 0)
    {
        takeCountList.Add(intigers[i]);
    }
    else
    {
        SkipCountList.Add(intigers[i]);
    }
}

//myList.AddRange(takeCountList.Select(x => (char)('0' + x))); // just playing around, trying somerhing new
int iteration = Math.Max(takeCountList.Count, SkipCountList.Count);
string result = "";

int indexCounter = 0;
for (int i = 0; i < iteration; i++)
{
    int elementsToTake = 0;
    int elementsToSkip = 0;
    if (i! > takeCountList.Count - 1)
    {
        
        elementsToTake = 0;
    }
    else
    {
        elementsToTake = takeCountList[i];
    }
    if (i! > SkipCountList.Count - 1)
    {
        
        elementsToSkip = 0;
    }
    else
    {
        elementsToSkip = SkipCountList[i];
    }

    int forTheCounter = indexCounter;
    for (int j = indexCounter; j < elementsToTake+ forTheCounter; j++)
    {
        result += (char)(strings[j]);
        indexCounter++;
    }

    indexCounter += elementsToSkip;
}

Console.WriteLine(result);