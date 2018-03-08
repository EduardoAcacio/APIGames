using APIGames.Domain.Interfaces.Arguments;
using APIGames.Domain.ValueObjects;

namespace APIGames.Domain.Arguments.Gamer
{
    public class AddGamerRequest : IRequest
    {
        public Name name { get; private set; }
        public Email email { get; private set; }
        public string Senha { get; private set; }
    }
}