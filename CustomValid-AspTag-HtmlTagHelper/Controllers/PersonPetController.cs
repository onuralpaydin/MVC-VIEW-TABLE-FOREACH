using CustomValid_AspTag_HtmlTagHelper.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomValid_AspTag_HtmlTagHelper.Controllers
{
    public class PersonPetController : Controller
    {
       List<PersonPetVM> VMlist = new List<PersonPetVM>();
        PersonPetVM ilkVm = new PersonPetVM()
        {
            AyakSayisi = 2,
            HayvanAdi = "Çomar",
            HayvanBeslenmeTuru = Models.BeslenmeTuru.Etcil,
            HayvanKilo = 25,
            HayvanYas = 5,
            InsanAdi = "Tarık",
            InsanYas = 27,
            Sehir = "Ankara",
            Tur = "Küpek"

        };
        PersonPetVM ikinciVm = new PersonPetVM()
        {
            AyakSayisi = 2,
            HayvanAdi = "Kuçu",
            HayvanBeslenmeTuru = Models.BeslenmeTuru.Etcil,
            HayvanKilo = 25,
            HayvanYas = 5,
            InsanAdi = "Ozan",
            InsanYas = 27,
            Sehir = "Ankara",
            Tur = "Köpek"

        };

     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonPetBilgiGirisi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PersonPetBilgiGirisi(PersonPetVM bg)//create
        {
            if (ModelState.IsValid)
            {
                PersonPetVM inputtanGelen = new PersonPetVM();
                VMlist.Add(inputtanGelen);
                return View("Details",VMlist);
            }
            else
            {
                return View(bg);
            }
        }

        public IActionResult Details()//listeleme
        {
            //PersonPetVM ilkVm = new PersonPetVM()
            //{
            //    AyakSayisi = 2,
            //    HayvanAdi = "Çomar",
            //    HayvanBeslenmeTuru = Models.BeslenmeTuru.Etcil,
            //    HayvanKilo = 25,
            //    HayvanYas = 5,
            //    InsanAdi = "Tarık",
            //    InsanYas = 27,
            //    Sehir="Ankara",
            //    Tur="Küpek"
            
            //};
            //PersonPetVM ikinciVm = new PersonPetVM()
            //{
            //    AyakSayisi = 2,
            //    HayvanAdi = "Kuçu",
            //    HayvanBeslenmeTuru = Models.BeslenmeTuru.Etcil,
            //    HayvanKilo = 25,
            //    HayvanYas = 5,
            //    InsanAdi = "Ozan",
            //    InsanYas = 27,
            //    Sehir = "Ankara",
            //    Tur = "Köpek"

            //};

            //VMlist.Add(ilkVm);
            //VMlist.Add(ikinciVm);
            return View(VMlist);
        }

        public IActionResult Listele()//listeleme
        {
            VMlist.Add(ilkVm);
            VMlist.Add(ikinciVm);
            return View(VMlist);
        }

    }
}
