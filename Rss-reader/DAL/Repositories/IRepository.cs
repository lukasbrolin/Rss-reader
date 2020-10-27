using Models;

namespace DAL.Repositories
{
    public interface IRepository
    {
        void UpdateCategory(string name, string valueBefore, string value);
        void UpdateName(string valueBefore, string value);

        void UpdateFrequency(string name, UpdateFrequency newFrequency);

    }
}