using System.Collections.Generic;
using DAL.Repositories;

namespace BL
{
    public abstract class Controller<T> where T : class
    {
        internal IRepository<T> objectRepository;

        public Controller()
        {
            createRepository();
        }

        public virtual void createRepository()
        {
        }

        public List<T> GetAll()
        {
            return objectRepository.GetAll();
        }

    }
}