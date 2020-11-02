using System.Collections.Generic;

namespace DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public List<T> ObjectList { get; set; }

        public virtual void Create(T value)
        {
            ObjectList.Add(value);
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