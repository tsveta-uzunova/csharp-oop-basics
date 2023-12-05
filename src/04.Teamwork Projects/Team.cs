namespace _04.TeamworkProjects
{
    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
    }
}
