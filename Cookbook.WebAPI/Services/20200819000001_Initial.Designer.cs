﻿// <auto-generated />
using System;
using Cookbook.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cookbook.WebAPI.Migrations
{
    [DbContext(typeof(CookbookContext))]
    [Migration("20200819000001_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cookbook.WebAPI.Database.Clanak", b =>
                {
                    b.Property<int>("ClanakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VrstaClankaId")
                        .HasColumnType("int");

                    b.HasKey("ClanakId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("VrstaClankaId");

                    b.ToTable("Clanak");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Dokument", b =>
                {
                    b.Property<int>("DokumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivDokumenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Sadrzaj")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("DokumentId");

                    b.ToTable("Dokumenti");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Favoriti", b =>
                {
                    b.Property<int>("FavoritiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.HasKey("FavoritiId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Favoriti");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.GrupaJela", b =>
                {
                    b.Property<int>("GrupaJelaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrupaJelaId");

                    b.ToTable("GrupaJela");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Komentar", b =>
                {
                    b.Property<int>("KomentarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<bool>("Odobreno")
                        .HasColumnType("bit");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KomentarId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisnikUloga");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.MjernaJedinica", b =>
                {
                    b.Property<int>("MjernaJedinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MjernaJedinicaId");

                    b.ToTable("MjernaJedinica");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.MjernaKolicina", b =>
                {
                    b.Property<int>("MjernaKolicinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Kolicina")
                        .HasColumnType("float");

                    b.HasKey("MjernaKolicinaId");

                    b.ToTable("MjernaKolicina");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Notifikacija", b =>
                {
                    b.Property<int>("NotifikacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumSlanja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsProcitano")
                        .HasColumnType("bit");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotifikacijaId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Notifikacija");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Ocjena", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PosjetilacId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.Property<double>("ocjena")
                        .HasColumnType("float");

                    b.HasKey("OcjenaId");

                    b.HasIndex("PosjetilacId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Posjetilac", b =>
                {
                    b.Property<int>("PosjetilacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("PosjetilacId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Posjetilac");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Recept", b =>
                {
                    b.Property<int>("ReceptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojLjudi")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<int>("GrupaJelaId")
                        .HasColumnType("int");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Odobren")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("SlozenostId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("VrijemeKuhanja")
                        .HasColumnType("float");

                    b.Property<double>("VrijemePripreme")
                        .HasColumnType("float");

                    b.HasKey("ReceptId");

                    b.HasIndex("GrupaJelaId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("SlozenostId");

                    b.ToTable("Recept");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.ReceptSastojak", b =>
                {
                    b.Property<int>("ReceptSastojakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MjernaJedinicaId")
                        .HasColumnType("int");

                    b.Property<int>("MjernaKolicinaId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.Property<int>("SastojakId")
                        .HasColumnType("int");

                    b.HasKey("ReceptSastojakId");

                    b.HasIndex("MjernaJedinicaId");

                    b.HasIndex("MjernaKolicinaId");

                    b.HasIndex("ReceptId");

                    b.HasIndex("SastojakId");

                    b.ToTable("ReceptSastojak");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Sastojak", b =>
                {
                    b.Property<int>("SastojakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SastojakId");

                    b.ToTable("Sastojak");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Slozenost", b =>
                {
                    b.Property<int>("SlozenostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SlozenostId");

                    b.ToTable("Slozenost");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.VrstaClanka", b =>
                {
                    b.Property<int>("VrstaClankaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrstaClankaId");

                    b.ToTable("VrstaClanka");
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Clanak", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("Clanak")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.VrstaClanka", "VrstaClanka")
                        .WithMany("Clanak")
                        .HasForeignKey("VrstaClankaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Favoriti", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("Favoriti")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Recept", "Recept")
                        .WithMany("Favoriti")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Komentar", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("Komentar")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Recept", "Recept")
                        .WithMany("Komentar")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.KorisnikUloga", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUloga")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Uloga", "Uloga")
                        .WithMany("KorisnikUloga")
                        .HasForeignKey("UlogaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Notifikacija", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Recept", "Recept")
                        .WithMany("Notifikacija")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Ocjena", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Posjetilac", "Posjetilac")
                        .WithMany("Ocjena")
                        .HasForeignKey("PosjetilacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Recept", "Recept")
                        .WithMany("Ocjena")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Posjetilac", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("Posjetilac")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.Recept", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.GrupaJela", "GrupaJela")
                        .WithMany("Recept")
                        .HasForeignKey("GrupaJelaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Kategorija", "Kategorija")
                        .WithMany("Recept")
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("Recept")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Slozenost", "Slozenost")
                        .WithMany("Recept")
                        .HasForeignKey("SlozenostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.WebAPI.Database.ReceptSastojak", b =>
                {
                    b.HasOne("Cookbook.WebAPI.Database.MjernaJedinica", "MjernaJedinica")
                        .WithMany("ReceptSastojak")
                        .HasForeignKey("MjernaJedinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.MjernaKolicina", "MjernaKolicina")
                        .WithMany("ReceptSastojak")
                        .HasForeignKey("MjernaKolicinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Recept", "Recept")
                        .WithMany("ReceptSastojak")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.WebAPI.Database.Sastojak", "Sastojak")
                        .WithMany("ReceptSastojak")
                        .HasForeignKey("SastojakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
