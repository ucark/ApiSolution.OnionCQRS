using ApiSolution.Application.Bases;
using ApiSolution.Application.Features.Products.Exception;
using ApiSolution.Domain.Entities;

namespace ApiSolution.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x => x.Title == requestTitle))
            throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
