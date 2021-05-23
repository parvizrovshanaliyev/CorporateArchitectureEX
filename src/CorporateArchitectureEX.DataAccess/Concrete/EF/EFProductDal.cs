using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CorporateArchitectureEX.DataAccess.Abstract;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.DataAccess.Concrete.EF
{
    public class EFProductDal :IProductDal
    {
        #region Implementation of IEntityRepository<Product>

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
