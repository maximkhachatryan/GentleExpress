using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GentleExpress.Repositories.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class RefactorVendorEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddresses_Clients_ClientId",
                table: "ClientAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientUsers_Clients_ClientId",
                table: "ClientUsers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientUsers",
                newName: "VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientUsers_ClientId",
                table: "ClientUsers",
                newName: "IX_ClientUsers_VendorId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientAddresses",
                newName: "VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientAddresses_ClientId",
                table: "ClientAddresses",
                newName: "IX_ClientAddresses_VendorId");

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "ClientAddresses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BrandName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    VendorWalletAmount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddresses_Vendors_VendorId",
                table: "ClientAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientUsers_Vendors_VendorId",
                table: "ClientUsers");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "ClientAddresses");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "ClientUsers",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientUsers_VendorId",
                table: "ClientUsers",
                newName: "IX_ClientUsers_ClientId");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "ClientAddresses",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientAddresses_VendorId",
                table: "ClientAddresses",
                newName: "IX_ClientAddresses_ClientId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BrandName = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAddresses_Clients_ClientId",
                table: "ClientAddresses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientUsers_Clients_ClientId",
                table: "ClientUsers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
