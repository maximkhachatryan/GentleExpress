using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentleExpress.Repositories.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddDeliveryDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AcceptDate",
                table: "Deliveries",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CargoReceivalDate",
                table: "Deliveries",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpAssignmentDate",
                table: "Deliveries",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PickUpCourierId",
                table: "Deliveries",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RejectDate",
                table: "Deliveries",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_PickUpCourierId",
                table: "Deliveries",
                column: "PickUpCourierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Couriers_PickUpCourierId",
                table: "Deliveries",
                column: "PickUpCourierId",
                principalTable: "Couriers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Couriers_PickUpCourierId",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_PickUpCourierId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "AcceptDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CargoReceivalDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "PickUpAssignmentDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "PickUpCourierId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RejectDate",
                table: "Deliveries");
        }
    }
}
