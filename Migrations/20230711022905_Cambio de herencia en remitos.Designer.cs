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
    [Migration("20230711022905_Cambio de herencia en remitos")]
    partial class Cambiodeherenciaenremitos
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

            modelBuilder.Entity("back_bitadora.Models.Remitos", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

                    b.Property<int?>("numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("recivedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("retira")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Remitos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Remitos");
                });

            modelBuilder.Entity("back_bitadora.Models.Registro", b =>
                {
                    b.HasBaseType("back_bitadora.Models.Remitos");

                    b.Property<bool>("active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("completedAt")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Registro");
                });
#pragma warning restore 612, 618
        }
    }
}
