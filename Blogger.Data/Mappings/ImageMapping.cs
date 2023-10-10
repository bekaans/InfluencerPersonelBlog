using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Data.Mappings
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("06227709-06DE-407E-ABD9-9A61B5281852"),
                FileName = "images/File1.jpg",
                FileType = ".jpg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("2B50160D-2F34-4B6B-BC3C-EE5FB76BFD0F"),
                FileName = "images/File12.jpg",
                FileType = ".jpg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("BEF41F71-3C3A-4C41-B256-BAE6C5CAE8DC"),
                FileName = "images/File13.jpg",
                FileType = ".jpg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false
            }
            );
        }
    }
}
