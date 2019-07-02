using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class reservationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adress = table.Column<string>(nullable: true),
                    DateBooked = table.Column<DateTime>(nullable: false),
                    TypeOfreperation = table.Column<DateTime>(nullable: false),
                    TypeOfreperationDescription = table.Column<DateTime>(nullable: false),
                    ReparationDateTimeStart = table.Column<DateTime>(nullable: false),
                    ReparationDateTimeEnd = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    ReperationType = table.Column<string>(nullable: true),
                    ReperationTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
