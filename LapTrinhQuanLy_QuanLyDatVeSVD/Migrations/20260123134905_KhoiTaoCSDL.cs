using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietVe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonVeID = table.Column<int>(type: "int", nullable: false),
                    GheNgoiID = table.Column<int>(type: "int", nullable: false),
                    LoaiVeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietVe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GheNgoi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoGhe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhuVucID = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GheNgoi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonVe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHangID = table.Column<int>(type: "int", nullable: false),
                    SuKienID = table.Column<int>(type: "int", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonVe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhuVuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanVanDongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuVuc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiVe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiVe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaVe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiVe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SanVanDong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanVanDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucChua = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanVanDong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SuKien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSuKien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayToChuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SanVanDongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuKien", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietVe");

            migrationBuilder.DropTable(
                name: "GheNgoi");

            migrationBuilder.DropTable(
                name: "HoaDonVe");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KhuVuc");

            migrationBuilder.DropTable(
                name: "LoaiVe");

            migrationBuilder.DropTable(
                name: "SanVanDong");

            migrationBuilder.DropTable(
                name: "SuKien");
        }
    }
}
