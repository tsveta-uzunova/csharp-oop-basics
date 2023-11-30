using _02._Articles;

string articleDate = Console.ReadLine();

string title = articleDate.Split(", ")[0];
string content = articleDate.Split(", ")[1];
string author = articleDate.Split(", ")[2];

Article article = new Article(title, content, author);

int numberOfCommands = int.Parse(Console.ReadLine());
for (int i = 1; i <= numberOfCommands; i++)
{
    string command = Console.ReadLine();
    string[] commandParts = command.Split(": ");
    string commandName = commandParts[0];
    string commandParameter = commandParts[1];

    switch (commandName)
    {
        case "Edit":
            article.Edit(commandParameter);
             break;
        case "ChangeAuthor":
            article.ChangeAuthor(commandParameter);
            break;
        case "Rename":
            article.Rename(commandParameter);
            break;
    }
}

Console.WriteLine(article.ToString());




