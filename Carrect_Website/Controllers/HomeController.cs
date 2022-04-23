using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrect_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
            return PartialView();
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
        public ActionResult MenuTop()
        {
            return PartialView();
        }
    }
}