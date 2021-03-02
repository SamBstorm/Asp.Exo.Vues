using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Exo.Cinema.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        public ActionResult Details(int id)
        {
            switch (id)
            {
                case 1:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
                case 2:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
                case 3:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
                case 4:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
                case 5:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
                case 6:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
                case 7:
                    ViewBag.FilmTitle = "Jurassic park";
                    ViewBag.FilmYear = 1992;
                    ViewBag.FilmUrl = "https://images-na.ssl-images-amazon.com/images/I/51dZZ4pl-kL.__AC_SX300_SY300_QL70_FMwebp_.jpg";
                    ViewBag.FilmActor = "Sam Neil";
                    break;
            }
            return View();
        }
    }
}