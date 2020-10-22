using System.Collections.Generic;
using Models;

namespace DAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        DataManager dataManager;
        List<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>();
            dataManager = new DataManager();
            //categories = GetAll();

        }

        public void Create(Category category)
        {
            categories.Add(category);
            SaveChanges();
        }

        public void Delete(int index)
        {

        }

        public void Update(int index, Category category)
        {

        }

        public void SaveChanges()
        {
            dataManager.Serialize(categories);
        }

        public List<Category> GetAll()
        {
            List<Category> savedCategories = new List<Category>();
            savedCategories = dataManager.Deserialize(categories, nameof(Category));
            return savedCategories;
        }
    }
}