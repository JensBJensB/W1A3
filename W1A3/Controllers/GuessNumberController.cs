using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W1A3.Models;

namespace W1A3.Controllers
{
    public class GuessNumberController : Controller
    {
        public static int GenerateNumber()
        {
            var NumberToGuess = new Random();
            return NumberToGuess.Next(1, 100);
        }

        [HttpGet]
        public ActionResult GTN()
        {

            HttpContext.Session.SetInt32("NumberToGuess", GenerateNumber());
            return View();
        }

        [HttpPost]
        public ActionResult GTN(int guessedNumber)
        {
            GuessNumberModel gnp = new GuessNumberModel();
            
            gnp.NumberToGuess = HttpContext.Session.GetInt32("NumberToGuess").Value;
            gnp.GuessedNumber = guessedNumber;
            ViewBag.Message = gnp.CheckGuess(guessedNumber);
            return View();
        }
    }
}


