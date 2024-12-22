using ApiSolution.Application.Bases;

namespace ApiSolution.Application.Features.Products.Exception
{
    public class ProductTitleMustNotBeSameException : BaseException
    {
        public ProductTitleMustNotBeSameException() : base("Ürün Başlığı Zaten Var!") { }
    }
}
