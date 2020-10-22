using System.Collections.Generic;
using DAL.Repositories;
using Models;

namespace BL
{
    public class CategoryController
    {
        private IRepository<Category> categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public void CreateCategory()
        {
            Category newCategory = new Category();
            categoryRepository.Create(newCategory);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

    }
}