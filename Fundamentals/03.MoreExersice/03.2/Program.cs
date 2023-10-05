
//int[] seq = new[] { 0, 1 };

//while (seq[1] <= 4)
//{
//    Console.Write("{0}", seq[1]);
//    seq = new[] { seq[1], seq[0] + seq[1] };
//}
////a cool method
///

int wantedFnumber = int.Parse(Console.ReadLine());
long sum = 0;
long[] currentN = new long[wantedFnumber];
for (int i = 0; i < wantedFnumber; i++)
{
    if (i == 0 || i == 1)
    {
        currentN[0] = 1; 
        if (wantedFnumber > 1)
        {
            currentN[1] = 1;
        }
        ;
        if (i == 0)
        {
            sum = 1; continue;
        }
        else if (i == 1)
        {
            sum = 2; continue;
        }
    }
    else
    {
        currentN[i] = currentN[i - 1] + currentN[i - 2];
    }
    sum = currentN[i];
}
Console.WriteLine(sum);