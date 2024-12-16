using MediatR;

namespace ApiSolution.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
    {

    }
}
