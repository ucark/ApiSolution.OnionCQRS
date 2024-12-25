using MediatR;

namespace ApiSolution.Application.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandRequest : IRequest<Unit>
    {
        public string Name { get; set; }
    }
}
