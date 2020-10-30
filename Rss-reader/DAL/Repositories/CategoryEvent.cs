using System;

namespace DAL.Repositories
{
    public class CategoryEvent : EventArgs
    {
        public string Title { get; set; }
    }
    public class UpdateEvent : EventArgs
    {

    }
}