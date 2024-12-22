using ApiSolution.Application.Bases;
using ApiSolution.Application.Features.Auth.Command.Exceptions;
using ApiSolution.Domain.Entities;

namespace ApiSolution.Application.Features.Auth.Command.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }
    }
}
