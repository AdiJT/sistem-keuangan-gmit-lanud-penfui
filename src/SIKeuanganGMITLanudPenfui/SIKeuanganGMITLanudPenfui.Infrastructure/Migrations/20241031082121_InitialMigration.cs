using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblJenisAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Jenis = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblJenisAkun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblRAPBJ",
                columns: table => new
                {
                    Tahun = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRAPBJ", x => x.Tahun);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblKelompokAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    JenisAkunId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKelompokAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblKelompokAkun_TblJenisAkun_JenisAkunId",
                        column: x => x.JenisAkunId,
                        principalTable: "TblJenisAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblGolonganAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    KelompokAkunId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGolonganAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblGolonganAkun_TblKelompokAkun_KelompokAkunId",
                        column: x => x.KelompokAkunId,
                        principalTable: "TblKelompokAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    PresentaseSetoran = table.Column<double>(type: "double precision", nullable: true),
                    JenisAkunId = table.Column<int>(type: "integer", nullable: false),
                    KelompokAkunId = table.Column<int>(type: "integer", nullable: true),
                    GolonganAkunId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblAkun_TblGolonganAkun_GolonganAkunId",
                        column: x => x.GolonganAkunId,
                        principalTable: "TblGolonganAkun",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblAkun_TblJenisAkun_JenisAkunId",
                        column: x => x.JenisAkunId,
                        principalTable: "TblJenisAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblAkun_TblKelompokAkun_KelompokAkunId",
                        column: x => x.KelompokAkunId,
                        principalTable: "TblKelompokAkun",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblBelanja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tanggal = table.Column<DateOnly>(type: "date", nullable: false),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<double>(type: "double precision", nullable: false),
                    SaldoKas = table.Column<double>(type: "double precision", nullable: false),
                    AkunId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBelanja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblBelanja_TblAkun_AkunId",
                        column: x => x.AkunId,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblDetailRAPBJ",
                columns: table => new
                {
                    TahunRAPBJ = table.Column<int>(type: "integer", nullable: false),
                    KodeAkun = table.Column<int>(type: "integer", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Satuan = table.Column<string>(type: "text", nullable: false),
                    HargaSatuan = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDetailRAPBJ", x => new { x.TahunRAPBJ, x.KodeAkun });
                    table.ForeignKey(
                        name: "FK_TblDetailRAPBJ_TblAkun_KodeAkun",
                        column: x => x.KodeAkun,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblDetailRAPBJ_TblRAPBJ_TahunRAPBJ",
                        column: x => x.TahunRAPBJ,
                        principalTable: "TblRAPBJ",
                        principalColumn: "Tahun",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPenerimaan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tanggal = table.Column<DateOnly>(type: "date", nullable: false),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<double>(type: "double precision", nullable: false),
                    SaldoKas = table.Column<double>(type: "double precision", nullable: false),
                    AkunId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPenerimaan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPenerimaan_TblAkun_AkunId",
                        column: x => x.AkunId,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblAkun_GolonganAkunId",
                table: "TblAkun",
                column: "GolonganAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblAkun_JenisAkunId",
                table: "TblAkun",
                column: "JenisAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblAkun_KelompokAkunId",
                table: "TblAkun",
                column: "KelompokAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBelanja_AkunId",
                table: "TblBelanja",
                column: "AkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblDetailRAPBJ_KodeAkun",
                table: "TblDetailRAPBJ",
                column: "KodeAkun");

            migrationBuilder.CreateIndex(
                name: "IX_TblGolonganAkun_KelompokAkunId",
                table: "TblGolonganAkun",
                column: "KelompokAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblKelompokAkun_JenisAkunId",
                table: "TblKelompokAkun",
                column: "JenisAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPenerimaan_AkunId",
                table: "TblPenerimaan",
                column: "AkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblUser_UserName",
                table: "TblUser",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblBelanja");

            migrationBuilder.DropTable(
                name: "TblDetailRAPBJ");

            migrationBuilder.DropTable(
                name: "TblPenerimaan");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblRAPBJ");

            migrationBuilder.DropTable(
                name: "TblAkun");

            migrationBuilder.DropTable(
                name: "TblGolonganAkun");

            migrationBuilder.DropTable(
                name: "TblKelompokAkun");

            migrationBuilder.DropTable(
                name: "TblJenisAkun");
        }
    }
}
