namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var tournament = new Dictionary<Trainer, List<Pokemon>>();

            // Create trainers with their pokemons.
            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                var data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var trainerName = data[0];
                var pokemonName = data[1];
                var pokemonElement = data[2];
                var pokemonHealth = int.Parse(data[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                var trainer = new Trainer(trainerName);

                if (tournament.Any(x => x.Key.Name == trainerName) == false)
                {
                    tournament[trainer] = new List<Pokemon>();
                }
                tournament.Where(x => x.Key.Name == trainerName).FirstOrDefault().Value.Add(pokemon);
            }

            // Create tournament.
            string element;
            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in tournament)
                {
                    if (trainer.Value.Contains(trainer.Value.Where(x => x.Element == element).FirstOrDefault()))
                    {
                        trainer.Key.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Value.Count; i++)
                        {
                            trainer.Value[i].Health -= 10;
                            if (trainer.Value[i].Health <= 0)
                            {
                                trainer.Value.RemoveAt(i);
                            }
                        }
                    }                    
                }
            }

            // Print result, ordered by badges.
            foreach (var trainer in tournament.OrderByDescending(t => t.Key.Badges))
            {
                Console.WriteLine($"{trainer.Key.Name} {trainer.Key.Badges} {trainer.Value.Count}");
            }
        }
    }
}
