﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.Akun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("GolonganAkunId")
                        .HasColumnType("integer");

                    b.Property<int>("JenisAkunId")
                        .HasColumnType("integer");

                    b.Property<int?>("KelompokAkunId")
                        .HasColumnType("integer");

                    b.Property<double?>("PresentaseSetoran")
                        .HasColumnType("double precision");

                    b.Property<string>("Uraian")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GolonganAkunId");

                    b.HasIndex("JenisAkunId");

                    b.HasIndex("KelompokAkunId");

                    b.ToTable("TblAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.Belanja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AkunId")
                        .HasColumnType("integer");

                    b.Property<double>("Jumlah")
                        .HasColumnType("double precision");

                    b.Property<double>("SaldoKas")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Tanggal")
                        .HasColumnType("date");

                    b.Property<string>("Uraian")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AkunId");

                    b.ToTable("TblBelanja");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.DetailRAPBJ", b =>
                {
                    b.Property<int>("TahunRAPBJ")
                        .HasColumnType("integer");

                    b.Property<int>("KodeAkun")
                        .HasColumnType("integer");

                    b.Property<double>("HargaSatuan")
                        .HasColumnType("double precision");

                    b.Property<string>("Satuan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Volume")
                        .HasColumnType("integer");

                    b.HasKey("TahunRAPBJ", "KodeAkun");

                    b.HasIndex("KodeAkun");

                    b.ToTable("TblDetailRAPBJ");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.GolonganAkun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KelompokAkunId")
                        .HasColumnType("integer");

                    b.Property<string>("Uraian")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KelompokAkunId");

                    b.ToTable("TblGolonganAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.JenisAkun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Jenis")
                        .HasColumnType("integer");

                    b.Property<string>("Uraian")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TblJenisAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.KelompokAkun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("JenisAkunId")
                        .HasColumnType("integer");

                    b.Property<string>("Uraian")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("JenisAkunId");

                    b.ToTable("TblKelompokAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.Penerimaan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AkunId")
                        .HasColumnType("integer");

                    b.Property<double>("Jumlah")
                        .HasColumnType("double precision");

                    b.Property<double>("SaldoKas")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Tanggal")
                        .HasColumnType("date");

                    b.Property<string>("Uraian")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AkunId");

                    b.ToTable("TblPenerimaan");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.RAPBJ", b =>
                {
                    b.Property<int>("Tahun")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Tahun"));

                    b.HasKey("Tahun");

                    b.ToTable("TblRAPBJ");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("TblUser");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.Akun", b =>
                {
                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.GolonganAkun", "GolonganAkun")
                        .WithMany("DaftarAkun")
                        .HasForeignKey("GolonganAkunId");

                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.JenisAkun", "JenisAkun")
                        .WithMany("DaftarAkun")
                        .HasForeignKey("JenisAkunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.KelompokAkun", "KelompokAkun")
                        .WithMany("DaftarAkun")
                        .HasForeignKey("KelompokAkunId");

                    b.Navigation("GolonganAkun");

                    b.Navigation("JenisAkun");

                    b.Navigation("KelompokAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.Belanja", b =>
                {
                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.Akun", "Akun")
                        .WithMany()
                        .HasForeignKey("AkunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Akun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.DetailRAPBJ", b =>
                {
                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.Akun", "Akun")
                        .WithMany()
                        .HasForeignKey("KodeAkun")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.RAPBJ", "RAPBJ")
                        .WithMany("DaftarDetailRAPBJ")
                        .HasForeignKey("TahunRAPBJ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Akun");

                    b.Navigation("RAPBJ");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.GolonganAkun", b =>
                {
                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.KelompokAkun", "KelompokAkun")
                        .WithMany("DaftarGolonganAkun")
                        .HasForeignKey("KelompokAkunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KelompokAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.KelompokAkun", b =>
                {
                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.JenisAkun", "JenisAkun")
                        .WithMany("DaftarKelompokAkun")
                        .HasForeignKey("JenisAkunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.Penerimaan", b =>
                {
                    b.HasOne("SIKeuanganGMITLanudPenfui.Domain.Entities.Akun", "Akun")
                        .WithMany()
                        .HasForeignKey("AkunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Akun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.GolonganAkun", b =>
                {
                    b.Navigation("DaftarAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.JenisAkun", b =>
                {
                    b.Navigation("DaftarAkun");

                    b.Navigation("DaftarKelompokAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.KelompokAkun", b =>
                {
                    b.Navigation("DaftarAkun");

                    b.Navigation("DaftarGolonganAkun");
                });

            modelBuilder.Entity("SIKeuanganGMITLanudPenfui.Domain.Entities.RAPBJ", b =>
                {
                    b.Navigation("DaftarDetailRAPBJ");
                });
#pragma warning restore 612, 618
        }
    }
}
