using Microsoft.EntityFrameworkCore.Migrations;

namespace Complete_Web_API.Migrations
{
    public partial class InitialCreat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "UserInfos");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "UserInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserInfos");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
