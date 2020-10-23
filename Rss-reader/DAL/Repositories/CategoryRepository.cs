using System.Collections.Generic;
using Models;

namespace DAL.Repositories
{
    public class CategoryRepository : Repository<Category>
    {

        public override List<Category> GetAll()
        {
            List<Category> savedCategories = new List<Category>();
            savedCategories = dataManager.Deserialize(objectList, nameof(Category));
            return savedCategories;
        }
    }
}