using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        internal DataManager dataManager;
        public List<T> objectList { get; set; }

        public Repository()
        {
            dataManager = new DataManager();
        }

        public virtual void Create(T value)
        {
            objectList.Add(value);
            SaveChanges();
        }

        public virtual void Delete(string value)
        {
        }

        public virtual void UpdateCategory(string valueBefore, string value)
        {
        }

        public virtual void SaveChanges()
        {
        }

        public virtual List<T> GetAll()
        {
            return new List<T>();
        }

        
    }
}