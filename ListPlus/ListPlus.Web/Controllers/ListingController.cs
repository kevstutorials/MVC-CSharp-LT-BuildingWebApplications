using ListPlus.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListPlus.Web.Controllers
{
    public class ListingController : Controller
    {
        // GET: Listing/List
        public ActionResult List()
        {
            /* 
             *   Hard Coded Data for list using ListingModel
             *
             */
            var list = new List<ListingModel>
            {
                new ListingModel {Id = 1, Title = "Food"},
                new ListingModel {Id = 2, Title = "Hardware"},
                new ListingModel {Id = 3, Title = "Vacation"}
            };


            return View(list);
        }
    }
}