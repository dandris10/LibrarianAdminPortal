using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarianAdminPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddLendedBookEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LendedBooks_BookId",
                table: "LendedBooks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_LendedBooks_Books_BookId",
                table: "LendedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LendedBooks_Books_BookId",
                table: "LendedBooks");

            migrationBuilder.DropIndex(
                name: "IX_LendedBooks_BookId",
                table: "LendedBooks");
        }
    }
}
