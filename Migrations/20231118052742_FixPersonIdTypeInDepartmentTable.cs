using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elshaday_test_api.Migrations
{
    public partial class FixPersonIdTypeInDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_People_PersonId1",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_PersonId1",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_PersonId",
                table: "Departments",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_People_PersonId",
                table: "Departments",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_People_PersonId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_PersonId",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_PersonId1",
                table: "Departments",
                column: "PersonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_People_PersonId1",
                table: "Departments",
                column: "PersonId1",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
