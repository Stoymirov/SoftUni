﻿using System.Threading.Channels;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {


            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            decimal percent = decimal.Parse(Console.ReadLine());

            persons.ForEach(x => x.IncreaseSalary(percent));
            persons.ForEach(x=>Console.WriteLine(x.ToString()));

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team);
            

        }



    }
}