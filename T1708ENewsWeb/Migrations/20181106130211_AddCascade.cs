using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace T1708ENewsWeb.Migrations
{
    public partial class AddCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Student_StudentRollNumber",
                table: "Marks");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00597",
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2018, 11, 6, 20, 2, 11, 55, DateTimeKind.Local), new DateTime(2018, 11, 6, 20, 2, 11, 56, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00598",
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2018, 11, 6, 20, 2, 11, 56, DateTimeKind.Local), new DateTime(2018, 11, 6, 20, 2, 11, 56, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D0600",
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2018, 11, 6, 20, 2, 11, 56, DateTimeKind.Local), new DateTime(2018, 11, 6, 20, 2, 11, 56, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Student_StudentRollNumber",
                table: "Marks",
                column: "StudentRollNumber",
                principalTable: "Student",
                principalColumn: "RollNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Student_StudentRollNumber",
                table: "Marks");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00597",
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 40, 54, 231, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00598",
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D0600",
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Student_StudentRollNumber",
                table: "Marks",
                column: "StudentRollNumber",
                principalTable: "Student",
                principalColumn: "RollNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
