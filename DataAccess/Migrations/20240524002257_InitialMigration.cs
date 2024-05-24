using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCategories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TWareHouse",
                columns: table => new
                {
                    WareHouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WareHouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WareHouseAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWareHouse", x => x.WareHouseId);
                });

            migrationBuilder.CreateTable(
                name: "TProducts",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_TProducts_TCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TStorages",
                columns: table => new
                {
                    StorageId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartialQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    WareHouseId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TStorages", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_TStorages_TProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TProducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TStorages_TWareHouse_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "TWareHouse",
                        principalColumn: "WareHouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TInputs",
                columns: table => new
                {
                    InOutId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsInput = table.Column<bool>(type: "bit", nullable: false),
                    StorageId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoragesStorageId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TInputs", x => x.InOutId);
                    table.ForeignKey(
                        name: "FK_TInputs_TStorages_StoragesStorageId",
                        column: x => x.StoragesStorageId,
                        principalTable: "TStorages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TInputs_StoragesStorageId",
                table: "TInputs",
                column: "StoragesStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_TProducts_CategoryId",
                table: "TProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TStorages_ProductId",
                table: "TStorages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TStorages_WareHouseId",
                table: "TStorages",
                column: "WareHouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TInputs");

            migrationBuilder.DropTable(
                name: "TStorages");

            migrationBuilder.DropTable(
                name: "TProducts");

            migrationBuilder.DropTable(
                name: "TWareHouse");

            migrationBuilder.DropTable(
                name: "TCategories");
        }
    }
}
