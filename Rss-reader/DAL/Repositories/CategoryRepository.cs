using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DAL.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public event EventHandler<CategoryEvent> onCategoryDelete; 
        public CategoryRepository()
        {
            objectList = GetAll();
        }

        public override void UpdateCategory(string valueBefore, string value)
        {
            foreach (var c in objectList)
            {
                if (c.Title.Equals(valueBefore))
                {
                    c.Title = value;
                }
            }
            string valueBeforePath = @"..\Debug\" + valueBefore + ".xml";
            string valuePath = @"..\Debug\" + value + ".xml";
            dataManager.SerializeRename(valueBeforePath, valuePath);
            //SaveChanges();
        }
        public List<Category> GetList
        {
            get
            {
                return objectList;
            }
        }

        public override void SaveChanges()
        {
            foreach (var c in objectList)
            {
                dataManager.Serialize(c.Title + ".xml");
            }
        }

        public override void Delete(string value)
        {
            for (int i = 0; i < objectList.Count; i++)
            {
                if (objectList[i].Title.Equals(value))
                {
                    var data = new CategoryEvent();
                    data.Title = value;
                    dataManager.SerializeDelete(@"..\Debug\" + objectList[i].Title + ".xml");
                    //objectList.RemoveAt(i);
                    onCategoryDelete(this, data);
                    break;

                }
            }
        }

        public override List<Category> GetAll()
        {
            try
            {
                if (objectList != null)
                {
                    objectList.Clear();
                }
                List<Category> savedCategories = new List<Category>();
                string[] XMLfiles = Directory.GetFiles(@"..\Debug\", "*.XML");
                foreach (string file in XMLfiles)
                {
                    savedCategories.Add(new Category(Path.GetFileName(file).Split('.')[0]));
                }

                objectList = savedCategories;
                return savedCategories;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Var god lägg till en kategori");
                return null;
            }
        }

    }
}