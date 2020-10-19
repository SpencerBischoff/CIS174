using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174_TestCoreApp.Migrations
{
    public partial class InitialStudentsCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    StudentId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Student_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "Grade", "LastName", "StudentId1" },
                values: new object[,]
                {
                    { 1, "Spencer", 86, "Bischoff", null },
                    { 2, "Rebecca", 93, "Lynn", null },
                    { 3, "James", 72, "Rivers", null },
                    { 4, "Kelly", 89, "Ann", null },
                    { 5, "Jimmy", 81, "Lackers", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentId1",
                table: "Student",
                column: "StudentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
