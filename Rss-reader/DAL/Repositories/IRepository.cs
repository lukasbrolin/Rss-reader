using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {

        void Create(T entity);
        void Delete(string value);
        void Update(string valueBefore, string value);
        void SaveChanges();
        List<T> GetAll();

    }
}