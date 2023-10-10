using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blogger.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"), "Sinema", "Admin", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(681), null, null, null, null, false },
                    { new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"), "Spor", "Admin", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(678), null, null, null, null, false },
                    { new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"), "Tiyatro", "Admin", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(684), null, null, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("06227709-06de-407e-abd9-9a61b5281852"), "Admin", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(764), null, null, "images/File1.jpg", ".jpg", null, null, false },
                    { new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"), "Admin", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(766), null, null, "images/File12.jpg", ".jpg", null, null, false },
                    { new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"), "Admin", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(769), null, null, "images/File13.jpg", ".jpg", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("01e52e32-1321-4d63-a375-9f261d2959d9"), new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"), "Konu üzerine alıştırmalar3", "AdminTest", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(508), null, null, new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"), null, null, "deneme3", 1, false },
                    { new Guid("3734eaa9-9ec4-4d7d-9489-2d79be9ed468"), new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"), "Konu üzerine alıştırmalar", "AdminTest", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(490), null, null, new Guid("06227709-06de-407e-abd9-9a61b5281852"), null, null, "deneme1", 1, false },
                    { new Guid("8b6507f4-c057-4ba5-95b6-14b99f3cdbca"), new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"), "Konu üzerine alıştırmalar2", "AdminTest", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(494), null, null, new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"), null, null, "deneme2", 1, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("01e52e32-1321-4d63-a375-9f261d2959d9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3734eaa9-9ec4-4d7d-9489-2d79be9ed468"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8b6507f4-c057-4ba5-95b6-14b99f3cdbca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("06227709-06de-407e-abd9-9a61b5281852"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
