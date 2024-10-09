using BusinessObjects;
using DataAccessLayer;

namespace Reponsitories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return CategoryDAO.Instance.GetCategories();
        }
    }
}
