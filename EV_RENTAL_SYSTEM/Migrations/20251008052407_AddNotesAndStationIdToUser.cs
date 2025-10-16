using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EV_RENTAL_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class AddNotesAndStationIdToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vehicle_type",
                table: "Vehicle");

            migrationBuilder.AddColumn<string>(
                name: "Phone_number",
                table: "User",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "User",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Station_Id",
                table: "User",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Station_Id",
                table: "User",
                column: "Station_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Station_Station_Id",
                table: "User",
                column: "Station_Id",
                principalTable: "Station",
                principalColumn: "Station_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Station_Station_Id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Station_Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Phone_number",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Station_Id",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Vehicle_type",
                table: "Vehicle",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
