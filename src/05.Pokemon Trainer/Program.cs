using _05._PokemonTrainer;

List<Trainer> trainers = new List<Trainer>();

string command = Console.ReadLine();
while (command != "Tournament")
{
    string[] data = command.Split();
    string trainerName = data[0];
    string pokemonName = data[1];
    string pokemonElement = data[2];
    int pokemonHealth = int.Parse(data[3]);
    var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

    if (!trainers.Any(trainer => trainer.Name == trainerName))
    {
        trainers.Add(new Trainer(trainerName));
    }

    var trainer = trainers.First(trainer => trainer.Name == trainerName);
    trainer.Pokemons.Add(pokemon);

    command = Console.ReadLine();
}

command = Console.ReadLine();
while (command != "End")
{
    foreach (var trainer in trainers)
    {
        trainer.CheckPokemonElement(command);
    }

    command = Console.ReadLine();
}

PrintTrainers(trainers);


static void PrintTrainers(List<Trainer> trainers)
{
    foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
    {
        Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
    }
}