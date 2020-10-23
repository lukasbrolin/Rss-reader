using System;
using DAL.Repositories;
using Models;

namespace BL
{
    public class CategoryController : Controller<Category>
    {

        public override void createRepository()
        {
            objectRepository = new CategoryRepository();
        }

        public void CreateCategory()
        {
            Category newCategory = new Category();
            objectRepository.Create(newCategory);
        }
    }
}