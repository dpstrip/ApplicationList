using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationList.ViewModel;
using ApplicationList.Models;

namespace ApplicationList.Controllers
{
    public class AppListController : Controller
    {
        public IActionResult Index()
        {
            //AnApplicationView apv = new AnApplicationView("1");
            GetListOfApps apv = new GetListOfApps();
            ListOfAppsView lOApsV = new ListOfAppsView();
            lOApsV.anAppViewList = apv.GetApps();
            return View(lOApsV);
        }

        public string GetString()
        {
            return "Hello World is old now. It’s time for wassup bro ;)";
        }

        public IActionResult SLAs()
        {
            ListOfSLAs loa = new ListOfSLAs();
            GetListOfSLAs slaL = new GetListOfSLAs();
            loa.slaListView = slaL.GetApps();
            return View(loa);
        }

        public IActionResult Security()
        {
            ListOfSecurityView loa = new ListOfSecurityView();
            GetListSecurityView slaL = new GetListSecurityView();
            loa.anSecurityViewList = slaL.GetApps();
            return View(loa);
        }

        public IActionResult Strategy()
        {
            ListOfStrategyView loa = new ListOfStrategyView();
            GetListOfStrategy slaL = new GetListOfStrategy();
            loa.StrategyViewList = slaL.GetApps();
            return View(loa);
        }

        public ActionResult AddNew()
        {
            return View("AddNew");
        }

        public ActionResult CreateApp(string BtnSubmit)
        {
            return View("AddNew");
        }

    }
}