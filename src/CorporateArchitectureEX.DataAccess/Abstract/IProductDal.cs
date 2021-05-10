﻿using System.Collections.Generic;
using CorporateArchitectureEX.Entities.Concrete;

namespace CorporateArchitectureEX.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }

    public interface ICategoryDal
    {
    }
}
