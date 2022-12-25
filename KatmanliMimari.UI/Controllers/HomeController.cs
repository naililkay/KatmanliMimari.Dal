using System.Diagnostics;
using KatmanliMimari.Dal;
using KatmanliMimari.Entity;
using KatmanliMimari.UI.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitOfWork _uow;

        PersonelModel _personelmodel;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow,PersonelModel personelmodel)
        {
            _logger = logger;
            _uow=uow;
            _personelmodel = personelmodel;
        }

        public IActionResult Index()
        {
          //  _uow._PersonelRep.List();
            return View(_uow._PersonelRep.List());
        }

        public IActionResult Privacy()
        {
            return View();
        }

       


        public IActionResult Create(Personel Newperson)
        {
           // _personelmodel.personel = new Personel();
            _personelmodel.personel = Newperson;
            _personelmodel.Head = "Yeni Giriş Yapılıyor";
            _personelmodel.Text = "Kaydet";
            _personelmodel.Cls = "btn btn-success";

            
            return View("Crud", _personelmodel);
        }

        [HttpPost]
        public IActionResult Create(PersonelModel p)
        {
            _uow._PersonelRep.Add(p.personel);
            _uow.Commit();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int Id)
        {
            _personelmodel.personel = _uow._PersonelRep.Find(Id);
            _personelmodel.Head = "Edit Yapılıyor";
            _personelmodel.Text = "Güncelle";
            _personelmodel.Cls = "btn btn-success";
            return View("Crud",_personelmodel);
        }
        [HttpPost]
        public IActionResult Edit(PersonelModel p)
        {
            _uow._PersonelRep.Update(p.personel);
            _uow.Commit();

            return RedirectToAction("Index");

        }
        public IActionResult Delete(int Id)
        {
            _personelmodel.personel = _uow._PersonelRep.Find(Id);
            _personelmodel.Head = "Delete Yapılıyor";
            _personelmodel.Text = "Sil";
            _personelmodel.Cls = "btn btn-danger";
            return View("Crud", _personelmodel);
           
        }
        [HttpPost]
        public IActionResult Delete(Personel p)
        {
            
            _uow._PersonelRep.Delete(p);
            _uow.Commit();

            return RedirectToAction("Index");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}