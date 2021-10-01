using Microsoft.EntityFrameworkCore.Migrations;

namespace KiyokAPI.Migrations
{
    public partial class InsertDataPaises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Pais",
            columns: new[] { "PaisId", "Nombre" },
            values: new object[] { "1", "Argentina" });

            migrationBuilder.InsertData(
            table: "Pais",
            columns: new[] { "PaisId", "Nombre" },
            values: new object[] { "2", "Peru" });

            migrationBuilder.InsertData(
            table: "Pais",
            columns: new[] { "PaisId", "Nombre" },
            values: new object[] { "3", "Brasil" });

            migrationBuilder.InsertData(
            table: "Pais",
            columns: new[] { "PaisId", "Nombre" },
            values: new object[] { "4", "Uruguay" });

            migrationBuilder.InsertData(
            table: "Pais",
            columns: new[] { "PaisId", "Nombre" },
            values: new object[] { "5", "Paraguay" });

            migrationBuilder.InsertData(
            table: "Pais",
            columns: new[] { "PaisId", "Nombre" },
            values: new object[] { "6", "Chile" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
