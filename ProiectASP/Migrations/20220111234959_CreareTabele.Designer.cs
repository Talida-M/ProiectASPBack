﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectASP.Data;

namespace ProiectASP.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220111234959_CreareTabele")]
    partial class CreareTabele
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProiectASP.Entities.Adrese", b =>
                {
                    b.Property<int>("IdAdresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdAngajat")
                        .HasColumnType("int");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Strada")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdAdresa");

                    b.HasIndex("IdAngajat")
                        .IsUnique();

                    b.ToTable("Adrese");
                });

            modelBuilder.Entity("ProiectASP.Entities.Angajati", b =>
                {
                    b.Property<int>("IdAngajat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdAdresa")
                        .HasColumnType("int");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Salariu")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdAngajat");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("ProiectASP.Entities.Categorie", b =>
                {
                    b.Property<int>("IdCategorie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("IdCategorie");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("ProiectASP.Entities.Clienti", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdClient");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("ProiectASP.Entities.Comenzi", b =>
                {
                    b.Property<int>("IdComanda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientiIdClient")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StatusTotal")
                        .HasColumnType("nvarchar(30)");

                    b.Property<float>("Valoare")
                        .HasColumnType("real");

                    b.HasKey("IdComanda");

                    b.HasIndex("ClientiIdClient");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("ProiectASP.Entities.DetaliiComanda", b =>
                {
                    b.Property<int>("IdComanda")
                        .HasColumnType("int");

                    b.Property<int>("IdProdus")
                        .HasColumnType("int");

                    b.Property<int>("IdExecutant")
                        .HasColumnType("int");

                    b.Property<int>("IdProiectant")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdComanda", "IdProdus");

                    b.HasIndex("IdProdus");

                    b.HasIndex("IdProiectant");

                    b.ToTable("DetaliiComanda");
                });

            modelBuilder.Entity("ProiectASP.Entities.Filament", b =>
                {
                    b.Property<int>("IdFilament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Gramaj")
                        .HasColumnType("real");

                    b.Property<float>("TemperaturaTopire")
                        .HasColumnType("real");

                    b.Property<string>("TipFilament")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdFilament");

                    b.ToTable("Filament");
                });

            modelBuilder.Entity("ProiectASP.Entities.Imprimante", b =>
                {
                    b.Property<int>("IdImprimanta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("DimensiunePat")
                        .HasColumnType("real");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdImprimanta");

                    b.ToTable("Imprimante");
                });

            modelBuilder.Entity("ProiectASP.Entities.ImprimanteFilament", b =>
                {
                    b.Property<int>("IdFilament")
                        .HasColumnType("int");

                    b.Property<int>("IdImprimanta")
                        .HasColumnType("int");

                    b.HasKey("IdFilament", "IdImprimanta");

                    b.HasIndex("IdImprimanta");

                    b.ToTable("ImprimanteFilament");
                });

            modelBuilder.Entity("ProiectASP.Entities.Produs", b =>
                {
                    b.Property<int>("IdProdus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CantitateFilament")
                        .HasColumnType("real");

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<float>("CostProducere")
                        .HasColumnType("real");

                    b.Property<float>("Dimensiune")
                        .HasColumnType("real");

                    b.Property<int>("FilamentId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("PretVanzare")
                        .HasColumnType("real");

                    b.HasKey("IdProdus");

                    b.HasIndex("CategorieId");

                    b.HasIndex("FilamentId");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("ProiectASP.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ProiectASP.Entities.SessionToken", b =>
                {
                    b.Property<string>("Jti")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Jti");

                    b.HasIndex("UserId");

                    b.ToTable("SessionTokens");
                });

            modelBuilder.Entity("ProiectASP.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProiectASP.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientiIdClient")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId1")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("ClientiIdClient");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ProiectASP.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ProiectASP.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ProiectASP.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ProiectASP.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProiectASP.Entities.Adrese", b =>
                {
                    b.HasOne("ProiectASP.Entities.Angajati", "Angajati")
                        .WithOne("Adrese")
                        .HasForeignKey("ProiectASP.Entities.Adrese", "IdAngajat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Angajati");
                });

            modelBuilder.Entity("ProiectASP.Entities.Comenzi", b =>
                {
                    b.HasOne("ProiectASP.Entities.Clienti", "Clienti")
                        .WithMany("Comenzi")
                        .HasForeignKey("ClientiIdClient");

                    b.Navigation("Clienti");
                });

            modelBuilder.Entity("ProiectASP.Entities.DetaliiComanda", b =>
                {
                    b.HasOne("ProiectASP.Entities.Comenzi", "Comenzi")
                        .WithMany("DetaliiComanda")
                        .HasForeignKey("IdComanda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectASP.Entities.Produs", "Produse")
                        .WithMany("DetaliiComanda")
                        .HasForeignKey("IdProdus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectASP.Entities.Angajati", "Angajati")
                        .WithMany("DetaliiComanda")
                        .HasForeignKey("IdProiectant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Angajati");

                    b.Navigation("Comenzi");

                    b.Navigation("Produse");
                });

            modelBuilder.Entity("ProiectASP.Entities.ImprimanteFilament", b =>
                {
                    b.HasOne("ProiectASP.Entities.Filament", "Filament")
                        .WithMany("ImprimanteFilamente")
                        .HasForeignKey("IdFilament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectASP.Entities.Imprimante", "Imprimante")
                        .WithMany("ImprimanteFilamente")
                        .HasForeignKey("IdImprimanta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filament");

                    b.Navigation("Imprimante");
                });

            modelBuilder.Entity("ProiectASP.Entities.Produs", b =>
                {
                    b.HasOne("ProiectASP.Entities.Categorie", "Categorii")
                        .WithMany("Produse")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectASP.Entities.Filament", "Filamente")
                        .WithMany("Produse")
                        .HasForeignKey("FilamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorii");

                    b.Navigation("Filamente");
                });

            modelBuilder.Entity("ProiectASP.Entities.SessionToken", b =>
                {
                    b.HasOne("ProiectASP.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProiectASP.Entities.UserRole", b =>
                {
                    b.HasOne("ProiectASP.Entities.Clienti", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("ClientiIdClient");

                    b.HasOne("ProiectASP.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectASP.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("ProiectASP.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectASP.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProiectASP.Entities.Angajati", b =>
                {
                    b.Navigation("Adrese");

                    b.Navigation("DetaliiComanda");
                });

            modelBuilder.Entity("ProiectASP.Entities.Categorie", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("ProiectASP.Entities.Clienti", b =>
                {
                    b.Navigation("Comenzi");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ProiectASP.Entities.Comenzi", b =>
                {
                    b.Navigation("DetaliiComanda");
                });

            modelBuilder.Entity("ProiectASP.Entities.Filament", b =>
                {
                    b.Navigation("ImprimanteFilamente");

                    b.Navigation("Produse");
                });

            modelBuilder.Entity("ProiectASP.Entities.Imprimante", b =>
                {
                    b.Navigation("ImprimanteFilamente");
                });

            modelBuilder.Entity("ProiectASP.Entities.Produs", b =>
                {
                    b.Navigation("DetaliiComanda");
                });

            modelBuilder.Entity("ProiectASP.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ProiectASP.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
