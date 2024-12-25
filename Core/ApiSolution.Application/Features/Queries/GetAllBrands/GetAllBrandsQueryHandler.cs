using ApiSolution.Application.Bases;
using ApiSolution.Application.Interfaces.AutoMapper;
using ApiSolution.Application.Interfaces.UnitOfWorks;
using ApiSolution.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace ApiSolution.Application.Features.Queries.GetAllBrands
{
    public class GetAllBrandsQueryHandler :BaseHandler ,IRequestHandler<GetAllBrandsQueryRequest, IList<GetAllBrandsQueryResponse>>
    {
        public GetAllBrandsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllBrandsQueryResponse>> Handle(GetAllBrandsQueryRequest request, CancellationToken cancellationToken)
        {
            var brands = await unitOfWork.GetReadRepository<Brand>().GetAllAsync();

            return mapper.Map<GetAllBrandsQueryResponse, Brand>(brands);

        }
    }
}
