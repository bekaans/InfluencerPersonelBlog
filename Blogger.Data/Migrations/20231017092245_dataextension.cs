using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blogger.Data.Migrations
{
    /// <inheritdoc />
    public partial class dataextension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("942bd78f-58ba-4344-9dbb-bdf77551c12b"), new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"), "Konu üzerine alıştırmalar2", "AdminTest", new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9257), null, null, new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"), null, null, "deneme2", 1, false },
                    { new Guid("c5dd2b02-5d90-4eea-86cd-930beca60c36"), new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"), "Konu üzerine alıştırmalar3", "AdminTest", new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9270), null, null, new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"), null, null, "deneme3", 1, false },
                    { new Guid("f7b332c7-a519-445c-9487-35ddc990b101"), new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"), "Konu üzerine alıştırmalar", "AdminTest", new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9252), null, null, new Guid("06227709-06de-407e-abd9-9a61b5281852"), null, null, "deneme1", 1, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("06227709-06de-407e-abd9-9a61b5281852"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 17, 12, 22, 44, 925, DateTimeKind.Local).AddTicks(9575));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("942bd78f-58ba-4344-9dbb-bdf77551c12b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c5dd2b02-5d90-4eea-86cd-930beca60c36"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f7b332c7-a519-445c-9487-35ddc990b101"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("01e52e32-1321-4d63-a375-9f261d2959d9"), new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"), "Konu üzerine alıştırmalar3", "AdminTest", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(508), null, null, new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"), null, null, "deneme3", 1, false },
                    { new Guid("3734eaa9-9ec4-4d7d-9489-2d79be9ed468"), new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"), "Konu üzerine alıştırmalar", "AdminTest", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(490), null, null, new Guid("06227709-06de-407e-abd9-9a61b5281852"), null, null, "deneme1", 1, false },
                    { new Guid("8b6507f4-c057-4ba5-95b6-14b99f3cdbca"), new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"), "Konu üzerine alıştırmalar2", "AdminTest", new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(494), null, null, new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"), null, null, "deneme2", 1, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21c3fc25-d3d5-4454-bede-4667d3ffb807"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8796b8a7-b7e6-4e55-b72e-7efcc8e8c3bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0e722bd-834d-4e66-a2e2-2865d06e1281"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("06227709-06de-407e-abd9-9a61b5281852"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2b50160d-2f34-4b6b-bc3c-ee5fb76bfd0f"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bef41f71-3c3a-4c41-b256-bae6c5cae8dc"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 15, 32, 15, 171, DateTimeKind.Local).AddTicks(769));
        }
    }
}
