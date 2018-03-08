using System;
using APIGames.Domain.Arguments.Gamer;
using APIGames.Domain.ValueObjects;

namespace APIGames.Domain.Interfaces.Services
{
    public interface IServiceGamer
    {
        string AuthenticateGamer(string email, string senha);
        AddGamerResponse AddGamer(AddGamerRequest request);
    }
}