using LTSQuız.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTSQuız.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LTSQuız.Controllers
{
    public class HomeController : Controller
    {
        private readonly LTSDBContext _dbContext;


        public HomeController(LTSDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var kullanıcılar = _dbContext.Kullanıcılar.ToList();
            return View(kullanıcılar);
        }
      
      
       


    }
}