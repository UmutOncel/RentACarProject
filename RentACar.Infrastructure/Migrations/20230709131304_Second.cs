using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Infrastructure.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarParks_CarParkFloors_CarParkFloorID",
                table: "CarParks");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarParks_CarParkID",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarParkID",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CarParkID",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarParkFloorID",
                table: "CarParks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "CarCustomers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "CarCustomers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarParkID",
                table: "Cars",
                column: "CarParkID",
                unique: true,
                filter: "[CarParkID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CarParks_CarParkFloors_CarParkFloorID",
                table: "CarParks",
                column: "CarParkFloorID",
                principalTable: "CarParkFloors",
                principalColumn: "CarParkFloorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarParks_CarParkID",
                table: "Cars",
                column: "CarParkID",
                principalTable: "CarParks",
                principalColumn: "CarParkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarParks_CarParkFloors_CarParkFloorID",
                table: "CarParks");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarParks_CarParkID",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarParkID",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CarParkID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarParkFloorID",
                table: "CarParks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "CarCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "CarCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarParkID",
                table: "Cars",
                column: "CarParkID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarParks_CarParkFloors_CarParkFloorID",
                table: "CarParks",
                column: "CarParkFloorID",
                principalTable: "CarParkFloors",
                principalColumn: "CarParkFloorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarParks_CarParkID",
                table: "Cars",
                column: "CarParkID",
                principalTable: "CarParks",
                principalColumn: "CarParkID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
