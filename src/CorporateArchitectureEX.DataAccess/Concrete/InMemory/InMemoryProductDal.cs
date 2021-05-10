using System;
using System.Collections.Generic;
using System.Linq;
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
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Cup",UnitPrice = 15,UnitInStock = 15},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "Camera",UnitPrice = 500,UnitInStock = 3},
                new Product{ProductId = 3,CategoryId = 2,ProductName = "Phone",UnitPrice = 1400,UnitInStock = 2},
                new Product{ProductId = 4,CategoryId = 3,ProductName = "Keyboard",UnitPrice = 235,UnitInStock = 25},
                new Product{ProductId = 5,CategoryId = 5,ProductName = "Mouse",UnitPrice = 85,UnitInStock = 1}
            };
        }
        #endregion
        #region Implementation of IProductDal

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(i => i.ProductId == product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitInStock = product.UnitInStock;
                productToUpdate.UnitPrice = product.UnitPrice;
            }
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(i => i.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(i => i.CategoryId == categoryId).ToList();
        }

        #endregion
    }
}
