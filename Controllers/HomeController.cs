using SklepMVC.DAL;
using SklepMVC.Models;
using SklepMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMVC.Controllers
{  //komentarz

    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext();
        public ActionResult Index() //klikajac na Index mozna dodac widok
        {    //te kategorie dodane sa w Kursyinitializer   
             //Kategoria kategoria = new Kategoria { NazwaKategorii = "asp.net mvc", NazwaPlikuIkony = "aspNetMvc.png", OpisKategorii = "opis kat" };
             //db.Kategorie.Add(kategoria);
             //db.SaveChanges();

            // var listaKategorii = db.Kategorie.ToList();  // testy z migracji

            var kategorie = db.Kategorie.ToList();
            var nowosci = db.Kursy.Where(a=> !a.Ukryty).OrderByDescending(a=>a.DataDodania).Take(3).ToList();  //nie moga byc to kursy ukryte, tylko 3,
            var bestseller = db.Kursy.Where(a => !a.Ukryty && a.Bestseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();

            //instacjonowanie Viewmodel
            var vm = new HomeViewModel()
            {
                Kategorie = kategorie,
                Nowosci = nowosci,
                Bestsellery = bestseller
            };
                
            return View(vm);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }

    }
}