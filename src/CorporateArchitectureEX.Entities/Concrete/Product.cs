using CorporateArchitectureEX.Entities.Abstract;

namespace CorporateArchitectureEX.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }


    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
