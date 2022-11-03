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

            modelBuilder.Entity("ControlIDMvc.Entities.Accion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<string>("ControlIdAction")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdParametrers")
                        .HasColumnType("longtext");

                    b.Property<int>("ControlIdRunAt")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Accion");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.AccionPortal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccionId")
                        .HasColumnType("int");

                    b.Property<int>("ControlActionId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdPortalId")
                        .HasColumnType("int");

                    b.Property<int>("portalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccionId");

                    b.HasIndex("portalId");

                    b.ToTable("AccionPortal");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.AreaReglaAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdAreaId")
                        .HasColumnType("int");

                    b.Property<int>("ControlidReglaAccesoId")
                        .HasColumnType("int");

                    b.Property<int>("ReglaAccesoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("ReglaAccesoId");

                    b.ToTable("AreaReglaAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Caja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Concepto")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumeroRecibo")
                        .HasColumnType("longtext");

                    b.Property<string>("Persona")
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(20,2)");

                    b.HasKey("Id");

                    b.ToTable("Caja");
                });

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

                    b.Property<int>("ControlEnd")
                        .HasColumnType("int");

                    b.Property<int>("ControlFri")
                        .HasColumnType("int");

                    b.Property<int>("ControlHol1")
                        .HasColumnType("int");

                    b.Property<int>("ControlHol2")
                        .HasColumnType("int");

                    b.Property<int>("ControlHol3")
                        .HasColumnType("int");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<int>("ControlMon")
                        .HasColumnType("int");

                    b.Property<int>("ControlSat")
                        .HasColumnType("int");

                    b.Property<int>("ControlStart")
                        .HasColumnType("int");

                    b.Property<int>("ControlSun")
                        .HasColumnType("int");

                    b.Property<int>("ControlThu")
                        .HasColumnType("int");

                    b.Property<int>("ControlTimeZoneId")
                        .HasColumnType("int");

                    b.Property<int>("ControlTue")
                        .HasColumnType("int");

                    b.Property<int>("ControlWed")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Fri")
                        .HasColumnType("int");

                    b.Property<int>("Hol1")
                        .HasColumnType("int");

                    b.Property<int>("Hol2")
                        .HasColumnType("int");

                    b.Property<int>("Hol3")
                        .HasColumnType("int");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.Property<int>("Mon")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("Sat")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Sun")
                        .HasColumnType("int");

                    b.Property<int>("Thu")
                        .HasColumnType("int");

                    b.Property<int>("Tue")
                        .HasColumnType("int");

                    b.Property<int>("Wed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HorarioId");

                    b.ToTable("Dia");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Dispositivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("ControlId")
                        .HasColumnType("bigint");

                    b.Property<string>("ControlIdIp")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdPublicKey")
                        .HasColumnType("longtext");

                    b.Property<string>("Ip")
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroSerie")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("Puerto")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Dispositivo");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Egreso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Concepto")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(20,2)");

                    b.Property<string>("NumeroRecibo")
                        .HasColumnType("longtext");

                    b.Property<string>("Persona")
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Egreso");
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

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.HorarioReglaAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlIdAccessRulesId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdTimeZoneId")
                        .HasColumnType("int");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.Property<int>("ReglasAccesoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HorarioId");

                    b.HasIndex("ReglasAccesoId");

                    b.ToTable("HorarioReglaAcceso");
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

            modelBuilder.Entity("ControlIDMvc.Entities.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(20,2)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumeroRecibo")
                        .HasColumnType("longtext");

                    b.Property<int>("PaqueteId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaqueteId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Inscripcion");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Modulo");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Paquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(20,2)");

                    b.Property<int>("Dias")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Paquete");
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

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<long>("ControlIdBegin_time")
                        .HasColumnType("bigint");

                    b.Property<long>("ControlIdEnd_time")
                        .HasColumnType("bigint");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdPassword")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdRegistration")
                        .HasColumnType("longtext");

                    b.Property<string>("ControlIdSalt")
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

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.PersonaReglasAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlIdAccessRulesId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdUserId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("ReglaAccesoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.HasIndex("ReglaAccesoId");

                    b.ToTable("PersonaReglasAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Portal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AreaFromId")
                        .HasColumnType("int");

                    b.Property<int>("AreaToId")
                        .HasColumnType("int");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdAreaFromId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdAreaToId")
                        .HasColumnType("int");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Portal");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.PortalReglaAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlIdPortalId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdRulesId")
                        .HasColumnType("int");

                    b.Property<int>("PortalId")
                        .HasColumnType("int");

                    b.Property<int>("ReglaAccesoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PortalId");

                    b.HasIndex("ReglaAccesoId");

                    b.ToTable("PortalReglaAcceso");
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

            modelBuilder.Entity("ControlIDMvc.Entities.ReglaAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<string>("ControlIdName")
                        .HasColumnType("longtext");

                    b.Property<int>("ControlIdPriority")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdType")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ReglaAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.RolModulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ModuloId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.HasIndex("RolId");

                    b.ToTable("RolModulo");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.RolUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RolUsuario");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<int>("ControlIdUserId")
                        .HasColumnType("int");

                    b.Property<long>("ControlIdValue")
                        .HasColumnType("bigint");

                    b.Property<string>("ControlIdsecret")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

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

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.AccionPortal", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Accion", "Puerta")
                        .WithMany("PortalAccion")
                        .HasForeignKey("AccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.Portal", "Area")
                        .WithMany("AccionePortal")
                        .HasForeignKey("portalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Puerta");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.AreaReglaAcceso", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Area", "Area")
                        .WithMany("AreaReglaAcceso")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.ReglaAcceso", "ReglaAcceso")
                        .WithMany("AreaSReglaAccesos")
                        .HasForeignKey("ReglaAccesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("ReglaAcceso");
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

            modelBuilder.Entity("ControlIDMvc.Entities.Egreso", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Usuario", "Usuario")
                        .WithMany("Egresos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
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

            modelBuilder.Entity("ControlIDMvc.Entities.HorarioReglaAcceso", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Horario", "Horario")
                        .WithMany("HorarioReglaAccesos")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.ReglaAcceso", "ReglasAcceso")
                        .WithMany()
                        .HasForeignKey("ReglasAccesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horario");

                    b.Navigation("ReglasAcceso");
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

            modelBuilder.Entity("ControlIDMvc.Entities.Inscripcion", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Paquete", "Paquete")
                        .WithMany("Inscripciones")
                        .HasForeignKey("PaqueteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.Persona", "Persona")
                        .WithMany("Inscripciones")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paquete");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.PersonaReglasAcceso", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.ReglaAcceso", "ReglaAcceso")
                        .WithMany()
                        .HasForeignKey("ReglaAccesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("ReglaAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.PortalReglaAcceso", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Portal", "Portal")
                        .WithMany("PortalReglaAcceso")
                        .HasForeignKey("PortalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.ReglaAcceso", "ReglaAcceso")
                        .WithMany("PortalReglaAccesos")
                        .HasForeignKey("ReglaAccesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portal");

                    b.Navigation("ReglaAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.RolModulo", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Modulo", "Modulo")
                        .WithMany("rolModulo")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.Rol", "Rol")
                        .WithMany("RolModulo")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.RolUsuario", b =>
                {
                    b.HasOne("ControlIDMvc.Entities.Rol", "Rol")
                        .WithMany("RolUsuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlIDMvc.Entities.Usuario", "Usuario")
                        .WithMany("RolUsuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
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
                    b.HasOne("ControlIDMvc.Entities.Persona", "Persona")
                        .WithOne("Usuario")
                        .HasForeignKey("ControlIDMvc.Entities.Usuario", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Accion", b =>
                {
                    b.Navigation("PortalAccion");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Area", b =>
                {
                    b.Navigation("AreaReglaAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Horario", b =>
                {
                    b.Navigation("Dias");

                    b.Navigation("HorarioReglaAccesos");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Modulo", b =>
                {
                    b.Navigation("rolModulo");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Paquete", b =>
                {
                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Persona", b =>
                {
                    b.Navigation("Inscripciones");

                    b.Navigation("Usuario");

                    b.Navigation("card");

                    b.Navigation("documentos");

                    b.Navigation("perfiles");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Portal", b =>
                {
                    b.Navigation("AccionePortal");

                    b.Navigation("PortalReglaAcceso");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.ReglaAcceso", b =>
                {
                    b.Navigation("AreaSReglaAccesos");

                    b.Navigation("PortalReglaAccesos");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Rol", b =>
                {
                    b.Navigation("RolModulo");

                    b.Navigation("RolUsuarios");
                });

            modelBuilder.Entity("ControlIDMvc.Entities.Usuario", b =>
                {
                    b.Navigation("Egresos");

                    b.Navigation("RolUsuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
