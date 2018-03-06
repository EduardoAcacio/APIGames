using System;

namespace APIGames.Domain.Entities
{
    public class Gamer
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int Status { get; private set; }
    }
}
