namespace AlfarBackEndChallenge.Application.Models.Configs
{
    public class Settings
    {
        public string AllowedHosts { get; set; }
        public string Provider { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}