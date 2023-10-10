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
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {

                Id = Guid.Parse("8796B8A7-B7E6-4E55-B72E-7EFCC8E8C3BC"),
                CategoryName = "Spor",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false,
            },
            new Category
            {

                Id = Guid.Parse("21C3FC25-D3D5-4454-BEDE-4667D3FFB807"),
                CategoryName = "Sinema",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false,
            },
            new Category
            {
                Id = Guid.Parse("D0E722BD-834D-4E66-A2E2-2865D06E1281"),
                CategoryName = "Tiyatro",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false,
            }
            );
        }
    }
}
