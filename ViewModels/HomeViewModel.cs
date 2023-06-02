using SklepMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepMVC.ViewModels
{
    public class HomeViewModel
    { // 3 listy na stone glowna
        public IEnumerable <Kategoria> Kategorie{ get; set; }
            
        public IEnumerable<Kurs> Nowosci { get; set; }
        public IEnumerable<Kurs> Bestsellery { get; set; }
    }
}