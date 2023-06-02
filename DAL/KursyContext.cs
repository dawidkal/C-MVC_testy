using SklepMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SklepMVC.DAL //Data Access Layer
{
    public class KursyContext: DbContext
    { // dodajemy tabele DbSet, trzba dodac connection stringa w web config
        public KursyContext () :base("KursyContext") //konstruktor,przkazujemy connection stringa z Webconfig
        {

        }

        static KursyContext() //statyczny konstruktor
        { //wywolanie
            Database.SetInitializer<KursyContext>(new KursyInitializer());

        }

        public DbSet <Kurs> Kursy { get; set; } //DbSet ze bedzie to tabela
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia{ get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia{ get; set; }// dodano tabele
        
        //zmiana wylaczono konwersje ktorza tworzy liczbe mnoga z s  Kategori -Kategories
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}