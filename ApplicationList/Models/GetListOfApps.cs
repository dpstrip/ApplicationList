using ApplicationList.ViewModel;
using AppListDal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationList.Models
{
    public class GetListOfApps
    {
        public List<AnApplicationView> GetApps()
        {
            var db = new AppListContext();

            var appList = db.ApplicationList;
            List<AnApplicationView> myList = new List<AnApplicationView>();

            foreach(AppListDal.Model.ApplicationList app in appList)
            {
                AnApplicationView aap = new AnApplicationView();
                aap.Application = app.Application;
                aap.ApplicationDescription = app.ApplicationDescription;
                aap.AppType = app.ApplicationType;
                aap.ArchLayer = app.ArchitectureLayer;
                aap.BusinessOwner = app.BusinessOwner;
                aap.EnterprisevsPlantSpecific = app.EnterprisevsPlantSpecific;
                aap.FunctionalArea = app.FunctionalArea;
                aap.ID = app.Id;
                aap.ITOwner = app.Itowner;
                aap.LocationUsed = app.LocationUsed;
                aap.Path = app.Path;
                aap.TechOwner = app.TechOwner;
                aap.TypesOfUser = app.TypesofUsers;

                myList.Add(aap);
            }

            return myList;
        }
    }
}
