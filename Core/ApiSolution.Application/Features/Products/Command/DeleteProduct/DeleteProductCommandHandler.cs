﻿using ApiSolution.Application.Interfaces.UnitOfWorks;
using ApiSolution.Domain.Entities;
using MediatR;

namespace ApiSolution.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            product.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(product);
            await unitOfWork.SaveAsync();
        }
    }
}