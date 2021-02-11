using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc1CodeFirstToAzure.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mvc1CodeFirstToAzure.Data;
using Mvc1CodeFirstToAzure.ViewModels;

namespace Mvc1CodeFirstToAzure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel();

            //Sätta värden i vymodellen (mappa från databas)
            viewModel.Players = _dbContext.Players.Select(db =>
                new HomeIndexViewModel.PlayerViewModel
                {
                    Id = db.Id,
                    Namn = db.Namn
                }
            ).ToList();

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
