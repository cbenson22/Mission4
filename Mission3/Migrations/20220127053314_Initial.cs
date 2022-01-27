using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieName = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieName);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieName", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Ferris Bueller's Day Off", "Comedy", "John Hughes", false, null, null, "PG-13", 1986 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieName", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "The Dark Knight", "Action/Adventure", "Christopher Nolan", false, null, null, "PG-13", 2008 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieName", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Thor Ragnarok", "Action/Adventure", "Taika Waititi", false, null, null, "PG-13", 2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
