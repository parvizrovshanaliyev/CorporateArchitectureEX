using System.Collections.Generic;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);
        List<Product> GeByUnitPrice(decimal min, decimal max);
    }
}
