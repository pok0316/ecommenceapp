using System.Linq.Expressions;
using CoreEntity.Entities;

namespace CoreEntity.specifications
{
    public class ProductsWithTypesAndBrandsSpecfication : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecfication()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecfication(int id): base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}