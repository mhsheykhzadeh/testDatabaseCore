using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testDatabaseCore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cor");

            migrationBuilder.CreateTable(
                name: "CompanyType",
                schema: "Cor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "Cor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyTitle = table.Column<string>(maxLength: 200, nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    EconomicalNumber = table.Column<string>(maxLength: 20, nullable: true),
                    RegistrationNumber = table.Column<string>(maxLength: 200, nullable: true),
                    CompanyTypeId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    BranchCode = table.Column<int>(nullable: true),
                    NationalNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyType_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalSchema: "Cor",
                        principalTable: "CompanyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_Company_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Cor",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompanyTypeId",
                schema: "Cor",
                table: "Company",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_ParentId",
                schema: "Cor",
                table: "Company",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company",
                schema: "Cor");

            migrationBuilder.DropTable(
                name: "CompanyType",
                schema: "Cor");
        }
    }
}
