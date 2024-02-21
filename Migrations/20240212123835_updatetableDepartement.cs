using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suq_com.Migrations
{
    /// <inheritdoc />
    public partial class updatetableDepartement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetials",
                table: "orderDetials");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "members",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "depoImage",
                table: "departements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SingInModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    copyidsignin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingInModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SingInModel");

            migrationBuilder.DropColumn(
                name: "depoImage",
                table: "departements");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "members",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetials",
                table: "orderDetials",
                column: "orderdetialsID");
        }
    }
}
