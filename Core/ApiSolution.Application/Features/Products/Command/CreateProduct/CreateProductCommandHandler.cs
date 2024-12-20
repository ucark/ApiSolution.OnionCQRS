﻿using ApiSolution.Application.Features.Products.Rules;
using ApiSolution.Application.Interfaces.UnitOfWorks;
using ApiSolution.Domain.Entities;
using MediatR;

namespace ApiSolution.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules    )
        {
            this.unitOfWork = unitOfWork;
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            await productRules.ProductTitleMustNotBeSame(products, request.Title);

            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);

            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                    await unitOfWork.GetWriteRepository<ProductCategory>()
                        .AddAsync(new()
                        {
                            ProductId = product.Id,
                            CategoryId = categoryId,
                        });
                await unitOfWork.SaveAsync();
            }

            return Unit.Value;
        }
    }
}
