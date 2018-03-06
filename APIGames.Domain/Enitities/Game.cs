using System;

namespace APIGames.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Produce { get; private set; }
        public string Distributor { get; private set; }
        public string Genre { get; private set; }
        public string Site { get; private set; }
    }
}
