using System.Collections.Generic;

namespace DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        internal DataManager dataManager;
        internal List<T> objectList;


        public Repository()
        {
            dataManager = new DataManager();
            objectList = GetAll();

        }

        public virtual void Create(T value)
        {
            objectList.Add(value);
            SaveChanges();
        }

        public void Delete(int index)
        {

        }

        public void Update(int index, T value)
        {

        }

        public void SaveChanges()
        {
            dataManager.Serialize(objectList);
        }

        public virtual List<T> GetAll()
        {
            return new List<T>();
        }
    }
}