﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_bitadora.Context;

#nullable disable

namespace backEndBitacora.Migrations
{
    [DbContext(typeof(ListadoDeRemitosContext))]
    [Migration("20230705223455_Agrego la tabla de Registro y al contexto")]
    partial class AgregolatabladeRegistroyalcontexto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("back_bitadora.Models.Agencias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("EsGenero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("back_bitadora.Models.Registro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("E4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("E4T")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GPS")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MRD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tx700")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tx840")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tx860")
                        .HasColumnType("INTEGER");

                    b.Property<string>("accesorios")
                        .HasColumnType("TEXT");

                    b.Property<bool>("active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("agencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("completedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("compromisedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("detalle")
                        .HasColumnType("TEXT");

                    b.Property<string>("estado")
                        .HasColumnType("TEXT");

                    b.Property<int>("numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("recivedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("retira")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Registro");
                });

            modelBuilder.Entity("back_bitadora.Models.Remitos", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("E4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("E4T")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GPS")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MRD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tx700")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tx840")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tx860")
                        .HasColumnType("INTEGER");

                    b.Property<string>("accesorios")
                        .HasColumnType("TEXT");

                    b.Property<string>("agencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("compromisedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("detalle")
                        .HasColumnType("TEXT");

                    b.Property<string>("estado")
                        .HasColumnType("TEXT");

                    b.Property<int>("numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("recivedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("retira")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Remitos");
                });
#pragma warning restore 612, 618
        }
    }
}
