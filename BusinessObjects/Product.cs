namespace BusinessObjects
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UbitPrice { get; set; }

        public Product()
        {

        }
        public Product(int productId, string productName, int categoryId, short? unitsInStock, decimal? ubitPrice)
        {
            ProductId = productId;
            ProductName = productName;
            CategoryId = categoryId;
            UnitsInStock = unitsInStock;
            UbitPrice = ubitPrice;
        }

        public virtual Category Category { get; set; }
    }
}
