using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaNet8_BlazorServer_AndresCueva.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpleadosDTO",
                columns: table => new
                {
                    nDimemp = table.Column<string>(nullable: false),

                    nomEmp = table.Column<string>(nullable: false),
                    sexEmp = table.Column<string>(nullable: false),
                    FecNac = table.Column<DateTime>(nullable: false),
                    salEmp = table.Column<float>(nullable: false),
                    comisionE = table.Column<float>(nullable: false),
                    cargoE = table.Column<string>(nullable: false),
                    jefeID = table.Column<string>(nullable: false),
                    codDepto = table.Column<string>(nullable: false),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadosDTO", x => x.nDimemp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpleadosDTO");
        }
    }
}
