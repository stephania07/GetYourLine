using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetYourlLine.Models;

namespace GetYourlLine.Controllers
{
    public class ApiController : Controller

    {
        private CustomerContext db = new CustomerContext();

        //GET :Api
        public ActionResult Index()
        {
            var query = from Customer in db.Customers
                        select Customer;
            return Json(query.ToList(), JsonRequestBehavior.AllowGet);

        }
    }
}