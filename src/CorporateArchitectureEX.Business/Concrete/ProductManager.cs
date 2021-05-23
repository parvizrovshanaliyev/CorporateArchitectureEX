using System.Collections.Generic;
using CorporateArchitectureEX.Business.Abstract;
using CorporateArchitectureEX.DataAccess.Abstract;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.Business.Concrete
{
    // Solid Dependency inversion
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        #region ctor

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        #endregion
        #region Implementation of IProductService

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(i => i.CategoryID == id);
        }

        public List<Product> GeByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(i => i.UnitPrice >= min && i.UnitPrice<=max);
        }

        #endregion
    }
}
