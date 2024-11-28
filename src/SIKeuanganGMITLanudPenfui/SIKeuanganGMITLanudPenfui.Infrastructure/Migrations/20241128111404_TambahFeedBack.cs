using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahFeedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblFeedBack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Judul = table.Column<string>(type: "text", nullable: false),
                    Pesan = table.Column<string>(type: "text", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SudahDibaca = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFeedBack", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKgtVnk8vNJe4DQ1fSW9RqkggCdwod+MV0fH5Rps8zgtU6I1dOWH0EweWFh60Dp2QQ==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL0ZS3ZyTBbmlWYL3I65PJOe6EtWgfJO9sII7Rp7shHMdofZiDdPe8QrIYXqVxgHyQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblFeedBack");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPB+4/XAFbPfMM7pLQJe7k76RZlnMyfQFJPJQF6NeoGTvj2RmOyf2jeUp+/SF3gRJA==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENoCgN0hwL/91WUIO2zn0Sr375mjFsCWwGy2E6depIhGvVYWTQaVmrQHEpqqZ1u7Gw==");
        }
    }
}
