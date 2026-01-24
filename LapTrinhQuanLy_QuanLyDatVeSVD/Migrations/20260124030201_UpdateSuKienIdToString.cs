using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSuKienIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SanVanDongID",
                table: "SuKien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SanVanDongID",
                table: "SuKien",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
