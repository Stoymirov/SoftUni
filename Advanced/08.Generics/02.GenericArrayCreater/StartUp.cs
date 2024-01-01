namespace GenericArrayCreator
{

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] peshos = ArrayCreator.Create(5, "pesho");
            Console.WriteLine(string.Join(" ", peshos));
            string[] ones = ArrayCreator.Create(10000, "1");
            Console.WriteLine(string.Join(" ", ones));
        }
    }
}