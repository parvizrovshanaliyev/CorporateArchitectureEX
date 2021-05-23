using System.Collections.Generic;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category data);
        void Update(Category data);
        void Delete(Category data);
        List<Product> GetAllByCategory(int id);
    }
}