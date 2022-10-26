using CustomValid_AspTag_HtmlTagHelper.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace CustomValid_AspTag_HtmlTagHelper.Models
{
    public class Pet
    {
        public int HayvanId { get; set; }
        public string HayvanAdi { get; set; }
        public string Tur { get; set; }
        public int AyakSayisi { get; set; }
        public int Yas { get; set; }
        public decimal HayvanKilo { get; set; }
        public BeslenmeTuru HayvanBeslenmeTuru { get; set; }
    }
    
}
