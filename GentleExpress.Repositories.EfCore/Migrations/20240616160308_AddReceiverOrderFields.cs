using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GentleExpress.Repositories.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddReceiverOrderFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeliveryCode = table.Column<int>(type: "integer", nullable: false),
                    ParcelDescription = table.Column<string>(type: "text", nullable: false),
                    DesiredPickUpDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ChargeDeliveryFee = table.Column<bool>(type: "boolean", nullable: false),
                    ChargeParcelPrice = table.Column<bool>(type: "boolean", nullable: false),
                    ParcelPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    VendorNotes = table.Column<string>(type: "text", nullable: true),
                    VendorAddressId = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReceiverFillDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReceiverName = table.Column<string>(type: "text", nullable: false),
                    ReceiverDistrictId = table.Column<int>(type: "integer", nullable: false),
                    ReceiverAddress = table.Column<string>(type: "text", nullable: false),
                    ReceiverPhoneNumber = table.Column<string>(type: "text", nullable: false),
                    ReceiverNotes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Districts_ReceiverDistrictId",
                        column: x => x.ReceiverDistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_VendorAddresses_VendorAddressId",
                        column: x => x.VendorAddressId,
                        principalTable: "VendorAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_ReceiverDistrictId",
                table: "Deliveries",
                column: "ReceiverDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_VendorAddressId",
                table: "Deliveries",
                column: "VendorAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");
        }
    }
}
