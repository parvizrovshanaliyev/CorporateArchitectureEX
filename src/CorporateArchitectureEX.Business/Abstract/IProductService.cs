using System.Collections.Generic;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
