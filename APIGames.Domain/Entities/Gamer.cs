using System;
using APIGames.Domain.Enums;
using APIGames.Domain.ValueObjects;

namespace APIGames.Domain.Entities
{
    public class Gamer
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public ESituation Status { get; private set; }
    }
}
