using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cookbook.WebAPI.Database

{
    public partial class CookbookContext : DbContext
    {
        public CookbookContext()
        {

        }
        public CookbookContext(DbContextOptions<CookbookContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=Cookbook;Trusted_Connection=True;");
                
            }

        }

        public virtual DbSet<VrstaClanka> VrstaClanka { get; set; }
        public virtual DbSet<Clanak> Clanak { get; set; }
        public virtual DbSet<GrupaJela>GrupaJela{get;set;}
        public virtual DbSet<Kategorija>Kategorija{get;set;}
        public virtual DbSet<Komentar>Komentar{get;set;}
        public virtual DbSet<Korisnik>Korisnik{get;set;}
        public virtual DbSet<KorisnikUloga>KorisnikUloga{get;set;}
        public virtual DbSet<Uloga>Uloga{get;set;}
        public virtual DbSet<MjernaJedinica>MjernaJedinica{get;set;}
        public virtual DbSet<MjernaKolicina>MjernaKolicina{get;set;}
        public virtual DbSet<Notifikacija>Notifikacija{get;set;}
        public virtual DbSet<Ocjena>Ocjena{get;set;}
        public virtual DbSet<Posjetilac>Posjetilac{get;set;}
        public virtual DbSet<Recept>Recept{get;set;}
        public virtual DbSet<ReceptSastojak>ReceptSastojak{get;set;}
        public virtual DbSet<Sastojak>Sastojak{get;set;}
        public virtual DbSet<Slozenost>Slozenost{get;set;}
       public virtual DbSet<Favoriti> Favoriti { get; set; }
        public virtual DbSet<Dokument> Dokumenti { get; set; }

    }
}
