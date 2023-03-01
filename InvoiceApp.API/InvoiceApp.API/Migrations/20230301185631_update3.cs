using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApp.API.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesLines_InvoicesHeaders_InvoiceHeaderId",
                table: "InvoicesLines");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceHeaderId",
                table: "InvoicesLines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesLines_InvoicesHeaders_InvoiceHeaderId",
                table: "InvoicesLines",
                column: "InvoiceHeaderId",
                principalTable: "InvoicesHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesLines_InvoicesHeaders_InvoiceHeaderId",
                table: "InvoicesLines");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceHeaderId",
                table: "InvoicesLines",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesLines_InvoicesHeaders_InvoiceHeaderId",
                table: "InvoicesLines",
                column: "InvoiceHeaderId",
                principalTable: "InvoicesHeaders",
                principalColumn: "Id");
        }
    }
}
