using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationList.ViewModel;
using AppListDal.Model;
using Microsoft.EntityFrameworkCore;

namespace ApplicationList.Models
{
    public class GetListSecurityView
    {
        public List<AnSecurityView> GetApps()
        {
            var db = new AppListContext();

            var appList = db.ApplicationList.Include(a => a.SecurityCompliance);
            List<AnSecurityView> myList = new List<AnSecurityView>();

            foreach (AppListDal.Model.ApplicationList app in appList)
            {
                AnSecurityView asv = new AnSecurityView();
                asv.Applicaiton = app.Application;
                asv.DtPrvcyAppvl = app.SecurityCompliance.DataPrivacyApproval;
                asv.DPQCCmpltPrrForFusion = app.SecurityCompliance.DpqcmpltePriorForFusionChanages;
                asv.DPQCCmpltPrrToFusion = app.SecurityCompliance.DpqcmpltePriorToFusion;
                asv.EMEAIGoLiveDate= app.SecurityCompliance.EmeaigoLiveDate;
                asv.GDPR = app.SecurityCompliance.Gdprcriticality;
                asv.ID = app.SecurityCompliance.Id;
                asv.ITSecurityApproval = app.SecurityCompliance.ItSecurityApproval;
                asv.MasterDataReq = app.SecurityCompliance.MasterDataReq;
                asv.WCApprovalRequired = app.SecurityCompliance.WcapprovalRequired;
                asv.WCApprovalSent = app.SecurityCompliance.WcquestionaireSent;
                asv.WCApproved = app.SecurityCompliance.Wcapproved;
                asv.WCComplete = app.SecurityCompliance.WcquestionaireComplete;

                myList.Add(asv);
            }

            return myList;
        }
    }
}
