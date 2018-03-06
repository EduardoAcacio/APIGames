using System;

namespace APIGames.Domain.Entities
{
    public class GamePlatform
    {
        public Guid Id { get; private set; }
        public Game Game { get; set; }
        public Platform Platform { get; set; }
        public DateTime LaunchGame { get; set; }
    }
}
