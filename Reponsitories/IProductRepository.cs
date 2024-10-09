using BusinessObjects;

namespace Reponsitories
{
    public interface IProductRepository
    {
        void SaveProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        int getMaxId();

    }
}
