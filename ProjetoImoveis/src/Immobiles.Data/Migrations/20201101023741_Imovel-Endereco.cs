using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Immobiles.Data.Migrations
{
    public partial class ImovelEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(nullable: false),
                    Cep = table.Column<string>(type: "varchar(9)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(200)", nullable: true),
                    StreetAddress = table.Column<string>(type: "varchar(100)", nullable: true),
                    City = table.Column<string>(type: "varchar(50)", nullable: true),
                    State = table.Column<string>(type: "varchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Immobiles",
                columns: table => new
                {
                    ImmobileId = table.Column<Guid>(nullable: false),
                    EType = table.Column<int>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immobiles", x => x.ImmobileId);
                    table.ForeignKey(
                        name: "FK_Immobiles_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Immobiles_AddressId",
                table: "Immobiles",
                column: "AddressId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immobiles");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
