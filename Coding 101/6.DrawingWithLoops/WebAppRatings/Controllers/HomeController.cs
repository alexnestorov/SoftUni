using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppRatings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DrawRating(int rating)
        {
            ViewBag.Message = "Rating";
            int fullStarsCount = rating / 10;
            int emptyStarsCount = (100 - rating) / 10;
            int halfStarsCount = 10 - fullStarsCount - emptyStarsCount;
            string stars = "";
            for (int count = 0; count < fullStarsCount; count++)
            {
                stars += "<img src='/images/full-star.png'>";
            }
            for (int count = 0; count < halfStarsCount; count++)
            {
                stars += "<img src='/images/half-star.png'>";
            }
            for (int count = 0; count < emptyStarsCount; count++)
            {
                stars += "<img src='/images/empty-star.png'>";
            }
            return View("Index", "", stars);
        }

    }
}