using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Models;

namespace DAL.Repositories
{
    public class CategoryRepository : Repository<Category>, IEnumerable
    {
        public event EventHandler<CategoryEvent> onCategoryDelete; 
        public CategoryRepository()
        {
            objectList = GetAll();
        }

        public override void Update(string valueBefore, string value)
        {
            foreach (var c in objectList)
            {
                if (c.Title.Equals(valueBefore))
                {
                    c.Title = value;
                }
            }
            SaveChanges();
        }

        public override void Delete(string value)
        {
            for (int i = 0; i < objectList.Count; i++)
            {
                if (objectList[i].Title.Equals(value))
                {
                    var data = new CategoryEvent();
                    data.Title = value;
                    onCategoryDelete(this, data);
                    dataManager.SerializeDelete(@"..\Debug\" + objectList[i].Title + ".xml");
                    objectList.RemoveAt(i);
                    break;
                }
            }
        }

        public override List<Category> GetAll()
        {
            List<Category> savedCategories = new List<Category>();
            string[] XMLfiles = Directory.GetFiles(@"..\Debug\", "*.XML");
            foreach (string file in XMLfiles)
            {
                savedCategories.Add(new Category(Path.GetFileName(file).Split('.')[0]));
            }

            return savedCategories;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryEvent : EventArgs
    {
        public string Title { get; set; }
    }
}