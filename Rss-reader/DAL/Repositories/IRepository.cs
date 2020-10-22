﻿using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {

        void Create(T entity);
        void Delete(int index);
        void Update(int index, T entity);
        void SaveChanges();
        List<T> GetAll();
    }
}