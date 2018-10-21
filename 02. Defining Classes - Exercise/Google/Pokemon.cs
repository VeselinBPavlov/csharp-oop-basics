namespace Google
{
    public class Pokemon
    {
        // Field.
        private string pokemonName;
        private string pokemonType;

        // Properties.
        public string PokemonName { get => pokemonName; set => pokemonName = value; }
        public string PokemonType { get => pokemonType; set => pokemonType = value; }

        // Constructor.
        public Pokemon(string pokemonName, string pokemonType)
        {
            this.PokemonName = pokemonName;
            this.PokemonType = pokemonType;
        }       
    }
}
