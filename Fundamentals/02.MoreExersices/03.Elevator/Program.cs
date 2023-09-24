//int n = int.Parse(Console.ReadLine());
//int p = int.Parse(Console.ReadLine());

//int firstRound = n / p;
//if (n%p ==0)
//{
//    Console.WriteLine(firstRound);
//}
//else
//{
//    Console.WriteLine(firstRound+1);
//}


int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int courses = (int)Math.Ceiling((double)n / p);
 Console.WriteLine(courses);
 
 
 