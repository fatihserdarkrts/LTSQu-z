using LTSQuız.Data;
using LTSQuız.Models;
using Microsoft.AspNetCore.Mvc;

namespace LTSQuız.Controllers
{
    public class CardController : Controller
    {
        private readonly LTSDBContext _dbContext;


        public CardController(LTSDBContext context)
        {
            _dbContext = context;
        }
       
        public IActionResult Index()
        {
            var kartlar = _dbContext.Kartlar.ToList();
            return View(kartlar);
        }
        [HttpGet]
        public IActionResult CardCreate()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CardCreate([Bind("KartID,Unvan,VergiDairesi,VergiNo,Tc,Adres,TipID,TurID,GrupID,AltGrupID")] HesapKartTbl kart)
        {
            _dbContext.Kartlar.Add(kart);
            _dbContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult CardUpdate()
        {
          
            return View();
        }

        [HttpPut]
        public IActionResult CardUpdate(HesapKartTbl kart)
        {
            var model = _dbContext.Kartlar.Find(kart.KartID);
            model.Unvan = kart.Unvan;
            model.VergiDairesi = kart.VergiDairesi;
            model.VergiNo = kart.VergiNo;
            model.Tc = kart.Tc;
            model.Adres = kart.Adres;
            model.TipID = kart.TipID;
            model.TurID = kart.TurID;
            model.GrupID = kart.GrupID;
            model.AltGrupID = kart.AltGrupID;
            _dbContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult CardDelete()
        {
           return View();
        }


        [HttpDelete]
        public ActionResult CardDelete(IEnumerable<int> ids)
        {
            var kart = _dbContext.Kartlar.Find(ids);
            _dbContext.Kartlar.Remove(kart);
            _dbContext.SaveChangesAsync();
            return RedirectToAction("Delete");
        }

    }
}
