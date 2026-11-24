namespace EsportsHub.Core.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = string.Empty;

        public string RealName {get; set; } = string.Empty;
        public int Age { get; set; }
        public string Nationality { get; set; } = string.Empty;

    }
}