using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepMVC.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        [Required(ErrorMessage = "Wprowadz imie")] //atrybuty
        [StringLength(60)]public string Imie { get; set; }
        
        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(60)]
        public string Nazwisko { get; set; }
        
        [Required(ErrorMessage = "Wprowadz ulice")]
        [StringLength(60)]
        public string Ulica { get; set; }
        
        [Required(ErrorMessage = "Wprowadz Miasto")]
        [StringLength(60)]
        public string Miasto { get; set; }
        
        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(60)]
        public string KodPocztowy { get; set; }
        
        public string Telefon{ get; set; }
        public string Email { get; set; }
        public string Komentarz { get; set; }
        public DateTime DataDodania { get; set; }
        public StanZamowienia StanZamowienia { get; set; } //enum
        public decimal WartoscZamowienia { get; set; }

        List<PozycjaZamowienia> PozycjeZamowienia { get; set; }
     }

    public enum StanZamowienia
    {
        Nowe, 
        Zrealizowane
    }
}