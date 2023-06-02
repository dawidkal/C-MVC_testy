using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Kurs
    { //pola, jesli nazwya sie tak jak klasa+id entity potraktuje to jako klucz glowny
        public int KursId { get; set; }
        public int KategoriaId {get; set; }

        [Required (ErrorMessage ="Wprowadz nazwe kursu") ] 
        [StringLength(100)]
        public string TytulKursu { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwe autora")]
        [StringLength(100)]
        public string AutorKursu { get; set; }
        public DateTime DataDodania { get; set; }

        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisKursu { get; set; }
        public decimal CenaKursu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; } // flaga jesl bedzie sprzedany
        public string OpisSkrocony { get; set; }
        public virtual Kategoria Kategoria { get; set; }

    }
}