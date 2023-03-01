using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApp.API.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceHeaderId",
                table: "InvoicesLines",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceLineId",
                table: "InvoicesLines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLines_InvoiceHeaderId",
                table: "InvoicesLines",
                column: "InvoiceHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesLines_InvoicesHeaders_InvoiceHeaderId",
                table: "InvoicesLines",
                column: "InvoiceHeaderId",
                principalTable: "InvoicesHeaders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesLines_InvoicesHeaders_InvoiceHeaderId",
                table: "InvoicesLines");

            migrationBuilder.DropIndex(
                name: "IX_InvoicesLines_InvoiceHeaderId",
                table: "InvoicesLines");

            migrationBuilder.DropColumn(
                name: "InvoiceHeaderId",
                table: "InvoicesLines");

            migrationBuilder.DropColumn(
                name: "InvoiceLineId",
                table: "InvoicesLines");
        }
    }
}
