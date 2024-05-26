using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentleExpress.Repositories.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class RenameDBSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddresses_Districts_DistrictId",
                table: "ClientAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddresses_Vendors_VendorId",
                table: "ClientAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientUsers_Vendors_VendorId",
                table: "ClientUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientUsers",
                table: "ClientUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientAddresses",
                table: "ClientAddresses");

            migrationBuilder.RenameTable(
                name: "ClientUsers",
                newName: "VendorUsers");

            migrationBuilder.RenameTable(
                name: "ClientAddresses",
                newName: "VendorAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_ClientUsers_VendorId",
                table: "VendorUsers",
                newName: "IX_VendorUsers_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientAddresses_VendorId",
                table: "VendorAddresses",
                newName: "IX_VendorAddresses_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientAddresses_DistrictId",
                table: "VendorAddresses",
                newName: "IX_VendorAddresses_DistrictId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorUsers",
                table: "VendorUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorAddresses",
                table: "VendorAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VendorAddresses_Districts_DistrictId",
                table: "VendorAddresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendorAddresses_Vendors_VendorId",
                table: "VendorAddresses",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendorUsers_Vendors_VendorId",
                table: "VendorUsers",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendorAddresses_Districts_DistrictId",
                table: "VendorAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_VendorAddresses_Vendors_VendorId",
                table: "VendorAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_VendorUsers_Vendors_VendorId",
                table: "VendorUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorUsers",
                table: "VendorUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorAddresses",
                table: "VendorAddresses");

            migrationBuilder.RenameTable(
                name: "VendorUsers",
                newName: "ClientUsers");

            migrationBuilder.RenameTable(
                name: "VendorAddresses",
                newName: "ClientAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_VendorUsers_VendorId",
                table: "ClientUsers",
                newName: "IX_ClientUsers_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_VendorAddresses_VendorId",
                table: "ClientAddresses",
                newName: "IX_ClientAddresses_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_VendorAddresses_DistrictId",
                table: "ClientAddresses",
                newName: "IX_ClientAddresses_DistrictId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientUsers",
                table: "ClientUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientAddresses",
                table: "ClientAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAddresses_Districts_DistrictId",
                table: "ClientAddresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAddresses_Vendors_VendorId",
                table: "ClientAddresses",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientUsers_Vendors_VendorId",
                table: "ClientUsers",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
