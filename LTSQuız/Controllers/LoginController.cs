using LTSQuız.Data;
using LTSQuız.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;





namespace LTSQuız.Controllers
{
    public class LoginController : Controller
    {
        private readonly LTSDBContext _dbContext;


        public LoginController(LTSDBContext context)
        {
            _dbContext = context;
        }
        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index([Bind("Email,Sifre")] KullanıcıTbl x)
        {

            if (ModelState.IsValid)
            {
               
                KullanıcıTbl kullanıcı = await _dbContext.Kullanıcılar.FirstOrDefaultAsync(m => m.Email == x.Email && m.Sifre == x.Sifre);

                if (kullanıcı == null)
                {
                    ModelState.AddModelError("", "Eposta veya Şifre yanlış");
                    return View(x);
                }
                return Redirect("~/Home/Index");
               
            }
            return View(x);
        }
    }
}
