using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Exo.Cinema.Controllers
{
    public class SallesController : Controller
    {
        // GET: Salles
        public ActionResult Index()
        {
            ViewBag.Title = "Accueil";
            return View();
        }

        public ActionResult Reserver(int id)
        {
            ViewBag.SalleNumber = id;
            ViewBag.Title = $"Réservation d'une séance en salle {id}";
            switch (id)
            {
                case 1:
                    ViewBag.Film1 = "Jurassic park";
                    ViewBag.Film2 = "Matrix";
                    ViewBag.Film3 = "Short Circuit";
                    break;
                case 2:
                    ViewBag.Film1 = "ET";
                    ViewBag.Film2 = "Alien";
                    ViewBag.Film3 = "Driven";
                    break;
                case 3:
                    ViewBag.Film1 = "It";
                    ViewBag.Film2 = "Jurassic park";
                    ViewBag.Film3 = "ET";
                    break;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Reserver(int id, FormCollection collection)
        {
            ViewBag.Title = $"Confirmation de réservation d'une séance en salle {id}";
            string value = collection["seance"];
            ViewBag.SalleNumber = id;
            switch (int.Parse(collection["seance"]))
            {
                case 1:
                    ViewBag.heure = "12h00";
                    break;
                case 2:
                    ViewBag.heure = "14h30";
                    break;
                case 3:
                    ViewBag.heure = "18h00";
                    break;
            }
            return View("ConfirmedReserver");
        }
    }
}