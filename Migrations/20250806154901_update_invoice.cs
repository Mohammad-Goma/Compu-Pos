using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Compu_Pos.Migrations
{
    /// <inheritdoc />
    public partial class update_invoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "InvoiceItem",
                newName: "Price_3");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "InvoiceItem",
                newName: "Parcode");

            migrationBuilder.AddColumn<string>(
                name: "Emp_Name",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InvoiceItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deleveries_CompanyId",
                table: "Deleveries",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deleveries_Companies_CompanyId",
                table: "Deleveries",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deleveries_Companies_CompanyId",
                table: "Deleveries");

            migrationBuilder.DropIndex(
                name: "IX_Deleveries_CompanyId",
                table: "Deleveries");

            migrationBuilder.DropColumn(
                name: "Emp_Name",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InvoiceItem");

            migrationBuilder.RenameColumn(
                name: "Price_3",
                table: "InvoiceItem",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Parcode",
                table: "InvoiceItem",
                newName: "Description");
        }
    }
}
