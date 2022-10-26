using CustomValid_AspTag_HtmlTagHelper.CustomValidations;
using CustomValid_AspTag_HtmlTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomValid_AspTag_HtmlTagHelper.ViewModels
{
    public class PersonPetVM
    {
        [Required(ErrorMessage = "Kişi Adı Zorunlu")]
        [Display(Name ="Kişi Adı")]
        public string InsanAdi { get; set; }

        [Required(ErrorMessage = "Kişi Yaşı Zorunlu")]
        [Display(Name = "Kişi Yaşı")]
        public int InsanYas { get; set; }

        [Required(ErrorMessage = "Şehir Zorunlu")]
        [Display(Name = "Şehir")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Hayvan Adı Zorunludur.")]
        [MaxLength(30, ErrorMessage = "Ad 30 karakterden uzun olamaz.")]
        [Display(Name = "Evcil Hayvan Adı")]
        public string HayvanAdi { get; set; }

        [Required(ErrorMessage = "Tür Bilgisi Zorunludur.")]
        [Display(Name ="Türü")]
        public string Tur { get; set; }

        [AyakSayisiValidation]
        [Required(ErrorMessage = "Ayak Sayısı Zorunludur.")]
        [Display(Name = "Evcil Hayvan Ayak Sayısı")]
        public int AyakSayisi { get; set; }

        [Required(ErrorMessage = "Yas Zorunlu")]
        [Range(0, 15, ErrorMessage = "Yaş 15 den fazla olamaz")]
        [Display(Name = "Evcil Hayvan Yaşı")]
        public int HayvanYas { get; set; }

        [Display(Name = "Evcil Hayvan Kilosu")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal HayvanKilo { get; set; }

        [Display(Name ="Beslenme Türü")]
        public BeslenmeTuru HayvanBeslenmeTuru { get; set; }


    }
}
