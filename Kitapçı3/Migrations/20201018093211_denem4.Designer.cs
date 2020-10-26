﻿// <auto-generated />
using Kitapçı3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kitapçı3.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201018093211_denem4")]
    partial class denem4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kitapçı3.Models.Bilim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Hakkında")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitapad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tarih")
                        .HasColumnType("int");

                    b.Property<string>("Yayınevi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("bilims");
                });

            modelBuilder.Entity("Kitapçı3.Models.Felsefe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Hakkında")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitapad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tarih")
                        .HasColumnType("int");

                    b.Property<string>("Yayınevi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("felseves");
                });

            modelBuilder.Entity("Kitapçı3.Models.Kitap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Hakkında")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitapad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tarih")
                        .HasColumnType("int");

                    b.Property<string>("Yayınevi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("kitaps");
                });

            modelBuilder.Entity("Kitapçı3.Models.Psikoloji", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Hakkında")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitapad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tarih")
                        .HasColumnType("int");

                    b.Property<string>("Yayınevi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("psikolojis");
                });

            modelBuilder.Entity("Kitapçı3.Models.Roman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Hakkında")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitapad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tarih")
                        .HasColumnType("int");

                    b.Property<string>("Yayınevi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("romen");
                });
#pragma warning restore 612, 618
        }
    }
}
