﻿using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }

        [HttpGet]
        public ViewResult InputData() 
        { 
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }

        private static PersonRepository db = new PersonRepository();

        //Ex1-2
        //public string Index(string hel)
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel;
        //    return Greeting;
        //}


        //Ex1-3
        //public string Index(string hel)
        //{
        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;
        //}
    }
}
