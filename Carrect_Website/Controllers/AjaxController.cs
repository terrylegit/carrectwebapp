using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carrect_Website.Models;
namespace Carrect_Website.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult LoadCarModel(int CarBrandID)
        {
            using (CarrectEntities db = new CarrectEntities())
            {
                var model = db.CarModels.Where(m => m.CarBrandID == CarBrandID).ToList();
                return PartialView(model);
            }

        }
    }
}