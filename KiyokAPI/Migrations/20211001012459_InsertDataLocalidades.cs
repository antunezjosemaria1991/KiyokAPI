using Microsoft.EntityFrameworkCore.Migrations;

namespace KiyokAPI.Migrations
{
    public partial class InsertDataLocalidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Localidad",
            columns: new[] { "LocalidadId", "Nombre", "ProvinciaId" },
            values: new object[] { "1", "Leales", "1" });

            migrationBuilder.InsertData(
            table: "Localidad",
            columns: new[] { "LocalidadId", "Nombre", "ProvinciaId" },
            values: new object[] { "2", "Monteros", "1" });

            migrationBuilder.InsertData(
            table: "Localidad",
            columns: new[] { "LocalidadId", "Nombre", "ProvinciaId" },
            values: new object[] { "3", "Concepcion", "1" }); 

            migrationBuilder.InsertData(
            table: "Localidad",
            columns: new[] { "LocalidadId", "Nombre", "ProvinciaId" },
            values: new object[] { "4", "Aguilares", "1" });

            migrationBuilder.InsertData(
            table: "Localidad",
            columns: new[] { "LocalidadId", "Nombre", "ProvinciaId" },
            values: new object[] { "5", "Simoca", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
