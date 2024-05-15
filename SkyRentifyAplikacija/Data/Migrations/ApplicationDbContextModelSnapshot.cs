﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkyRentifyAplikacija.Data;

#nullable disable

namespace SkyRentifyAplikacija.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Klijent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("brojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nivoVjestine")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("visina")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Klijent", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Oprema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("cijena")
                        .HasColumnType("float");

                    b.Property<string>("marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("materijal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Oprema");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.StavkaZahtjeva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OpremaId")
                        .HasColumnType("int");

                    b.Property<int>("ZahtjevId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OpremaId");

                    b.HasIndex("ZahtjevId");

                    b.ToTable("StavkaZahtjeva", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.TipZahtjeva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("cijena")
                        .HasColumnType("float");

                    b.Property<int>("naziv")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TipZahtjeva", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.TipoviZahtjeva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TipZahtjevaId")
                        .HasColumnType("int");

                    b.Property<int>("ZahtjevId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipZahtjevaId");

                    b.HasIndex("ZahtjevId");

                    b.ToTable("TipoviZahtjeva", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Uposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("korisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uposlenik", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Vlasnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("korisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vlasnik", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Zahtjev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("cijena")
                        .HasColumnType("float");

                    b.Property<DateTime>("datumIzdavanjaUsluje")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumPodnosenjaZahtjeva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumZavrsetkaUsluge")
                        .HasColumnType("datetime2");

                    b.Property<int>("klijentId")
                        .HasColumnType("int");

                    b.Property<bool>("placeno")
                        .HasColumnType("bit");

                    b.Property<double>("popust")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("klijentId");

                    b.ToTable("Zahtjev", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Kaciga", b =>
                {
                    b.HasBaseType("SkyRentifyAplikacija.Models.Oprema");

                    b.Property<string>("velicina")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.ToTable("Kaciga", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Pancerice", b =>
                {
                    b.HasBaseType("SkyRentifyAplikacija.Models.Oprema");

                    b.Property<double>("velicina")
                        .HasColumnType("float");

                    b.ToTable("Pancerice", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Skije", b =>
                {
                    b.HasBaseType("SkyRentifyAplikacija.Models.Oprema");

                    b.Property<double>("duzina")
                        .HasColumnType("float");

                    b.Property<double>("sirina")
                        .HasColumnType("float");

                    b.ToTable("Skije", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Snowboard", b =>
                {
                    b.HasBaseType("SkyRentifyAplikacija.Models.Oprema");

                    b.Property<double>("duzina")
                        .HasColumnType("float");

                    b.ToTable("Snowboard", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.SnowboardCipele", b =>
                {
                    b.HasBaseType("SkyRentifyAplikacija.Models.Oprema");

                    b.Property<double>("velicina")
                        .HasColumnType("float");

                    b.ToTable("SnowboardCipele", (string)null);
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Stapovi", b =>
                {
                    b.HasBaseType("SkyRentifyAplikacija.Models.Oprema");

                    b.Property<double>("duzina")
                        .HasColumnType("float");

                    b.ToTable("Stapovi", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.StavkaZahtjeva", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", "oprema")
                        .WithMany()
                        .HasForeignKey("OpremaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkyRentifyAplikacija.Models.Zahtjev", "zahtjev")
                        .WithMany()
                        .HasForeignKey("ZahtjevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oprema");

                    b.Navigation("zahtjev");
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.TipoviZahtjeva", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.TipZahtjeva", "tipZahtjeva")
                        .WithMany()
                        .HasForeignKey("TipZahtjevaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkyRentifyAplikacija.Models.Zahtjev", "zahtjev")
                        .WithMany()
                        .HasForeignKey("ZahtjevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipZahtjeva");

                    b.Navigation("zahtjev");
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Zahtjev", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Klijent", "klijent")
                        .WithMany()
                        .HasForeignKey("klijentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("klijent");
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Kaciga", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", null)
                        .WithOne()
                        .HasForeignKey("SkyRentifyAplikacija.Models.Kaciga", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Pancerice", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", null)
                        .WithOne()
                        .HasForeignKey("SkyRentifyAplikacija.Models.Pancerice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Skije", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", null)
                        .WithOne()
                        .HasForeignKey("SkyRentifyAplikacija.Models.Skije", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Snowboard", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", null)
                        .WithOne()
                        .HasForeignKey("SkyRentifyAplikacija.Models.Snowboard", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.SnowboardCipele", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", null)
                        .WithOne()
                        .HasForeignKey("SkyRentifyAplikacija.Models.SnowboardCipele", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkyRentifyAplikacija.Models.Stapovi", b =>
                {
                    b.HasOne("SkyRentifyAplikacija.Models.Oprema", null)
                        .WithOne()
                        .HasForeignKey("SkyRentifyAplikacija.Models.Stapovi", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
