using Microsoft.EntityFrameworkCore.Migrations;

namespace moment3._2.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Record_RentedRecordsId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RentedRecordsId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RentedRecordsId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "RentedRecords",
                table: "User",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentedRecords",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "RentedRecordsId",
                table: "User",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RentedRecordsId",
                table: "User",
                column: "RentedRecordsId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Record_RentedRecordsId",
                table: "User",
                column: "RentedRecordsId",
                principalTable: "Record",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
