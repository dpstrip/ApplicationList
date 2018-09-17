using System;
using System.Linq;
using AppListDal.Model;
using ApplicationList.ViewModel;

namespace ApplicationList.Models
{
    public class GetAnApp
    {
        private AppListDal.Model.ApplicationList AnApp { get; set; }

        public GetAnApp(string id)
        {
            var db = new AppListContext();
            int i = Convert.ToInt32(id);
            var pps = db.ApplicationList.Where(a => a.Id == i);

            AnApp = pps.First();
        }

        public void FillInViewModel(AnApplicationView apv)
        {
            apv.Application = AnApp.Application;
            apv.ApplicationDescription = AnApp.ApplicationDescription;
            apv.AppType = AnApp.ApplicationType;
            apv.ArchLayer = AnApp.ArchitectureLayer;
            apv.BusinessOwner = AnApp.BusinessOwner;
            apv.EnterprisevsPlantSpecific = AnApp.EnterprisevsPlantSpecific;
            apv.FunctionalArea = AnApp.FunctionalArea;
            apv.ID = AnApp.Id;
            apv.ITOwner = AnApp.Itowner;
            apv.LocationUsed = AnApp.LocationUsed;
            apv.Notes = AnApp.Notes;
            apv.Path = AnApp.Path;
            apv.TechOwner = AnApp.TechOwner;
            apv.TypesOfUser = AnApp.TypesofUsers;
 

        }

    }
}
