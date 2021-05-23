using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CorporateArchitectureEX.DataAccess.Abstract;
using CorporateArchitectureEX.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CorporateArchitectureEX.DataAccess.Concrete.EF
{
    public class EFProductDal :IProductDal
    {
        #region Implementation of IEntityRepository<Product>

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            // IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    :context.Set<Product>().Where(filter).ToList();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            // IDisposable pattern implementation of c#
            using NorthwindContext context = new NorthwindContext();
            return context.Set<Product>().SingleOrDefault(filter);
        }

        public void Add(Product entity)
        {
            // IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product entity)
        {
            // IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            // IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Product> GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
