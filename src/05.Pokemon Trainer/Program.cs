using _04._PokemonTrainer;

string command = Console.ReadLine();
List<Trainer> trainers = new();

while (command != "Tournament")
{
    string[] data = command.Split(" ");
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
    trainer.PokemonCollection.Add(pokemon);

    command = Console.ReadLine();
}

while (command != "End")
{
    foreach (var trainer in trainers)
    {
        trainer.CheckPokemonElement(command);
    }

    command = Console.ReadLine();
}

var sortedTrainers = trainers.OrderByDescending(trainer => trainer.NumberOfBadges);

foreach (var trainer in sortedTrainers)
{
    Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
}