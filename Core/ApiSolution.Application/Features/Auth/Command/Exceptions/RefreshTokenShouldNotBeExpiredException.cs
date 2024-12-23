using ApiSolution.Application.Bases;

namespace ApiSolution.Application.Features.Auth.Command.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredException : BaseException
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Oturum açma süresi sona ermiştir. Lütfen telrar giriş yapınız.") { }
    }
}
