using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StonePlusCalc.Models;

namespace StonePlusCalc.Controllers
{
    public class HomeController : Controller
    {
        private StonePlusDBEntities1 db = new StonePlusDBEntities1();

        public ActionResult Index()
        {
            var model = new CostModel
            {
                check = false
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CostModel model)
        {
            Stone a = db.Stones.FirstOrDefault(t => t.Code == model.Code);

            double totalCost = (model.FPPT * model.Tons) + (model.MPPT * model.Tons);
            double costPerYard = totalCost / ((model.FPPT + model.MPPT) * 1.325);
            double prelimCost = totalCost / costPerYard;
            double vendorI = (model.MPPT * model.Tons) / prelimCost;
            double vendorC = (model.MPPT * model.Tons) / vendorI;
            double freightI = (model.FPPT * model.Tons) / prelimCost;
            double freightC = (model.FPPT * model.Tons) / freightI;

            var modell = new CostModel
            {
                VI = vendorI,
                VC = vendorC,
                FI = freightI,
                FC = freightC,
                check = true
            };

            return View(modell);
        }

        public ActionResult About()
        {
            var model = new CostModel
            {
                check = false
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult About(CostModel model)
        {
            Stone a = db.Stones.FirstOrDefault(t => t.Code == model.Code);

            double totalCost = (model.FPPT * model.Tons) + (model.MPPT * model.Tons);
            double costPerYard = totalCost / ((model.FPPT + model.MPPT) * 1.325);
            double prelimCost = totalCost / costPerYard;
            double vendorI = (model.MPPT * model.Tons) / prelimCost;
            double vendorC = (model.MPPT * model.Tons) / vendorI;
            double freightI = (model.FPPT * model.Tons) / prelimCost;
            double freightC = (model.FPPT * model.Tons) / freightI;

            var modell = new CostModel
            {
                VI = vendorI,
                VC = vendorC,
                FI = freightI,
                FC = freightC,
                check = true
            };

            return View(modell);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}