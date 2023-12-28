using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace DefiningClasses;
using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        
        
        List<Trainer> trainers = new List<Trainer>();
        string command = "";
        while ((command = Console.ReadLine()) != "Tournament")
        {
            string[] tokens = command.Split(' ');
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement  = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);
            Pokemon pokemon = new Pokemon()
            {
                Name = pokemonName,
                Element = pokemonElement,
                Health = pokemonHealth
            };
            if (!trainers.Exists(x => x.Name == trainerName))
            {
                Trainer trainer = new()
                {
                    Name = trainerName,
                    Pokemons = new List<Pokemon>()
                    {
                        pokemon
                    }

                };
                trainers.Add(trainer);
            }
            else
            {
                var trainer = trainers.Find(x => x.Name == trainerName);
                trainer.Pokemons.Add(pokemon);
            }

        }

        while ((command = Console.ReadLine()) != "End")
        {
           
            foreach (var trainer in trainers)
            {
                if(trainer.Pokemons.Any(x=>x.Element==command))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        var pokemon = trainer.Pokemons[i];
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                    }
                }
            }
        }

        foreach (var VARIABLE in trainers.OrderByDescending(x=>x.NumberOfBadges))
        {
            Console.WriteLine($"{VARIABLE.Name} {VARIABLE.NumberOfBadges} {VARIABLE.Pokemons.Count}");
        }
    }
}