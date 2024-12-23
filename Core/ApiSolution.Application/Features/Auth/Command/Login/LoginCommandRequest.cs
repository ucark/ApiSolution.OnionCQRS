using MediatR;
using System.ComponentModel;

namespace ApiSolution.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest :IRequest<LoginCommandResponse>
    {
        [DefaultValue("furkan19@gmail.com")]
        public string Email { get; set; }

        [DefaultValue("123456")]
        public string Password { get; set; }
    }
}
