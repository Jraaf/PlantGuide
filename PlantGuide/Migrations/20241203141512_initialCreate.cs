using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantGuide.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Country__10D1609FD3D2CEAE", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    FamilyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Family__41D82F6B2831C83D", x => x.FamilyId);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScientificName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CommonName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Plant__98FE395C0C7D3ADD", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    SourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Author = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Source__16E019190237B249", x => x.SourceId);
                });

            migrationBuilder.CreateTable(
                name: "TypeSeason",
                columns: table => new
                {
                    TypeSeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TypeSeas__86276B8B1FBABCD6", x => x.TypeSeasonId);
                });

            migrationBuilder.CreateTable(
                name: "Climate",
                columns: table => new
                {
                    ClimateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TemperatureMin = table.Column<double>(type: "float", nullable: true),
                    TemperatureMax = table.Column<double>(type: "float", nullable: true),
                    PrecipitationMin = table.Column<double>(type: "float", nullable: true),
                    PrecipitationMax = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Climate__55D2DDAFDCD706A2", x => x.ClimateId);
                    table.ForeignKey(
                        name: "FK__Climate__PlantId__59FA5E80",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId");
                });

            migrationBuilder.CreateTable(
                name: "FamilyPlant",
                columns: table => new
                {
                    FamilyPlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    FamilyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FamilyPl__BE40E246F755D911", x => x.FamilyPlantId);
                    table.ForeignKey(
                        name: "FK__FamilyPla__Famil__5441852A",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "FamilyId");
                    table.ForeignKey(
                        name: "FK__FamilyPla__Plant__534D60F1",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId");
                });

            migrationBuilder.CreateTable(
                name: "Origin",
                columns: table => new
                {
                    OriginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Years = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Origin__171FA226440757CA", x => x.OriginId);
                    table.ForeignKey(
                        name: "FK__Origin__CountryI__4E88ABD4",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK__Origin__PlantId__4D94879B",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId");
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Author = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Photo__21B7B5E25D066AA2", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK__Photo__PlantId__571DF1D5",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId");
                });

            migrationBuilder.CreateTable(
                name: "SourcePlant",
                columns: table => new
                {
                    SourcesPlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SourcePl__8423F49CBB37CE6A", x => x.SourcesPlantId);
                    table.ForeignKey(
                        name: "FK__SourcePla__Plant__5EBF139D",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId");
                    table.ForeignKey(
                        name: "FK__SourcePla__Sourc__5FB337D6",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "SourceId");
                });

            migrationBuilder.CreateTable(
                name: "FloweringSeasonPlant",
                columns: table => new
                {
                    FloweringSeasonPlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    TypeSeasonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Flowerin__8CD61782C83D2AC3", x => x.FloweringSeasonPlantId);
                    table.ForeignKey(
                        name: "FK__Flowering__Plant__6477ECF3",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId");
                    table.ForeignKey(
                        name: "FK__Flowering__TypeS__656C112C",
                        column: x => x.TypeSeasonId,
                        principalTable: "TypeSeason",
                        principalColumn: "TypeSeasonId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Climate_PlantId",
                table: "Climate",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPlant_FamilyId",
                table: "FamilyPlant",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPlant_PlantId",
                table: "FamilyPlant",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_FloweringSeasonPlant_PlantId",
                table: "FloweringSeasonPlant",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_FloweringSeasonPlant_TypeSeasonId",
                table: "FloweringSeasonPlant",
                column: "TypeSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Origin_CountryId",
                table: "Origin",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Origin_PlantId",
                table: "Origin",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PlantId",
                table: "Photo",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_SourcePlant_PlantId",
                table: "SourcePlant",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_SourcePlant_SourceId",
                table: "SourcePlant",
                column: "SourceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Climate");

            migrationBuilder.DropTable(
                name: "FamilyPlant");

            migrationBuilder.DropTable(
                name: "FloweringSeasonPlant");

            migrationBuilder.DropTable(
                name: "Origin");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "SourcePlant");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "TypeSeason");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Plant");

            migrationBuilder.DropTable(
                name: "Source");
        }
    }
}
