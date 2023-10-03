using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "TarjetasDeCredito",
                columns: table => new
                {
                    idTarjetaCredito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numerotarjeta = table.Column<int>(type: "int", nullable: false),
                    limiteCredito = table.Column<double>(type: "float", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    montoDeuda = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetasDeCredito", x => x.idTarjetaCredito);
                });

            migrationBuilder.CreateTable(
                name: "CuentasBancarias",
                columns: table => new
                {
                    idCuentaBancaria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroCuenta = table.Column<int>(type: "int", nullable: false),
                    saldo = table.Column<double>(type: "float", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titularidCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasBancarias", x => x.idCuentaBancaria);
                    table.ForeignKey(
                        name: "FK_CuentasBancarias_Clientes_titularidCliente",
                        column: x => x.titularidCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuentasBancarias_titularidCliente",
                table: "CuentasBancarias",
                column: "titularidCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentasBancarias");

            migrationBuilder.DropTable(
                name: "TarjetasDeCredito");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
