using CustomValid_AspTag_HtmlTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomValid_AspTag_HtmlTagHelper.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult NewCustomer()
        {
            ViewBag.hayal = "Hayallerim";
            return View();
        }

        [HttpPost]
        public IActionResult NewCustomer(Customer newC)
        {
            if (ModelState.IsValid)
            {
                return Content("Kayıt Başarılı");
            }
            else
            {
                return View(newC);
            }
        }

        //2 sınıf person/pet
        //viewmodel
        //pet 2/4/6/8 ayak sayısı
        //Pet yasi max 15
        //pet beslenme türü (etçil,otçul,hepçil)
        //tasarım inputlar hata mesajları
    }
}
