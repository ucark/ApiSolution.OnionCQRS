using ApiSolution.Application.Bases;

namespace ApiSolution.Application.Features.Auth.Command.Exceptions
{
    public class UserAlreadyExistException : BaseException
    {
        public UserAlreadyExistException() : base("Böyle bir kullanıcı zaten var.!") { }
    }
}
