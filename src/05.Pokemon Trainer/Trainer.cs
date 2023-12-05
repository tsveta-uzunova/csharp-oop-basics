namespace _05._PokemonTrainer;

public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        Pokemons = new List<Pokemon>();
    }

    public void CheckPokemonElement(string element)
    {
        if (Pokemons.Any(p => p.Element == element))
        {
            Badges++;
        }
        else
        {
            foreach (Pokemon pokemon in Pokemons)
            {
                pokemon.Health -= 10;
            }

        }

        Pokemons.RemoveAll(p => p.Health <= 0);
    }

}
