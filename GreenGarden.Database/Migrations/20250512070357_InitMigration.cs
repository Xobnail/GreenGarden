using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenGarden.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habitats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantsHabitats",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "integer", nullable: false),
                    HabitatId = table.Column<int>(type: "integer", nullable: false),
                    Order = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantsHabitats", x => new { x.HabitatId, x.PlantId });
                    table.ForeignKey(
                        name: "FK_PlantsHabitats_Habitats_HabitatId",
                        column: x => x.HabitatId,
                        principalTable: "Habitats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantsHabitats_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NewPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    PlantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceOffers_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VoterName = table.Column<string>(type: "text", nullable: false),
                    Stars = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PlantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantTag",
                columns: table => new
                {
                    PlantsId = table.Column<int>(type: "integer", nullable: false),
                    TagsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantTag", x => new { x.PlantsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PlantTag_Plants_PlantsId",
                        column: x => x.PlantsId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habitats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tropical Forest" },
                    { 2, "Desert" },
                    { 3, "Temperate Climate" },
                    { 4, "Subtropics" },
                    { 5, "Mountains" }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Orchid" },
                    { 2, "Cactus" },
                    { 3, "Rose" },
                    { 4, "Aloe Vera" },
                    { 5, "Bamboo" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Blooming" },
                    { 2, "Indoor" },
                    { 3, "Garden" },
                    { 4, "Medicinal" },
                    { 5, "Exotic" }
                });

            migrationBuilder.InsertData(
                table: "PlantTag",
                columns: new[] { "PlantsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 5 },
                    { 2, 2 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 3 },
                    { 4, 2 },
                    { 4, 4 },
                    { 5, 3 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "PlantsHabitats",
                columns: new[] { "HabitatId", "PlantId", "Order" },
                values: new object[,]
                {
                    { 1, 1, (byte)1 },
                    { 1, 4, (byte)1 },
                    { 1, 5, (byte)1 },
                    { 2, 2, (byte)1 },
                    { 2, 4, (byte)2 },
                    { 3, 3, (byte)1 },
                    { 4, 1, (byte)2 },
                    { 5, 5, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "PriceOffers",
                columns: new[] { "Id", "NewPrice", "PlantId", "Text" },
                values: new object[,]
                {
                    { 1, 29.99m, 1, "Special offer on orchids!" },
                    { 2, 19.99m, 2, "Discount on cacti this week" },
                    { 3, 15.99m, 3, "Roses at a special price" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "PlantId", "Stars", "VoterName" },
                values: new object[,]
                {
                    { 1, "Beautiful plant!", 1, 5, "Ann" },
                    { 2, "I like it very much!", 1, 4, "Ian" },
                    { 3, "Not bad, but I expected more", 2, 3, "Mary" },
                    { 4, "Perfect for my garden", 3, 5, "Alex" },
                    { 5, "Withered quickly", 4, 2, "Helen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantsHabitats_PlantId",
                table: "PlantsHabitats",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantTag_TagsId",
                table: "PlantTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffers_PlantId",
                table: "PriceOffers",
                column: "PlantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PlantId",
                table: "Reviews",
                column: "PlantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantsHabitats");

            migrationBuilder.DropTable(
                name: "PlantTag");

            migrationBuilder.DropTable(
                name: "PriceOffers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Habitats");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
