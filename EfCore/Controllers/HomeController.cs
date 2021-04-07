using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core;
using EfCore.Data;
using EfCore.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using EfCore.Models;

namespace EfCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var logger = new Logger();
            logger.LogInformation("Teste logger");
            
            var endereco = new Endereco()
            {
                Logradouro = "Rua 05"
            };
            
            _applicationDbContext.Pessoas.Add(new Pessoa()
            {
                Nome = "Teste 1",
                Endereco = endereco
            });
            await _applicationDbContext.SaveChangesAsync();
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}