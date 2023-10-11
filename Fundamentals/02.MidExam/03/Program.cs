using System.Transactions;

int[] arrayOfNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumOfNumbers = 0;
string stringOfTopNumbers = "";
for (int i = 0; i < arrayOfNumbers.Length; i++)
{
    sumOfNumbers += arrayOfNumbers[i];
}
double avarageSum =  (double)sumOfNumbers / arrayOfNumbers.Length;


for (int i = 0;i < arrayOfNumbers.Length; i++)// add all top numbers to a string
{
    if(arrayOfNumbers[i] > avarageSum)
    {
        stringOfTopNumbers += arrayOfNumbers[i] + " ";
    }
}
int[] arrayOfTopNumbers = stringOfTopNumbers// create the string of top numbers in array
    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] arrayOfTop5Numbers = new int[5];
int[] positionsOfTopNumbers = new int[5];
for (int i = 0; i<5 ; i++)
{
    int maxNumber = int.MinValue;
    for (int j = 0; j < arrayOfTopNumbers.Length; j++)
    {
        bool isTrue = false;
        if(i>0)
        {
            if (arrayOfTopNumbers[j] > maxNumber && arrayOfTopNumbers[j] <= arrayOfTop5Numbers[i - 1])
            {
                // positionsOfTopNumbers[i - 1] != j
                if (arrayOfTopNumbers[j] == arrayOfTop5Numbers[i - 1])// in case the number is equal we check if it is at the same position
                {
                    for (int k = 0; k < positionsOfTopNumbers.Length; k++)
                    {
                        if (positionsOfTopNumbers[k] == j)
                        {
                            isTrue = true;
                            break;
                        }
                    }
                }
                if (isTrue) { continue; }// if it is at the same position we continue

                maxNumber = arrayOfTopNumbers[j];//add it to the array of top numbers
                positionsOfTopNumbers[i] = j;// set the position of this highest number
            } 
        }else
        {
            if (arrayOfTopNumbers[j] > maxNumber)
            {
                maxNumber = arrayOfTopNumbers[j];
                positionsOfTopNumbers[i] = j;
            }
        }

    }// logic for searching the top 5 numbers
    arrayOfTop5Numbers[i] = maxNumber;
}
string resultString = string.Empty;
for (int i = 0; i < 5; i++)
{
    if (arrayOfTop5Numbers[i] > avarageSum)// see wchich numbers are coresponding to the rules
    {
        resultString += arrayOfTop5Numbers[i] + " ";// if they are add them in a string(the string is going to be decreasing because in the arrayoftop5 you have set at the 0 index the max number decreasing over time
    }
}
if (resultString != string.Empty)// if there are no answers say no
{
    Console.WriteLine(resultString);
}
else Console.WriteLine("No");
