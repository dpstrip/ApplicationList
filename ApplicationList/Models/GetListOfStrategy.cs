using ApplicationList.ViewModel;
using AppListDal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationList.Models
{
    public class GetListOfStrategy
    {
        public List<AnStrategyView> GetApps()
        {
            var db = new AppListContext();

            var appList = db.ApplicationList.Include(a => a.Strategy);
            List<AnStrategyView> myList = new List<AnStrategyView>();

            foreach (AppListDal.Model.ApplicationList app in appList)
            {
                AnStrategyView asv = new AnStrategyView();
                asv.Applicaiton = app.Application;
                asv.FusionStrategy = app.Strategy.FusionStrategy;
                asv.ID = app.Strategy.Id;
                asv.Integrated = app.Strategy.Integrated;
                asv.LegacyOriginator = app.Strategy.LegacyOriginator;
                asv.SAP = app.Strategy.Sap;
                asv.SAPArea = app.Strategy.Saparea;
                asv.SAPIntegration = app.Strategy.Sapintegration;
                myList.Add(asv);
            }

            return myList;
        }
    }
}
