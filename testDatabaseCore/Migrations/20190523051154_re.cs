using Microsoft.EntityFrameworkCore.Migrations;

namespace testDatabaseCore.Migrations
{
    public partial class re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_CompanyType_CompanyTypeId",
                schema: "Cor",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyTypeId",
                schema: "Cor",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Company_CompanyType_CompanyTypeId",
                schema: "Cor",
                table: "Company",
                column: "CompanyTypeId",
                principalSchema: "Cor",
                principalTable: "CompanyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_CompanyType_CompanyTypeId",
                schema: "Cor",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyTypeId",
                schema: "Cor",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_CompanyType_CompanyTypeId",
                schema: "Cor",
                table: "Company",
                column: "CompanyTypeId",
                principalSchema: "Cor",
                principalTable: "CompanyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
