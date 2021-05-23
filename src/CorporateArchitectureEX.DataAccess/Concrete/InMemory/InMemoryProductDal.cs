using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CorporateArchitectureEX.DataAccess.Abstract;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal :IProductDal
    {
        private List<Product> _products;

        #region ctor

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductID = 1,CategoryID = 1,ProductName = "Cup",UnitPrice = 15,UnitsInStock = 15},
                new Product{ProductID = 2,CategoryID = 1,ProductName = "Camera",UnitPrice = 500,UnitsInStock = 3},
                new Product{ProductID = 3,CategoryID = 2,ProductName = "Phone",UnitPrice = 1400,UnitsInStock = 2},
                new Product{ProductID = 4,CategoryID = 3,ProductName = "Keyboard",UnitPrice = 235,UnitsInStock = 25},
                new Product{ProductID = 5,CategoryID = 5,ProductName = "Mouse",UnitPrice = 85,UnitsInStock = 1}
            };
        }
        #endregion
        #region Implementation of IProductDal

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(i => i.ProductID == product.ProductID);

            if (productToUpdate != null)
            {
                productToUpdate.CategoryID = product.CategoryID;
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.UnitPrice = product.UnitPrice;
            }
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(i => i.ProductID == product.ProductID);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(i => i.CategoryID == categoryId).ToList();
        }

        #endregion
    }
}
