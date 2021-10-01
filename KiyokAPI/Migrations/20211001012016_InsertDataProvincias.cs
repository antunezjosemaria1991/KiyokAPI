using Microsoft.EntityFrameworkCore.Migrations;

namespace KiyokAPI.Migrations
{
    public partial class InsertDataProvincias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "1", "Tucuman", "1" });

            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "2", "Jujuy", "1" });

            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "3", "Salta", "1" });

            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "4", "Santiago del Estero", "1" });

            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "5", "Mendoza", "1" });

            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "6", "Tierra del fuego", "1" });

            migrationBuilder.InsertData(
            table: "Provincia",
            columns: new[] { "ProvinciaId", "Nombre", "PaisId" },
            values: new object[] { "7", "Cordoba", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
