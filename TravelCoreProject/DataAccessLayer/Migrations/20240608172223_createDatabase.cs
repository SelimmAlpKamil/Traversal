using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutPartners",
                columns: table => new
                {
                    AboutPartnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutPartnerTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPartnerTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPartnerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPartnerImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutPartners", x => x.AboutPartnerId);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "AboutSubs",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSubs", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationDayAndNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationStatus = table.Column<bool>(type: "bit", nullable: false),
                    DestinationPrice = table.Column<double>(type: "float", nullable: false),
                    DestinationCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.CreateTable(
                name: "FeatureMains",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescriptin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescriptin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_featureSubs", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    GuideID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuideName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideDescripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideInstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideXURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.GuideID);
                });

            migrationBuilder.CreateTable(
                name: "NewLetters",
                columns: table => new
                {
                    NewLetterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewLetterMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewLetters", x => x.NewLetterId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutPartners");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AboutSubs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "FeatureMains");

            migrationBuilder.DropTable(
                name: "featureSubs");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "NewLetters");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
