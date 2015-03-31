using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingFive.Areas.Soltys.Models;

namespace TrainingFive.Areas.Soltys.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Soltys/Search/

        public ActionResult GenerateSearchForm()
        {
            SearchFormModel model = new SearchFormModel
            {
                PlacesList = new List<SelectListItem>
                {
                    new SelectListItem
                    {
                        Value = "1",
                        Text = "Opole"
                    },
                    new SelectListItem
                    {
                        Value = "2",
                        Text = "Kluczbork"
                    },
                    new SelectListItem
                    {
                        Value = "3",
                        Text = "Brzeg"
                    }
                }
            };


            return PartialView("SearchPartial", model);
        }

        [HttpPost]
        public ActionResult Search(SearchFormModel model)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
