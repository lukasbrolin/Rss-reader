namespace Models
{
    public class Category
    {
        public string Title { get; set; }

        public Category()
        {
            Title = "Nyheter";
        }

        public Category(string title)
        {
            this.Title = title;
        }
    }
}