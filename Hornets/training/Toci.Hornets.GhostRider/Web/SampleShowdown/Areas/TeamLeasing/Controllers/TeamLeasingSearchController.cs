using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using SampleShowdown.Areas.TeamLeasing.Models;
using Toci.Phoenix.Bll.Interfaces.TeamLeasing.BusinessModel;
using Toci.Phoenix.Bll.Interfaces.TeamLeasing.Logic;

namespace SampleShowdown.Areas.TeamLeasing.Controllers
{

    

    public class TeamLeasingSearchController : Controller
    {
        private IPortfolioLogic _portfolioLogic;

        

//        public TeamLeasingSearchController(IPortfolioLogic portfolioLogic) // PortfolioLogic
//        {
//            _portfolioLogic = portfolioLogic;
//        }
        // GET: TeamLeasing/TeamLeasingSearch
        public ActionResult Index(TeamLeasingSearchModel model)
        {
            Dictionary<Func<TeamLeasingSearchModel, bool>, Func<TeamLeasingSearchModel, ActionResult>> IndexActionMap = new Dictionary<Func<TeamLeasingSearchModel, bool>, Func<TeamLeasingSearchModel, ActionResult>>
            {
                { (item) => item.Duch == "tadam", Duch },
                { (item) => item.Ksebal == "jaja", Ksebal },
                { (item) => item.Szyfrant == "haha", Szyfrant },
            };

            try
            {
                IndexActionMap.First(item => item.Key(model)).Value(model);
 
                // MOCK !!!!!!!! 

               // IPortfolioBusinessModel result = _portfolioLogic.GetEmployeePortfolio(5);

                //result.Technologies
                //model.Confirm


                model.ViewDataResults = new List<TeamSearchResults>
                {
                    new TeamSearchResults { Name = "Patryk"},
                    new TeamSearchResults { Name = "Agata"},
                };
            }
            catch (Exception)
            {
                
            }

            return View(model);
        }

        private ActionResult Ksebal(TeamLeasingSearchModel model)
        {
            model.AleCheca = "checa by ksebal";
            return View("index", model);
        }

        private ActionResult Duch(TeamLeasingSearchModel model)
        {
            model.AleCheca = "checa by duch";
            return View("index", model);
        }

        private ActionResult Szyfrant(TeamLeasingSearchModel model)
        {
            model.AleCheca = "checa by szyfrant";
            return View("index", model);
        }

        public ActionResult Save(TeamLeasingSearchModel model)
        {
            /// zapis i sprawdzenie czy sie udalo
            /// 


            if (model.EmployeeId == 8)
            {
                return View("index", model);
            }

            return RedirectToAction("index");
        }
    }
}