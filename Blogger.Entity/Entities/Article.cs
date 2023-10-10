using Blogger.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Article : EntityBase
    {
      
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }


        //Join
        
        //Category
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
       

        //Image
        public Guid ImageId { get; set; }
        public Image Image { get; set; }


      
    }
}
