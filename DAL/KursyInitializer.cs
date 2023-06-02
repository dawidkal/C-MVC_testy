using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SklepMVC.Models;

namespace SklepMVC.DAL
{                                 //MigrationDatabaseTolastVersion wtedy bez metody Seed
    public class KursyInitializer: DropCreateDatabaseIfModelChanges<KursyContext>  //- baza kasowana i tworzona zawsze od nowa.DropCreateDatabaseAlways, DropCreateDatabaseIfModelChanges -gdy sa zminy
    { //wypelnienie tabel danymi
        protected override void Seed(KursyContext context)// ;rzeciazenie metody seed-wypelnia baze wartosciami poczatkowymi.
        {//musi byc wywolana  w KursyKontext
            SeedKursyData(context);
            base.Seed(context);
        }

        private void SeedKursyData(KursyContext context)
        { //przykladowe dane
            var kategorie = new List<Kategoria>
            {
                new Kategoria () {KategoriaId=1,NazwaKategorii="asp",NazwaPlikuIkony="asp.png",OpisKategorii="opis asp net mvc"},
                   new Kategoria () {KategoriaId=2,NazwaKategorii="java",NazwaPlikuIkony="java.png",OpisKategorii="opis java"},
                      new Kategoria () {KategoriaId=3,NazwaKategorii="html",NazwaPlikuIkony="html.png",OpisKategorii="opis html"},
                         new Kategoria () {KategoriaId=4,NazwaKategorii="php",NazwaPlikuIkony="php.png",OpisKategorii="opis php"},
                            new Kategoria () {KategoriaId=5,NazwaKategorii="c#",NazwaPlikuIkony="c#.png",OpisKategorii="opis C#"},
                              new Kategoria () {KategoriaId=6,NazwaKategorii="mvc",NazwaPlikuIkony="c#.png",OpisKategorii="opis mvc"}
            };

            kategorie.ForEach(k => context.Kategorie.Add(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs() { KursId=1, AutorKursu="Mariusz", TytulKursu="Asp.Net", KategoriaId=1, CenaKursu=0, Bestseller=true, NazwaPlikuObrazka="obrazekaspnet.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs ASP.NET - doskonała platforma do tworzenia dynamicznych aplikacji internetowych. Kurs jest przeznaczony dla wszystkich osób, które chcą nauczyć się od podstaw tworzenia stron internetowych wykorzystując technologię ASP-NET."},
                new Kurs() { KursId=2, AutorKursu="Mariusz", TytulKursu="Asp.Net Mvc", KategoriaId=1, CenaKursu=0, Bestseller=true, NazwaPlikuObrazka="obrazekmvc.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs ASP.NET MVC - przeznaczony jest dla wszystkich osób, które chcą nauczyć się od podstaw tworzenia stron internetowych wykorzystując technologię ASP-NET MVC."},
                new Kurs() { KursId=3, AutorKursu="Mariusz", TytulKursu="Asp.Net Mvc - Sklep Internetowy", KategoriaId=1, CenaKursu=100, Bestseller=true, NazwaPlikuObrazka="obrazekmvc2.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs Asp.Net Mvc - Sklep Internetowy - to praktyczne rozwiązanie wykorzystujące technologię Asp.Net Mvc pokazujące krok po kroku budowanie serwisu internetowego sprzedającego kursy on-line"},

                new Kurs() { KursId=4, AutorKursu="Mariusz", TytulKursu="JavaScript", KategoriaId=2, CenaKursu=70, Bestseller=false, NazwaPlikuObrazka="obrazekjavascript.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs JavaScript - skryptowy język programowania"},
                new Kurs() { KursId=5, AutorKursu="Mariusz", TytulKursu="jQuery", KategoriaId=3, CenaKursu=90, Bestseller=true, NazwaPlikuObrazka="obrazekjquery.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs jQuery - lekka biblioteka programistyczna dla języka JavaScript"},
                new Kurs() { KursId=6, AutorKursu="Mariusz", TytulKursu="Html5", KategoriaId=4, CenaKursu=70, Bestseller=false, NazwaPlikuObrazka="obrazekhtml.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs Html5 - język wykorzystywany do tworzenia i prezentowania stron internetowych www"},

                new Kurs() { KursId=7, AutorKursu="Mariusz", TytulKursu="Css3", KategoriaId=5, CenaKursu=70, Bestseller=false, NazwaPlikuObrazka="obrazekcss.png",
                DataDodania = DateTime.Now, OpisKursu="Kurs Css3 - język służący do opisu formy prezentacji (wyświetlania) stron www"}

            };
            kursy.ForEach(k => context.Kursy.Add(k));
            context.SaveChanges();

            // migracja - musi byc zainstalowany entity framework, narzedzia-menager nuget-consola-komenda -enable-Migrations wybrany odpowiedni projekt z listy i zrodlo nuget

        }
    }
}