using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace T1708ENewsWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    RollNumber = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.RollNumber);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectName = table.Column<string>(nullable: true),
                    SubjectMark = table.Column<int>(nullable: false),
                    StudentRollNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Marks_Student_StudentRollNumber",
                        column: x => x.StudentRollNumber,
                        principalTable: "Student",
                        principalColumn: "RollNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreateAt", "Email", "FirstName", "LastName", "Status", "UpdateAt" },
                values: new object[] { "D00597", new DateTime(2018, 11, 6, 19, 40, 54, 231, DateTimeKind.Local), "Vienlvd00597@fpt.edu.vn", "Vien", "Le", 1, new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreateAt", "Email", "FirstName", "LastName", "Status", "UpdateAt" },
                values: new object[] { "D00598", new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local), "TuanLc00598@fpt.edu.vn", "Luu Cung", "Tuan", 1, new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreateAt", "Email", "FirstName", "LastName", "Status", "UpdateAt" },
                values: new object[] { "D0600", new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local), "HaiddD600@fpt.edu.vn", "Dai", "Hai", 1, new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[,]
                {
                    { 1, "D00597", 30, "Java" },
                    { 2, "D00597", 20, "C#" },
                    { 3, "D00597", 40, "HTML" },
                    { 4, "D00598", 45, "Java" },
                    { 5, "D00598", 28, "C#" },
                    { 6, "D00598", 30, "HTML" },
                    { 7, "D0600", 30, "Java" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_StudentRollNumber",
                table: "Marks",
                column: "StudentRollNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
