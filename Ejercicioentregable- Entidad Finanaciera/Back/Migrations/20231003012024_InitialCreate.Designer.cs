﻿// <auto-generated />
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231003012024_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Back.Cuenta_Bancaria", b =>
                {
                    b.Property<int>("idCuentaBancaria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCuentaBancaria"));

                    b.Property<int>("numeroCuenta")
                        .HasColumnType("int");

                    b.Property<double>("saldo")
                        .HasColumnType("float");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("titularidCliente")
                        .HasColumnType("int");

                    b.HasKey("idCuentaBancaria");

                    b.HasIndex("titularidCliente");

                    b.ToTable("CuentasBancarias");
                });

            modelBuilder.Entity("Back.Tarjeta_de_Crédito", b =>
                {
                    b.Property<int>("idTarjetaCredito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTarjetaCredito"));

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("limiteCredito")
                        .HasColumnType("float");

                    b.Property<double>("montoDeuda")
                        .HasColumnType("float");

                    b.Property<int>("numerotarjeta")
                        .HasColumnType("int");

                    b.HasKey("idTarjetaCredito");

                    b.ToTable("TarjetasDeCredito");
                });

            modelBuilder.Entity("Back.Cuenta_Bancaria", b =>
                {
                    b.HasOne("Back.Cliente", "titular")
                        .WithMany()
                        .HasForeignKey("titularidCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("titular");
                });
#pragma warning restore 612, 618
        }
    }
}
