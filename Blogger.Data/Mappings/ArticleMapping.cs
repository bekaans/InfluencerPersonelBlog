using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogger.Data.Mappings
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "deneme1",
                Content = "Konu üzerine alıştırmalar",
                ViewCount = 1,
                CategoryId = Guid.Parse("8796B8A7-B7E6-4E55-B72E-7EFCC8E8C3BC"),
                ImageId = Guid.Parse("06227709-06DE-407E-ABD9-9A61B5281852"),
                CreatedBy = "AdminTest",
                CreatedDate = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "deneme2",
                Content = "Konu üzerine alıştırmalar2",
                ViewCount = 1,
                CategoryId = Guid.Parse("21C3FC25-D3D5-4454-BEDE-4667D3FFB807"),
                ImageId = Guid.Parse("2B50160D-2F34-4B6B-BC3C-EE5FB76BFD0F"),
                CreatedBy = "AdminTest",
                CreatedDate = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "deneme3",
                Content = "Konu üzerine alıştırmalar3",
                ViewCount = 1,
                CategoryId = Guid.Parse("D0E722BD-834D-4E66-A2E2-2865D06E1281"),
                ImageId = Guid.Parse("BEF41F71-3C3A-4C41-B256-BAE6C5CAE8DC"),
                CreatedBy = "AdminTest",
                CreatedDate = DateTime.Now
            }
            ) ;
        }
    }
}
