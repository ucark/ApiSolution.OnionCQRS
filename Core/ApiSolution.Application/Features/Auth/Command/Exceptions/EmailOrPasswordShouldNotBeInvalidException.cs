using ApiSolution.Application.Bases;

namespace ApiSolution.Application.Features.Auth.Command.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Kullanıcı adı veya şifre hatalı.") { }
    }
}
