using ApiSolution.Application.Bases;

namespace ApiSolution.Application.Features.Auth.Command.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseException
    {
        public EmailAddressShouldBeValidException() : base("Böyle bir mail adresi bulunmamaktadır.") { }
    }
}
