using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class briefadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Briefs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    line_1 = table.Column<string>(type: "TEXT", nullable: true),
                    line_2 = table.Column<string>(type: "TEXT", nullable: true),
                    line_3 = table.Column<string>(type: "TEXT", nullable: true),
                    line_4 = table.Column<string>(type: "TEXT", nullable: true),
                    line_5 = table.Column<string>(type: "TEXT", nullable: true),
                    line_6 = table.Column<string>(type: "TEXT", nullable: true),
                    line_7 = table.Column<string>(type: "TEXT", nullable: true),
                    line_8 = table.Column<string>(type: "TEXT", nullable: true),
                    line_9 = table.Column<string>(type: "TEXT", nullable: true),
                    line_10 = table.Column<string>(type: "TEXT", nullable: true),
                    line_11 = table.Column<string>(type: "TEXT", nullable: true),
                    line_12 = table.Column<string>(type: "TEXT", nullable: true),
                    line_13 = table.Column<string>(type: "TEXT", nullable: true),
                    line_14 = table.Column<string>(type: "TEXT", nullable: true),
                    line_15 = table.Column<string>(type: "TEXT", nullable: true),
                    line_16 = table.Column<string>(type: "TEXT", nullable: true),
                    line_17 = table.Column<string>(type: "TEXT", nullable: true),
                    line_18 = table.Column<string>(type: "TEXT", nullable: true),
                    line_19 = table.Column<string>(type: "TEXT", nullable: true),
                    line_20 = table.Column<string>(type: "TEXT", nullable: true),
                    line_21 = table.Column<string>(type: "TEXT", nullable: true),
                    line_22 = table.Column<string>(type: "TEXT", nullable: true),
                    line_23 = table.Column<string>(type: "TEXT", nullable: true),
                    line_24 = table.Column<string>(type: "TEXT", nullable: true),
                    line_25 = table.Column<string>(type: "TEXT", nullable: true),
                    line_26 = table.Column<string>(type: "TEXT", nullable: true),
                    line_27 = table.Column<string>(type: "TEXT", nullable: true),
                    line_28 = table.Column<string>(type: "TEXT", nullable: true),
                    line_29 = table.Column<string>(type: "TEXT", nullable: true),
                    line_30 = table.Column<string>(type: "TEXT", nullable: true),
                    line_31 = table.Column<string>(type: "TEXT", nullable: true),
                    line_32 = table.Column<string>(type: "TEXT", nullable: true),
                    line_33 = table.Column<string>(type: "TEXT", nullable: true),
                    line_34 = table.Column<string>(type: "TEXT", nullable: true),
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
                    table.PrimaryKey("PK_Briefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Briefs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Briefs_UserId",
                table: "Briefs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Briefs");
        }
    }
}
