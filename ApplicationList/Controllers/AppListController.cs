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

    }
}