using System;

namespace APIGames.Domain.Entities
{
    public class MyGames
    {
        public Guid Id { get; private set; }
        public GamePlatform GamePlatform { get; private set; }
        public bool Favorite { get; private set; }
        public DateTime FavoriteDate { get; private set; }
    }
}
