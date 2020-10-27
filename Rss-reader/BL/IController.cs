using System.Collections.Generic;

namespace BL
{
    public interface IController<T> where T : class
    {
        List<T> GetAll();
    }
}