using _03.TeamworkProjects;

int numberOfTeams = int.Parse(Console.ReadLine());
List<Team> teams = new();

for (int i = 0; i < numberOfTeams; i++)
{
    string[] input = Console.ReadLine().Split('-');
    string creator = input[0];
    string teamName = input[1];

    bool isTeamNameExist = teams.Any(team => team.TeamName == teamName);
    if (isTeamNameExist)
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }

    bool isCreatorExist = teams.Any(team => team.Creator == creator);
    if (isCreatorExist)
    {
        Console.WriteLine($"{creator} cannot create another team!");
    }

    if (!isTeamNameExist && !isCreatorExist)
    {
        var team = new Team(teamName, creator);
        teams.Add(team);
        Console.WriteLine($"Team {teamName} has been created by {creator}!");
    }
}

string command = Console.ReadLine();
while (command != "end of assignment")
{
    string[] input = command.Split("->");
    string user = input[0];
    string teamName = input[1];

    bool isTeamNameExist = teams.Any(team => team.TeamName == teamName);
    if (!isTeamNameExist)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
    }

    bool isUserExist = teams.Any(team => team.Creator == user || team.Members.Contains(user));
    if (isUserExist)
    {
        Console.WriteLine($"Member {user} cannot join team {teamName}!");
    }

    if (isTeamNameExist && !isUserExist)
    {
        var team = teams.First(team => team.TeamName == teamName);
        team.Members.Add(user);
    }

    command = Console.ReadLine();
}

var orderedTeams = teams
    .Where(team => team.Members.Count > 0)
    .OrderByDescending(team => team.Members.Count)
    .ThenBy(team => team.TeamName);

foreach (var team in orderedTeams)
{
    Console.WriteLine(team.TeamName);
    Console.WriteLine("- " + team.Creator);

    foreach (var member in team.Members.OrderBy(m => m))
    {
        Console.WriteLine("-- " + member);
    }
}

Console.WriteLine("Teams to disband: ");
var teamsWithoutMembers = teams.Where(team => team.Members.Count == 0);
foreach (var team in teamsWithoutMembers)
{
    Console.WriteLine(team.TeamName);
}