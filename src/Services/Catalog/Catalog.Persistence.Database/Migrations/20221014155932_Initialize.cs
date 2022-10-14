using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInStock",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInStock", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_ProductsInStock_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Descripcion 1", "Producto 1", 1485m },
                    { 73, "Descripcion 73", "Producto 73", 1096m },
                    { 72, "Descripcion 72", "Producto 72", 363m },
                    { 71, "Descripcion 71", "Producto 71", 535m },
                    { 70, "Descripcion 70", "Producto 70", 699m },
                    { 69, "Descripcion 69", "Producto 69", 1189m },
                    { 68, "Descripcion 68", "Producto 68", 1264m },
                    { 67, "Descripcion 67", "Producto 67", 118m },
                    { 66, "Descripcion 66", "Producto 66", 713m },
                    { 65, "Descripcion 65", "Producto 65", 1384m },
                    { 64, "Descripcion 64", "Producto 64", 853m },
                    { 63, "Descripcion 63", "Producto 63", 568m },
                    { 62, "Descripcion 62", "Producto 62", 770m },
                    { 61, "Descripcion 61", "Producto 61", 902m },
                    { 60, "Descripcion 60", "Producto 60", 441m },
                    { 59, "Descripcion 59", "Producto 59", 1377m },
                    { 58, "Descripcion 58", "Producto 58", 1451m },
                    { 57, "Descripcion 57", "Producto 57", 1475m },
                    { 56, "Descripcion 56", "Producto 56", 180m },
                    { 55, "Descripcion 55", "Producto 55", 691m },
                    { 54, "Descripcion 54", "Producto 54", 521m },
                    { 53, "Descripcion 53", "Producto 53", 206m },
                    { 74, "Descripcion 74", "Producto 74", 1234m },
                    { 52, "Descripcion 52", "Producto 52", 960m },
                    { 75, "Descripcion 75", "Producto 75", 150m },
                    { 77, "Descripcion 77", "Producto 77", 798m },
                    { 98, "Descripcion 98", "Producto 98", 1353m },
                    { 97, "Descripcion 97", "Producto 97", 1476m },
                    { 96, "Descripcion 96", "Producto 96", 1421m },
                    { 95, "Descripcion 95", "Producto 95", 161m },
                    { 94, "Descripcion 94", "Producto 94", 1012m },
                    { 93, "Descripcion 93", "Producto 93", 115m },
                    { 92, "Descripcion 92", "Producto 92", 862m },
                    { 91, "Descripcion 91", "Producto 91", 754m },
                    { 90, "Descripcion 90", "Producto 90", 147m },
                    { 89, "Descripcion 89", "Producto 89", 1091m },
                    { 88, "Descripcion 88", "Producto 88", 976m },
                    { 87, "Descripcion 87", "Producto 87", 748m },
                    { 86, "Descripcion 86", "Producto 86", 1147m },
                    { 85, "Descripcion 85", "Producto 85", 518m },
                    { 84, "Descripcion 84", "Producto 84", 1272m },
                    { 83, "Descripcion 83", "Producto 83", 214m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Descripcion 82", "Producto 82", 828m },
                    { 81, "Descripcion 81", "Producto 81", 257m },
                    { 80, "Descripcion 80", "Producto 80", 828m },
                    { 79, "Descripcion 79", "Producto 79", 900m },
                    { 78, "Descripcion 78", "Producto 78", 257m },
                    { 76, "Descripcion 76", "Producto 76", 757m },
                    { 51, "Descripcion 51", "Producto 51", 840m },
                    { 50, "Descripcion 50", "Producto 50", 292m },
                    { 49, "Descripcion 49", "Producto 49", 848m },
                    { 22, "Descripcion 22", "Producto 22", 1404m },
                    { 21, "Descripcion 21", "Producto 21", 1202m },
                    { 20, "Descripcion 20", "Producto 20", 742m },
                    { 19, "Descripcion 19", "Producto 19", 697m },
                    { 18, "Descripcion 18", "Producto 18", 951m },
                    { 17, "Descripcion 17", "Producto 17", 256m },
                    { 16, "Descripcion 16", "Producto 16", 1249m },
                    { 15, "Descripcion 15", "Producto 15", 1329m },
                    { 14, "Descripcion 14", "Producto 14", 1318m },
                    { 13, "Descripcion 13", "Producto 13", 1447m },
                    { 12, "Descripcion 12", "Producto 12", 1416m },
                    { 11, "Descripcion 11", "Producto 11", 1469m },
                    { 10, "Descripcion 10", "Producto 10", 492m },
                    { 9, "Descripcion 9", "Producto 9", 612m },
                    { 8, "Descripcion 8", "Producto 8", 533m },
                    { 7, "Descripcion 7", "Producto 7", 233m },
                    { 6, "Descripcion 6", "Producto 6", 399m },
                    { 5, "Descripcion 5", "Producto 5", 201m },
                    { 4, "Descripcion 4", "Producto 4", 1346m },
                    { 3, "Descripcion 3", "Producto 3", 1347m },
                    { 2, "Descripcion 2", "Producto 2", 304m },
                    { 23, "Descripcion 23", "Producto 23", 329m },
                    { 24, "Descripcion 24", "Producto 24", 1396m },
                    { 25, "Descripcion 25", "Producto 25", 1468m },
                    { 26, "Descripcion 26", "Producto 26", 1259m },
                    { 48, "Descripcion 48", "Producto 48", 268m },
                    { 47, "Descripcion 47", "Producto 47", 1101m },
                    { 46, "Descripcion 46", "Producto 46", 740m },
                    { 45, "Descripcion 45", "Producto 45", 596m },
                    { 44, "Descripcion 44", "Producto 44", 172m },
                    { 43, "Descripcion 43", "Producto 43", 706m },
                    { 42, "Descripcion 42", "Producto 42", 545m },
                    { 41, "Descripcion 41", "Producto 41", 691m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Descripcion 40", "Producto 40", 963m },
                    { 39, "Descripcion 39", "Producto 39", 1354m },
                    { 99, "Descripcion 99", "Producto 99", 288m },
                    { 38, "Descripcion 38", "Producto 38", 1392m },
                    { 36, "Descripcion 36", "Producto 36", 729m },
                    { 35, "Descripcion 35", "Producto 35", 228m },
                    { 34, "Descripcion 34", "Producto 34", 283m },
                    { 33, "Descripcion 33", "Producto 33", 1398m },
                    { 32, "Descripcion 32", "Producto 32", 855m },
                    { 31, "Descripcion 31", "Producto 31", 608m },
                    { 30, "Descripcion 30", "Producto 30", 1259m },
                    { 29, "Descripcion 29", "Producto 29", 1465m },
                    { 28, "Descripcion 28", "Producto 28", 962m },
                    { 27, "Descripcion 27", "Producto 27", 996m },
                    { 37, "Descripcion 37", "Producto 37", 813m },
                    { 100, "Descripcion 100", "Producto 100", 1382m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "ProductsInStock",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 71 },
                    { 73, 73, 177 },
                    { 72, 72, 107 },
                    { 71, 71, 12 },
                    { 70, 70, 118 },
                    { 69, 69, 68 },
                    { 68, 68, 142 },
                    { 67, 67, 171 },
                    { 66, 66, 194 },
                    { 65, 65, 177 },
                    { 64, 64, 80 },
                    { 63, 63, 121 },
                    { 62, 62, 69 },
                    { 61, 61, 14 },
                    { 60, 60, 136 },
                    { 59, 59, 24 },
                    { 58, 58, 13 },
                    { 57, 57, 140 },
                    { 56, 56, 61 },
                    { 55, 55, 150 },
                    { 54, 54, 47 },
                    { 53, 53, 160 },
                    { 74, 74, 17 },
                    { 52, 52, 81 },
                    { 75, 75, 53 },
                    { 77, 77, 192 },
                    { 98, 98, 137 },
                    { 97, 97, 60 },
                    { 96, 96, 167 },
                    { 95, 95, 1 },
                    { 94, 94, 34 },
                    { 93, 93, 3 },
                    { 92, 92, 35 },
                    { 91, 91, 2 },
                    { 90, 90, 81 },
                    { 89, 89, 11 },
                    { 88, 88, 113 },
                    { 87, 87, 98 },
                    { 86, 86, 119 },
                    { 85, 85, 67 },
                    { 84, 84, 141 },
                    { 83, 83, 183 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "ProductsInStock",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 74 },
                    { 81, 81, 115 },
                    { 80, 80, 178 },
                    { 79, 79, 152 },
                    { 78, 78, 25 },
                    { 76, 76, 38 },
                    { 51, 51, 140 },
                    { 50, 50, 178 },
                    { 49, 49, 15 },
                    { 22, 22, 9 },
                    { 21, 21, 20 },
                    { 20, 20, 90 },
                    { 19, 19, 34 },
                    { 18, 18, 148 },
                    { 17, 17, 135 },
                    { 16, 16, 61 },
                    { 15, 15, 61 },
                    { 14, 14, 11 },
                    { 13, 13, 104 },
                    { 12, 12, 132 },
                    { 11, 11, 52 },
                    { 10, 10, 178 },
                    { 9, 9, 88 },
                    { 8, 8, 40 },
                    { 7, 7, 67 },
                    { 6, 6, 131 },
                    { 5, 5, 63 },
                    { 4, 4, 50 },
                    { 3, 3, 151 },
                    { 2, 2, 81 },
                    { 23, 23, 141 },
                    { 24, 24, 138 },
                    { 25, 25, 26 },
                    { 26, 26, 126 },
                    { 48, 48, 43 },
                    { 47, 47, 10 },
                    { 46, 46, 48 },
                    { 45, 45, 185 },
                    { 44, 44, 116 },
                    { 43, 43, 17 },
                    { 42, 42, 181 },
                    { 41, 41, 36 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "ProductsInStock",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 16 },
                    { 39, 39, 171 },
                    { 99, 99, 139 },
                    { 38, 38, 27 },
                    { 36, 36, 142 },
                    { 35, 35, 142 },
                    { 34, 34, 161 },
                    { 33, 33, 160 },
                    { 32, 32, 58 },
                    { 31, 31, 1 },
                    { 30, 30, 7 },
                    { 29, 29, 119 },
                    { 28, 28, 198 },
                    { 27, 27, 117 },
                    { 37, 37, 49 },
                    { 100, 100, 191 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInStock_ProductId",
                schema: "Catalog",
                table: "ProductsInStock",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInStock_ProductInStockId",
                schema: "Catalog",
                table: "ProductsInStock",
                column: "ProductInStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsInStock",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
