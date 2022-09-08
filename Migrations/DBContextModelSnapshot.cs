﻿// <auto-generated />
using System;
using ControlIDMvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControlIDMvc.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControlIDMvc.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Creado_por")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Dia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("HorarioId");

                    b.ToTable("Dia");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Creado_porId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Creado_porId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.ImagenDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("ImagenDocumento");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.ImagenPerfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("ImagenPerfil");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<string>("Ci")
                        .HasColumnType("longtext");

                    b.Property<string>("Contraseña")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlId")
                        .HasColumnType("longtext");

                    b.Property<string>("Dirrecion")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha_nac")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Observaciones")
                        .HasColumnType("longtext");

                    b.Property<string>("Sincronizacion")
                        .HasColumnType("longtext");

                    b.Property<string>("Usuario")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Dirrecion")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha_fin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fecha_inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ControlId")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Sincronizacion")
                        .HasColumnType("longtext");

                    b.Property<int>("area")
                        .HasColumnType("int");

                    b.Property<int>("codigo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Tarjeta");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<string>("Ci")
                        .HasColumnType("longtext");

                    b.Property<string>("ContraseñaTarjeta")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha_nac")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("NumTarjeta")
                        .HasColumnType("longtext");

                    b.Property<int?>("creado_porId")
                        .HasColumnType("int");

                    b.Property<int?>("departamento_idId")
                        .HasColumnType("int");

                    b.Property<string>("dirrecion")
                        .HasColumnType("longtext");

                    b.Property<int?>("grupo_idId")
                        .HasColumnType("int");

                    b.Property<string>("nota")
                        .HasColumnType("longtext");

                    b.Property<int?>("proyecto_idId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("creado_porId");

                    b.HasIndex("departamento_idId");

                    b.HasIndex("grupo_idId");

                    b.HasIndex("proyecto_idId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Dia", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Horario", "Horario")
                        .WithMany("Dias")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horario");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Grupo", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Persona", "Creado_por")
                        .WithMany()
                        .HasForeignKey("Creado_porId");

                    b.HasOne("ControlIDMvc.Entities.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId");

                    b.Navigation("Creado_por");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.ImagenDocumento", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Persona", "Persona")
                        .WithMany("documentos")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.ImagenPerfil", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Persona", "Persona")
                        .WithMany("perfiles")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Tarjeta", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Persona", "Persona")
                        .WithMany("card")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Usuario", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Usuario", "creado_por")
                        .WithMany()
                        .HasForeignKey("creado_porId");

                    b.HasOne("ControlIDMvc.Entities.Departamento", "departamento_id")
                        .WithMany()
                        .HasForeignKey("departamento_idId");

                    b.HasOne("ControlIDMvc.Entities.Grupo", "grupo_id")
                        .WithMany()
                        .HasForeignKey("grupo_idId");

                    b.HasOne("ControlIDMvc.Entities.Proyecto", "proyecto_id")
                        .WithMany()
                        .HasForeignKey("proyecto_idId");

                    b.Navigation("creado_por");

                    b.Navigation("departamento_id");

                    b.Navigation("grupo_id");

                    b.Navigation("proyecto_id");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Horario", b =>
                {
                    b.Navigation("Dias");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Persona", b =>
                {
                    b.Navigation("card");

                    b.Navigation("documentos");

                    b.Navigation("perfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
