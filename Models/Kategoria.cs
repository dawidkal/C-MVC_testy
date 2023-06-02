using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe katagorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
      
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony{ get;set; }

        public virtual ICollection<Kurs> Kursy { get; set; } //kolekcja - bedzie mozna przypisac wiele kursow
    }
}