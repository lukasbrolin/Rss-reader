using Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace DAL.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public event EventHandler<CategoryEvent> OnCategoryDelete; 
        public CategoryRepository()
        {
            ObjectList = GetAll();
        }

        public override void UpdateCategory(string valueBefore, string value)
        {
            foreach (var c in ObjectList)
            {
                if (c.Title.Equals(valueBefore))
                {
                    c.Title = value;
                }
            }
            string valueBeforePath = @"..\Debug\" + valueBefore + ".xml";
            string valuePath = @"..\Debug\" + value + ".xml";
            DataManager.SerializeRename(valueBeforePath, valuePath);
            SaveChanges();
        }
        public List<Category> GetList
        {
            get
            {
                return ObjectList;
            }
        }

        public override void SaveChanges()
        {
            foreach (var c in ObjectList)
            {
                DataManager.Serialize(c.Title + ".xml");
            }
        }

        public override void Delete(string value)
        {
            for (int i = 0; i < ObjectList.Count; i++)
            {
                if (ObjectList[i].Title.Equals(value))
                {
                    var data = new CategoryEvent {Title = value};
                    DataManager.SerializeDelete(@"..\Debug\" + ObjectList[i].Title + ".xml");
                    OnCategoryDelete(this, data);
                    break;

                }
            }
        }

        public override List<Category> GetAll()
        {
            try
            {
                if (ObjectList != null)
                {
                    ObjectList.Clear();
                }
                List<Category> savedCategories = new List<Category>();
                string[] XMLfiles = Directory.GetFiles(@"..\Debug\", "*.XML");
                foreach (string file in XMLfiles)
                {
                    savedCategories.Add(new Category(Path.GetFileName(file).Split('.')[0]));
                }

                ObjectList = savedCategories;
                return savedCategories;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Var god lägg till en kategori");
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}