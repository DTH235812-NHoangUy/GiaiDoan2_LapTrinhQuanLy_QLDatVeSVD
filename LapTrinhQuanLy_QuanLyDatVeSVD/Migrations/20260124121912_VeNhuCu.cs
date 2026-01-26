using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Migrations
{
    /// <inheritdoc />
    public partial class VeNhuCu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "SuKien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "SuKien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "SuKien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "SuKien",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
