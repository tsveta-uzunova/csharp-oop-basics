namespace _05._PokemonTrainer;

public class Trainer
{
    public string Name { get; set; }
    public int NumberOfBadges { get; set; }
    public List<Pokemon> PokemonCollection { get; set; }

    public Trainer(string name)
    {
        Name = name;
        NumberOfBadges = 0;
        PokemonCollection = new List<Pokemon>();
    }

    public void CheckPokemonElement(string element)
    {
        bool hasPokemonWithElement = PokemonCollection.Any(p => p.Element == element);
        if (hasPokemonWithElement)
        {
            NumberOfBadges++;
        }
        else
        {
            foreach (var pokemon in PokemonCollection)
            {
                pokemon.Health -= 10;
            }
        }
        PokemonCollection.RemoveAll(p => p.Health <= 0);
    }

}
