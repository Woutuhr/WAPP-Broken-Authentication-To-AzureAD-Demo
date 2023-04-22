using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrokenAuthenticationMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTodosDoneProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Todo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Todo");
        }
    }
}
