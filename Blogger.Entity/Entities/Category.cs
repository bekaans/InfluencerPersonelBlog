using Blogger.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Category :EntityBase
    {
      
        public string CategoryName { get; set; }
        public ICollection<Article> Articles { get; set; }


    }
}
