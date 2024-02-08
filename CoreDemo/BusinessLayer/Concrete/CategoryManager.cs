using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        EfCategoryRepository _categoryRepository;

        public CategoryManager()
        {
            _categoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            _categoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryRepository.GetListAll();
        }
    }
}
