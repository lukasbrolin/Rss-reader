using Models;

namespace DAL.Repositories
{
    public interface IRepository
    {
        void UpdateCategory(string name, Category category);
        void UpdateName(string valueBefore, string value);
        void UpdateUrl(string name, string url);
        void UpdateFrequency(string name, UpdateFrequency newFrequency);

    }
}