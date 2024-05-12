﻿using Microsoft.AspNetCore.Mvc;
using MvcCreditApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace MvcCreditApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly CreditContext db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CreditContext context)
        {
            _logger = logger;
            db = context;
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits(); 
            var allBids = db.Bids.ToList<Bid>(); 
            ViewBag.Bids = allBids; 
            return View();
        }
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now; 
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid); 
            // Сохраняем в БД все изменения
            db.SaveChanges(); return "Спасибо, " + newBid.Name + ", за выбор " +
                "нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
        }

            public IActionResult Index()
        {
            GiveCredits();
            return View();
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
        //Асинхронный метод
        //Извелечение из БД нужной информации в частичное представление
        public ActionResult BidSearch(string name)
        {
            var allBids = db.Bids.Where(a => a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Указанный кредит " + name + " не найден");
                //return HttpNotFound();
            }
            return PartialView(allBids);
        }
    }
}