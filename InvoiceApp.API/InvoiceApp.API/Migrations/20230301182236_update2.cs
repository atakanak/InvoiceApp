using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApp.API.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InvoicesLines",
                newName: "LineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LineId",
                table: "InvoicesLines",
                newName: "Id");
        }
    }
}
