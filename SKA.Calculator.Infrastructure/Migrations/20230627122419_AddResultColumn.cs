using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SKA.Calculator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddResultColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Result",
                schema: "Calculator",
                table: "HistoryCalculations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                schema: "Calculator",
                table: "HistoryCalculations");
        }
    }
}
