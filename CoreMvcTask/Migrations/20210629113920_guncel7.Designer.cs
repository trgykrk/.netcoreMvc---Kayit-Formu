﻿// <auto-generated />
using System;
using CoreMvcTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreMvcTask.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210629113920_guncel7")]
    partial class guncel7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreMvcTask.Models.Kullanicilar", b =>
                {
                    b.Property<int>("Kullanici_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kullanici_Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yetki_Kodu")
                        .HasColumnType("int");

                    b.HasKey("Kullanici_ID");

                    b.ToTable("kullanicilars");
                });

            modelBuilder.Entity("CoreMvcTask.Models.Musteriler", b =>
                {
                    b.Property<int>("Musterı_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain_Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Domain_Sure")
                        .HasColumnType("int");

                    b.Property<string>("Firma_Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uzanti_Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Uzanti_ID")
                        .HasColumnType("int");

                    b.Property<string>("eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("iletisim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Musterı_ID");

                    b.HasIndex("Uzanti_ID");

                    b.ToTable("musterilers");
                });

            modelBuilder.Entity("CoreMvcTask.Models.Talepler", b =>
                {
                    b.Property<int>("Talep_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İletisim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Talep_ID");

                    b.ToTable("taleplers");
                });

            modelBuilder.Entity("CoreMvcTask.Models.Uzantilar", b =>
                {
                    b.Property<int>("Uzanti_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Uzanti_Adi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uzanti_ID");

                    b.ToTable("uzantilars");
                });

            modelBuilder.Entity("CoreMvcTask.Models.Musteriler", b =>
                {
                    b.HasOne("CoreMvcTask.Models.Uzantilar", "uzanti")
                        .WithMany("musterilers")
                        .HasForeignKey("Uzanti_ID");

                    b.Navigation("uzanti");
                });

            modelBuilder.Entity("CoreMvcTask.Models.Uzantilar", b =>
                {
                    b.Navigation("musterilers");
                });
#pragma warning restore 612, 618
        }
    }
}
