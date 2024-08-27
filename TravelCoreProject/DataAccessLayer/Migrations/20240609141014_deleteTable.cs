using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class deleteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureMains");

            migrationBuilder.DropTable(
                name: "featureSubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureMains",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureDescriptin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturePrice = table.Column<int>(type: "int", nullable: false),
                    FeatureStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureMains", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "featureSubs",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureDescriptin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_featureSubs", x => x.FeatureId);
                });
        }
    }
}
