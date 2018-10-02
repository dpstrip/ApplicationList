using System;
using System.Linq;
using AppListDal.Model;
using ApplicationList.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApplicationList.Models
{
    public class GetAnApp
    {
        private AppListDal.Model.ApplicationList AnApp { get; set; }

        public GetAnApp(string id)
        {
            var db = new AppListContext();
            int i = Convert.ToInt32(id);
            var pps = db.ApplicationList.Where(a => a.Id == i).Include(a => a.InfraSlas).Include(a => a.SecurityCompliance).Include(a => a.Strategy);
            //var pps = db.ApplicationList.Where(a => a.Id == i);

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

        public void FillInNewApp(NewApp nap)
        {
            //app side
            nap.ID = AnApp.Id;
            nap.Application = AnApp.Application;
            nap.ApplicationDescription = AnApp.ApplicationDescription;
            nap.ApplicationType = AnApp.ApplicationType;
            nap.ArchitectureLayer = AnApp.ArchitectureLayer;
            nap.BusienssOwner = AnApp.BusinessOwner;
            nap.EnterprisevsPlantSpecific = AnApp.EnterprisevsPlantSpecific;
            nap.FuncationalArea = AnApp.FunctionalArea;
            nap.ID = AnApp.Id;
            nap.ITOwner = AnApp.Itowner;
            nap.LocationUsed = AnApp.LocationUsed;
            nap.Notes = AnApp.Notes;
            nap.Path = AnApp.Path;
            nap.TechOwner = AnApp.TechOwner;
            nap.TypesofUsers = AnApp.TypesofUsers;

            //security
            nap.DataPrivacyApproval = AnApp.SecurityCompliance.DataPrivacyApproval;
            nap.DPQCmpltePriorForFusionChanages  = AnApp.SecurityCompliance.DpqcmpltePriorForFusionChanages;
            nap.DPQCmpltePriorToFusion  = AnApp.SecurityCompliance.DpqcmpltePriorToFusion;
            nap.EMEAIGoLiveDate = AnApp.SecurityCompliance.EmeaigoLiveDate;
            nap.GDPRCriticality = AnApp.SecurityCompliance.Gdprcriticality;
            nap.ID = AnApp.SecurityCompliance.Id;
            nap.ITSecurityApproval = AnApp.SecurityCompliance.ItSecurityApproval;
            nap.MasterDataReq = AnApp.SecurityCompliance.MasterDataReq;
            nap.WCApprovalRequired = AnApp.SecurityCompliance.WcapprovalRequired;
            nap.WCQuestionaireSent = AnApp.SecurityCompliance.WcquestionaireSent;
            nap.WCApproved = AnApp.SecurityCompliance.Wcapproved;
            nap.WCQuestionaireComplete = AnApp.SecurityCompliance.WcquestionaireComplete;

            //infrastructure
            nap.Availability = AnApp.InfraSlas.Availability;
            nap.CloudOnPremSAAS = AnApp.InfraSlas.CloudOnPremSaas;
            nap.DB = AnApp.InfraSlas.Db;
            nap.ID = AnApp.InfraSlas.Id;
            nap.InfraComment = AnApp.InfraSlas.InfraComment;
            nap.MnthlyDwnTmeMax = AnApp.InfraSlas.MnthlyDwnTmeMax;
            nap.OS = AnApp.InfraSlas.Os;
            nap.PriorityLevel = AnApp.InfraSlas.PriorityLevel;

            //strategy
            
            nap.FusionStrategy = AnApp.Strategy.FusionStrategy;
            nap.ID = AnApp.Strategy.Id;
            nap.Integrated = AnApp.Strategy.Integrated;
            nap.LegacyOriginator = AnApp.Strategy.LegacyOriginator;
            nap.SAP = AnApp.Strategy.Sap;
            nap.SAPArea = AnApp.Strategy.Saparea;
            nap.SAPIntegration = AnApp.Strategy.Sapintegration;
        }

    }
}
