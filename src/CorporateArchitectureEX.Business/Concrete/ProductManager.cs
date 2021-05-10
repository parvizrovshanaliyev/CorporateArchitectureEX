using System.Collections.Generic;
using CorporateArchitectureEX.Business.Abstract;
using CorporateArchitectureEX.DataAccess.Abstract;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.Business.Concrete
{
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

        #endregion
    }
}
