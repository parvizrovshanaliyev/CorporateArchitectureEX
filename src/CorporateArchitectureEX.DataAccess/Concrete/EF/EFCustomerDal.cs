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
    public class EFCustomerDal:ICustomerDal
    {
        #region Implementation of IEntityRepository<Customer>

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
