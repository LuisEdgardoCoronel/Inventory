using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TCategories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumeria" }
                });

            migrationBuilder.InsertData(
                table: "TWareHouse",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[,]
                {
                    { "b542b6d1-ceef-4bc1-a0dd-f1f4fdf50cfb", "Av. Libertador 1345", "Bodega Norte" },
                    { "f416e48e-1354-416a-a74b-51ab92172c79", "24 de Septiembre y Ayacucho", "Bodega Sur" },
                    { "fb7efbe8-0586-494f-abbb-3e0f0b6ffafc", "Sarmiento 345", "Bodega Central" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TCategories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "TCategories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "TCategories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "TCategories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "TWareHouse",
                keyColumn: "WareHouseId",
                keyValue: "b542b6d1-ceef-4bc1-a0dd-f1f4fdf50cfb");

            migrationBuilder.DeleteData(
                table: "TWareHouse",
                keyColumn: "WareHouseId",
                keyValue: "f416e48e-1354-416a-a74b-51ab92172c79");

            migrationBuilder.DeleteData(
                table: "TWareHouse",
                keyColumn: "WareHouseId",
                keyValue: "fb7efbe8-0586-494f-abbb-3e0f0b6ffafc");
        }
    }
}
