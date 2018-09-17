using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationList.ViewModel
{
    public class AnSecurityView
    {
        public int ID { get; set; }
        public string Applicaiton { get; set; }
        public string MasterDataReq { get; set; }
        public string GDPR { get; set; }
        public string EMEAIGoLiveDate { get; set; }
        public string DPQCCmpltPrrToFusion { get; set; }
        public string DPQCCmpltPrrForFusion { get; set; }
        public string DtPrvcyAppvl { get; set; }
        public string ITSecurityApproval { get; set; }
        public string WCApprovalRequired { get; set; }
        public string WCApprovalSent { get; set; }
        public string WCComplete { get; set; }
        public string WCApproved { get; set; }
    }
}
