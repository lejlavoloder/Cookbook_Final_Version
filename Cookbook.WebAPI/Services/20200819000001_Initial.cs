using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dokumenti",
                columns: table => new
                {
                    DokumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivDokumenta = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<byte[]>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumenti", x => x.DokumentId);
                });

            migrationBuilder.CreateTable(
                name: "GrupaJela",
                columns: table => new
                {
                    GrupaJelaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupaJela", x => x.GrupaJelaId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "MjernaJedinica",
                columns: table => new
                {
                    MjernaJedinicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MjernaJedinica", x => x.MjernaJedinicaId);
                });

            migrationBuilder.CreateTable(
                name: "MjernaKolicina",
                columns: table => new
                {
                    MjernaKolicinaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MjernaKolicina", x => x.MjernaKolicinaId);
                });

            migrationBuilder.CreateTable(
                name: "Sastojak",
                columns: table => new
                {
                    SastojakId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sastojak", x => x.SastojakId);
                });

            migrationBuilder.CreateTable(
                name: "Slozenost",
                columns: table => new
                {
                    SlozenostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slozenost", x => x.SlozenostId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaClanka",
                columns: table => new
                {
                    VrstaClankaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaClanka", x => x.VrstaClankaId);
                });

            migrationBuilder.CreateTable(
                name: "Posjetilac",
                columns: table => new
                {
                    PosjetilacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posjetilac", x => x.PosjetilacId);
                    table.ForeignKey(
                        name: "FK_Posjetilac_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recept",
                columns: table => new
                {
                    ReceptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    VrijemePripreme = table.Column<double>(nullable: false),
                    VrijemeKuhanja = table.Column<double>(nullable: false),
                    BrojLjudi = table.Column<int>(nullable: false),
                    Tekst = table.Column<string>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false),
                    GrupaJelaId = table.Column<int>(nullable: false),
                    SlozenostId = table.Column<int>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    Odobren = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recept", x => x.ReceptId);
                    table.ForeignKey(
                        name: "FK_Recept_GrupaJela_GrupaJelaId",
                        column: x => x.GrupaJelaId,
                        principalTable: "GrupaJela",
                        principalColumn: "GrupaJelaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recept_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recept_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recept_Slozenost_SlozenostId",
                        column: x => x.SlozenostId,
                        principalTable: "Slozenost",
                        principalColumn: "SlozenostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloga",
                columns: table => new
                {
                    KorisnikUlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzmjene = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloga", x => x.KorisnikUlogaId);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_Uloga_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clanak",
                columns: table => new
                {
                    ClanakId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Tekst = table.Column<string>(nullable: true),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    VrstaClankaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanak", x => x.ClanakId);
                    table.ForeignKey(
                        name: "FK_Clanak_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clanak_VrstaClanka_VrstaClankaId",
                        column: x => x.VrstaClankaId,
                        principalTable: "VrstaClanka",
                        principalColumn: "VrstaClankaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favoriti",
                columns: table => new
                {
                    FavoritiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: false),
                    ReceptId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoriti", x => x.FavoritiId);
                    table.ForeignKey(
                        name: "FK_Favoriti_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favoriti_Recept_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recept",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    KomentarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    Odobreno = table.Column<bool>(nullable: false),
                    ReceptId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.KomentarId);
                    table.ForeignKey(
                        name: "FK_Komentar_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komentar_Recept_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recept",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    NotifikacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptId = table.Column<int>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: true),
                    DatumSlanja = table.Column<DateTime>(nullable: false),
                    IsProcitano = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.NotifikacijaId);
                    table.ForeignKey(
                        name: "FK_Notifikacija_Recept_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recept",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocjena = table.Column<double>(nullable: false),
                    ReceptId = table.Column<int>(nullable: false),
                    PosjetilacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjena_Posjetilac_PosjetilacId",
                        column: x => x.PosjetilacId,
                        principalTable: "Posjetilac",
                        principalColumn: "PosjetilacId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjena_Recept_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recept",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReceptSastojak",
                columns: table => new
                {
                    ReceptSastojakId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptId = table.Column<int>(nullable: false),
                    SastojakId = table.Column<int>(nullable: false),
                    MjernaJedinicaId = table.Column<int>(nullable: false),
                    MjernaKolicinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptSastojak", x => x.ReceptSastojakId);
                    table.ForeignKey(
                        name: "FK_ReceptSastojak_MjernaJedinica_MjernaJedinicaId",
                        column: x => x.MjernaJedinicaId,
                        principalTable: "MjernaJedinica",
                        principalColumn: "MjernaJedinicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptSastojak_MjernaKolicina_MjernaKolicinaId",
                        column: x => x.MjernaKolicinaId,
                        principalTable: "MjernaKolicina",
                        principalColumn: "MjernaKolicinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptSastojak_Recept_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recept",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptSastojak_Sastojak_SastojakId",
                        column: x => x.SastojakId,
                        principalTable: "Sastojak",
                        principalColumn: "SastojakId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clanak_KorisnikId",
                table: "Clanak",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanak_VrstaClankaId",
                table: "Clanak",
                column: "VrstaClankaId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoriti_KorisnikId",
                table: "Favoriti",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoriti_ReceptId",
                table: "Favoriti",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_KorisnikId",
                table: "Komentar",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_ReceptId",
                table: "Komentar",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_ReceptId",
                table: "Notifikacija",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_PosjetilacId",
                table: "Ocjena",
                column: "PosjetilacId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_ReceptId",
                table: "Ocjena",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_Posjetilac_KorisnikId",
                table: "Posjetilac",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recept_GrupaJelaId",
                table: "Recept",
                column: "GrupaJelaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recept_KategorijaId",
                table: "Recept",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recept_KorisnikId",
                table: "Recept",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recept_SlozenostId",
                table: "Recept",
                column: "SlozenostId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptSastojak_MjernaJedinicaId",
                table: "ReceptSastojak",
                column: "MjernaJedinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptSastojak_MjernaKolicinaId",
                table: "ReceptSastojak",
                column: "MjernaKolicinaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptSastojak_ReceptId",
                table: "ReceptSastojak",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptSastojak_SastojakId",
                table: "ReceptSastojak",
                column: "SastojakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clanak");

            migrationBuilder.DropTable(
                name: "Dokumenti");

            migrationBuilder.DropTable(
                name: "Favoriti");

            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "KorisnikUloga");

            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "ReceptSastojak");

            migrationBuilder.DropTable(
                name: "VrstaClanka");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Posjetilac");

            migrationBuilder.DropTable(
                name: "MjernaJedinica");

            migrationBuilder.DropTable(
                name: "MjernaKolicina");

            migrationBuilder.DropTable(
                name: "Recept");

            migrationBuilder.DropTable(
                name: "Sastojak");

            migrationBuilder.DropTable(
                name: "GrupaJela");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Slozenost");
        }
    }
}
