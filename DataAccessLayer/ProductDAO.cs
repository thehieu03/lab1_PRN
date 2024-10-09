using BusinessObjects;

namespace DataAccessLayer
{

    public class ProductDAO : SingletonBase<ProductDAO>
    {
        private List<Product> list;
        public ProductDAO()
        {
            list = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Chai", CategoryId = 3, UnitsInStock = 12, UbitPrice = 18 },
                new Product { ProductId = 2, ProductName = "Chang", CategoryId = 1, UnitsInStock = 23, UbitPrice = 19 },
                new Product { ProductId = 3, ProductName = "Aniseed Syrup", CategoryId = 2, UnitsInStock = 23, UbitPrice = 10 }
            };
        }
        public List<Product> GetAllProduct()
        {
            return list;
        }
        public int getMaxProductId()
        {
            if (list.Count > 0)
            {
                return list.Max(p => p.ProductId);
            }
            else
            {
                return 0;
            }
        }
        public void SaveProduct(Product product)
        {
            list.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            foreach (var item in list.ToList())
            {
                if (item.ProductId == product.ProductId)
                {
                    item.ProductId = product.ProductId;
                    item.ProductName = product.ProductName;
                    item.CategoryId = product.CategoryId;
                    item.UnitsInStock = product.UnitsInStock;
                    item.UbitPrice = product.UbitPrice;
                }
            }
        }
        public void deleteProdcut(Product product)
        {
            foreach (var item in list.ToList())
            {
                if (item.ProductId == product.ProductId)
                {
                    list.Remove(product);
                }
            }
        }
        public Product GetProductById(int productId)
        {
            Product p = new Product();
            foreach (var item in list.ToList())
            {
                if (item.ProductId == productId)
                {
                    p = item;
                }
            }
            return p;
        }
    }
}
