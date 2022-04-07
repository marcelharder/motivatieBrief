using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class per : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    lastname = table.Column<string>(type: "TEXT", nullable: true),
                    lastname_partner = table.Column<string>(type: "TEXT", nullable: true),
                    first_names = table.Column<string>(type: "TEXT", nullable: true),
                    first_names_partner = table.Column<string>(type: "TEXT", nullable: true),
                    place_birth = table.Column<string>(type: "TEXT", nullable: true),
                    place_birth_partner = table.Column<string>(type: "TEXT", nullable: true),
                    dob = table.Column<DateTime>(type: "TEXT", nullable: false),
                    db_pertner = table.Column<DateTime>(type: "TEXT", nullable: false),
                    street = table.Column<string>(type: "TEXT", nullable: true),
                    street_partner = table.Column<string>(type: "TEXT", nullable: true),
                    pobox = table.Column<string>(type: "TEXT", nullable: true),
                    pobox_partner = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    city_partner = table.Column<string>(type: "TEXT", nullable: true),
                    phone_home = table.Column<string>(type: "TEXT", nullable: true),
                    phone_home_partner = table.Column<string>(type: "TEXT", nullable: true),
                    mob = table.Column<string>(type: "TEXT", nullable: true),
                    mob_partner = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    email_partner = table.Column<string>(type: "TEXT", nullable: true),
                    bstaat = table.Column<string>(type: "TEXT", nullable: true),
                    bstaat_partner = table.Column<string>(type: "TEXT", nullable: true),
                    hgoederen = table.Column<string>(type: "TEXT", nullable: true),
                    hgoederen_partner = table.Column<string>(type: "TEXT", nullable: true),
                    reg_partnership = table.Column<string>(type: "TEXT", nullable: true),
                    living_together = table.Column<string>(type: "TEXT", nullable: true),
                    legitimatie_soort = table.Column<string>(type: "TEXT", nullable: true),
                    legitimatie_soort_partner = table.Column<string>(type: "TEXT", nullable: true),
                    legitimatie_no = table.Column<string>(type: "TEXT", nullable: true),
                    legitimatie_no_partner = table.Column<string>(type: "TEXT", nullable: true),
                    notaris = table.Column<string>(type: "TEXT", nullable: true),
                    notaris_adres = table.Column<string>(type: "TEXT", nullable: true),
                    bedrag_roerende_zaken = table.Column<string>(type: "TEXT", nullable: true),
                    partner_medekoper = table.Column<string>(type: "TEXT", nullable: true),
                    line_35 = table.Column<string>(type: "TEXT", nullable: true),
                    line_36 = table.Column<string>(type: "TEXT", nullable: true),
                    line_37 = table.Column<string>(type: "TEXT", nullable: true),
                    line_38 = table.Column<string>(type: "TEXT", nullable: true),
                    line_39 = table.Column<string>(type: "TEXT", nullable: true),
                    line_40 = table.Column<string>(type: "TEXT", nullable: true),
                    line_41 = table.Column<string>(type: "TEXT", nullable: true),
                    line_42 = table.Column<string>(type: "TEXT", nullable: true),
                    line_43 = table.Column<string>(type: "TEXT", nullable: true),
                    line_44 = table.Column<string>(type: "TEXT", nullable: true),
                    line_45 = table.Column<string>(type: "TEXT", nullable: true),
                    line_46 = table.Column<string>(type: "TEXT", nullable: true),
                    line_47 = table.Column<string>(type: "TEXT", nullable: true),
                    line_48 = table.Column<string>(type: "TEXT", nullable: true),
                    line_49 = table.Column<string>(type: "TEXT", nullable: true),
                    line_50 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersId);
                    table.ForeignKey(
                        name: "FK_Personas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UserId",
                table: "Personas",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
