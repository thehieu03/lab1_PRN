using BusinessObjects;
using DataAccessLayer;

namespace Reponsitories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product product) => ProductDAO.Instance.deleteProdcut(product);

        public List<Product> GetAllProducts() => ProductDAO.Instance.GetAllProduct();

        public int getMaxId() => ProductDAO.Instance.getMaxProductId();

        public Product GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public void SaveProduct(Product product) => ProductDAO.Instance.SaveProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
