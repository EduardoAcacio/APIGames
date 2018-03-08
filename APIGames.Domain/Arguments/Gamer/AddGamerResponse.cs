using System;
using APIGames.Domain.Interfaces.Arguments;

namespace APIGames.Domain.Arguments.Gamer
{
    public class AddGamerResponse : IResponse
    {
        public Guid Id { get; private set; }   
    }
}