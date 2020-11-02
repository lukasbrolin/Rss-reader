
namespace Models
{
    public class Category
    {
        public string Title { get; set; }
        public Category()
        {
        }
        public Category(string title)
        {
            this.Title = title;
        }
    }
}