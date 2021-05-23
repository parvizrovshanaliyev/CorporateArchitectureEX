using System;
using CorporateArchitectureEX.Business.Concrete;
using CorporateArchitectureEX.DataAccess.Concrete.EF;
using CorporateArchitectureEX.DataAccess.Concrete.InMemory;

namespace CorporateArchitectureEX.ConseleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
