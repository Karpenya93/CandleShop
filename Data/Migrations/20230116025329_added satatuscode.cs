using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCandleShopNet7.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedsatatuscode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "StatusOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "StatusOrders");
        }
    }
}
