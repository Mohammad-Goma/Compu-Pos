using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Compu_Pos.Migrations
{
    /// <inheritdoc />
    public partial class updateallmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierCompany",
                table: "Deleveries");

            migrationBuilder.RenameColumn(
                name: "VehicleNumber",
                table: "Deleveries",
                newName: "PhoneNumber_3");

            migrationBuilder.RenameColumn(
                name: "LastDeliveryDate",
                table: "Deleveries",
                newName: "DeliveryDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber_3",
                table: "Deleveries",
                newName: "VehicleNumber");

            migrationBuilder.RenameColumn(
                name: "DeliveryDate",
                table: "Deleveries",
                newName: "LastDeliveryDate");

            migrationBuilder.AddColumn<string>(
                name: "SupplierCompany",
                table: "Deleveries",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
