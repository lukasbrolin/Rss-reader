using System.Collections.Generic;
using DAL.Repositories;

namespace BL
{
    public abstract class Controller<T> where T : class
    {
        public IRepository<T> objectRepository;
        internal static CategoryRepository categoryRepository = new CategoryRepository();

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

    //Plymorph
    //
}