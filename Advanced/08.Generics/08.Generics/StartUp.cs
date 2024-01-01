
namespace ObjectVsGenericClass;
using System;



    public class StartUp
    {
        public static void Main(string[] args)
        {
            GenericsList<int> genericList = new GenericsList<int>();

            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            GenericsList<string> genericListString = new GenericsList<string>();
            genericListString.Add("5");
            genericListString.Add("2");
            genericListString.Add("1");
            ObjectList objectList = new ObjectList();
            objectList.Add(2);
            objectList.Add('w');
            objectList.Add("Stefan");
            objectList.Add(2.33m);
            string secondElement = (string)objectList[2];
            Console.WriteLine(secondElement);

        }
}

