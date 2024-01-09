using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIAgencia.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(55)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(55)", nullable: false),
                    Email = table.Column<string>(type: "varchar(55)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(55)", nullable: false),
                    City = table.Column<string>(type: "varchar(55)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
