﻿// <auto-generated />
using KiyokAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KiyokAPI.Migrations
{
    [DbContext(typeof(KiyokDBContext))]
    [Migration("20211001012016_InsertDataProvincias")]
    partial class InsertDataProvincias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KiyokAPI.Models.Localidad", b =>
                {
                    b.Property<int>("LocalidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("LocalidadId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("KiyokAPI.Models.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PaisId");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("KiyokAPI.Models.Provincia", b =>
                {
                    b.Property<int>("ProvinciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("ProvinciaId");

                    b.HasIndex("PaisId");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("KiyokAPI.Models.Localidad", b =>
                {
                    b.HasOne("KiyokAPI.Models.Provincia", "Provincia")
                        .WithMany("Localidad")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("KiyokAPI.Models.Provincia", b =>
                {
                    b.HasOne("KiyokAPI.Models.Pais", "Pais")
                        .WithMany("Provincia")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("KiyokAPI.Models.Pais", b =>
                {
                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("KiyokAPI.Models.Provincia", b =>
                {
                    b.Navigation("Localidad");
                });
#pragma warning restore 612, 618
        }
    }
}
