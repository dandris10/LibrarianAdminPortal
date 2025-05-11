using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarianAdminPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrentQuantityToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentQuantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentQuantity",
                table: "Books");
        }
    }
}
