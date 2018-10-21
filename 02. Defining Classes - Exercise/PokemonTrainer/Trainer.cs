using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        // Fields.
        private string name;
        private int badges;

        // Properties.
        public string Name { get => this.name; set => this.name = value; }
        public int Badges { get => this.badges; set => this.badges = value; }

        // Constructor.
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
        }
    }
}
