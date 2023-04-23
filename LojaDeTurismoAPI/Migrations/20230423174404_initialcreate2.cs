using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeTurismoAPI.Migrations
{
    public partial class initialcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceAdressId = table.Column<int>(type: "int", nullable: false),
                    DestinationAdressId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Dt_Register = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Address_DestinationAdressId",
                        column: x => x.DestinationAdressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ticket_Address_SourceAdressId",
                        column: x => x.SourceAdressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ticket_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ClientId",
                table: "Ticket",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DestinationAdressId",
                table: "Ticket",
                column: "DestinationAdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SourceAdressId",
                table: "Ticket",
                column: "SourceAdressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
