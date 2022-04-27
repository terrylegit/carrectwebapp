using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carrect_Website.Models;
namespace Carrect_Website.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult LandingPage()
        {
            return View();
        }

        public ActionResult PhoneInputForm()
        {
            return PartialView();
        }

        public ActionResult OTPAuthentication()
        {
            return PartialView();
        }

        public ActionResult BookingDetails()
        {
            return PartialView();
        }
        public  ActionResult InputCarDetails()
        {
            using (CarrectEntities db = new CarrectEntities())
            {
                var model = db.CarBrands.ToList();
                return PartialView(model);

            }
        }
        public ActionResult ChooseServices()
        {
            return PartialView();
        }
        public ActionResult ReviewBillsDiscount()
        {
            return PartialView();
        }
        public ActionResult WaitScreen()
        {
            return PartialView();
        }
        public ActionResult SuccessBooking()
        {
            return PartialView();
        }
        public ActionResult MenuTop1()
        {
            return PartialView();
        }
        public ActionResult MenuTop2()
        {
            return PartialView();
        }
    }
}