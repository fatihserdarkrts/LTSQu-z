using LTSQuız.Data;
using LTSQuız.Models;
using Microsoft.AspNetCore.Mvc;

namespace LTSQuız.Controllers
{
    public class UserController : Controller
    {
        private readonly LTSDBContext _dbContext;


        public UserController(LTSDBContext context)
        {
            _dbContext = context;
        }
      
        
        public IActionResult Index()
        {
            var kullanıcılar = _dbContext.Kullanıcılar.ToList();
            return View(kullanıcılar);
        }
        [HttpPost]
        public async Task<IActionResult> Index([Bind("Ad,Soyad,KullaniciAdi,Sifre,Email,TelefonNo")] KullanıcıTbl kullanıcı)
        {
            await _dbContext.Kullanıcılar.AddAsync(kullanıcı);
            await _dbContext.SaveChangesAsync();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            var kullanıcılar = _dbContext.Kullanıcılar.ToList();
            return View(kullanıcılar);
        }
      

        [HttpGet]
        public IActionResult Update()
        {
           
            return View();
        }

        [HttpPut]
        public IActionResult Update(KullanıcıTbl kullanıcı)
        {
            var model = _dbContext.Kullanıcılar.Find(kullanıcı.UserID);
            model.Ad = kullanıcı.Ad;
            model.Soyad = kullanıcı.Soyad;
            model.KullaniciAdi = kullanıcı.KullaniciAdi;
            model.Sifre = kullanıcı.Sifre;
            model.Email = kullanıcı.Email;
            model.TelefonNo = kullanıcı.TelefonNo;
            _dbContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Delete()
        {
           
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(IEnumerable<int> ids)
        {
            var kullanıcı = _dbContext.Kullanıcılar.Find(ids);
            _dbContext.Kullanıcılar.Remove(kullanıcı);
            _dbContext.SaveChangesAsync();
            return RedirectToAction("Delete");
        }

    }
}
