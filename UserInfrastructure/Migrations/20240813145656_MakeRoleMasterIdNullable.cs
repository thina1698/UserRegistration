using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MakeRoleMasterIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_RoleMaster_RoleMasterId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "RoleMasterId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_User_RoleMaster_RoleMasterId",
                table: "User",
                column: "RoleMasterId",
                principalTable: "RoleMaster",
                principalColumn: "RoleMasterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_RoleMaster_RoleMasterId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "RoleMasterId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_RoleMaster_RoleMasterId",
                table: "User",
                column: "RoleMasterId",
                principalTable: "RoleMaster",
                principalColumn: "RoleMasterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
