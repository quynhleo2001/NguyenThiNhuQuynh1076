﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiKiemTra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230623012703_NTNQStudent")]
    partial class NTNQStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BaiKiemTra.Models.NTNQStudent", b =>
                {
                    b.Property<string>("NTNQStudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("NTNQAdress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NTNQStudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NTNQStudentID");

                    b.ToTable("NTNQStudent");
                });
#pragma warning restore 612, 618
        }
    }
}
