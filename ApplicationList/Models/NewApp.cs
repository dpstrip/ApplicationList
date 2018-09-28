using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppListDal.Model;

namespace ApplicationList.Models
{
    public class NewApp
    {
        public string Application { get; set; }
        public string FuncationalArea { get; set; }
        public string ApplicationDescription { get; set; }
        public string EnterprisevsPlantSpecific { get; set; }
        public string ArchitectureLayer { get; set; }
        public string Notes { get; set; }
        public string BusienssOwner { get; set; }
        public string ITOwner { get; set; }
        public string TechOwner { get; set; }
        public string Path { get; set; }
        public string LocationUsed { get; set; }
        public string ApplicationType { get; set; }
        public string TypesofUsers { get; set; }

        public string Availability { get; set; }
        public string MnthlyDwnTmeMax { get; set; }
        public string PriorityLevel { get; set; }
        public string DB { get; set; }
        public string InfraComment { get; set; }
        public string CloudOnPremSAAS { get; set; }
        public string OS { get; set; }

        public string MasterDataReq { get; set; }
        public string GDPRCriticality { get; set; }
        public string EMEAIGoLiveDate { get; set; }
        public string TxtDPQCmpltePriorToFusion { get; set; }
        public string TxtDPQCmpltePriorForFusionChanages { get; set; }
        public string DataPrivacyApproval { get; set; }
        public string ITSecurityApproval { get; set; }
        public string WCApprovalRequired { get; set; }
        public string WCQuestionaireSent { get; set; }
        public string WCQuestionaireComplete { get; set; }
        public string WCApproved { get; set; }

        public string SAP { get; set; }
        public string Integrated { get; set; }
        public string SAPIntegration { get; set; }
        public string FusionStrategy { get; set; }
        public string LegacyOriginator { get; set; }
        public string SAPArea { get; set; }

        private AppListDal.Model.ApplicationList aplist = new AppListDal.Model.ApplicationList();

        public void ConvertToAppList()
        {
           // AppListDal.Model.ApplicationList aplist = new AppListDal.Model.ApplicationList();
            //Set applist
//need id if it is a update
            aplist.Application = this.Application;
            aplist.ApplicationDescription = this.ApplicationDescription;
            aplist.ApplicationType = this.ApplicationType;
            aplist.ArchitectureLayer = this.ArchitectureLayer;
            aplist.BusinessOwner = this.BusienssOwner;
            aplist.EnterprisevsPlantSpecific = this.EnterprisevsPlantSpecific;
            aplist.FunctionalArea = this.FuncationalArea;
            aplist.Itowner = this.ITOwner;
            aplist.TechOwner = this.TechOwner;
            aplist.Path = this.Path;
            aplist.TypesofUsers = this.TypesofUsers;
            aplist.LocationUsed = this.LocationUsed;
            aplist.Notes = this.Notes;

            //set Infra
            AppListDal.Model.InfraSlas sla = new InfraSlas();
            sla.Availability = this.Availability;
            sla.MnthlyDwnTmeMax = this.MnthlyDwnTmeMax;
            sla.PriorityLevel = this.PriorityLevel;
            sla.Db = this.DB;
            sla.InfraComment = this.InfraComment;
            sla.CloudOnPremSaas = this.CloudOnPremSAAS;
            sla.Os = this.OS;
            aplist.InfraSlas = sla;

            //setSecurityCompliance
            SecurityCompliance sc = new SecurityCompliance();
            sc.MasterDataReq = this.MasterDataReq;
            sc.Gdprcriticality = this.GDPRCriticality;
            sc.EmeaigoLiveDate = this.EMEAIGoLiveDate;
            sc.DpqcmpltePriorForFusionChanages = this.TxtDPQCmpltePriorForFusionChanages;
            sc.DpqcmpltePriorToFusion = this.TxtDPQCmpltePriorToFusion;
            sc.DataPrivacyApproval = this.DataPrivacyApproval;
            sc.ItSecurityApproval = this.ITSecurityApproval;
            sc.WcapprovalRequired = this.WCApprovalRequired;
            sc.WcquestionaireSent = this.WCQuestionaireSent;
            sc.WcquestionaireComplete = this.WCQuestionaireComplete;
            sc.Wcapproved = this.WCApproved;
            aplist.SecurityCompliance = sc;

            //set Strategy
            Strategy st = new Strategy();
            st.Sap = this.SAP;
            st.Integrated = this.Integrated;
            st.Sapintegration = this.SAPIntegration;
            st.FusionStrategy = this.FusionStrategy;
            st.LegacyOriginator = this.LegacyOriginator;
            st.Saparea = this.SAPArea;

            aplist.Strategy = st;
            
    
        //return aplist;

        }

        public void SaveData()
        {
            AppListDal.Model.AppListContext context = new AppListContext();
            context.Add<AppListDal.Model.ApplicationList>(aplist);
            context.SaveChanges();
        }
    }
}
