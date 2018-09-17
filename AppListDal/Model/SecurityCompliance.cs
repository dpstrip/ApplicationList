using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppListDal.Model
{
    public partial class SecurityCompliance
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        public string MasterDataReq { get; set; }
        [Column("GDPRCriticality")]
        [StringLength(255)]
        public string Gdprcriticality { get; set; }
        [Column("EMEAIGoLiveDate", TypeName = "ntext")]
        public string EmeaigoLiveDate { get; set; }
        [Column("DPQCmpltePriorToFusion")]
        [StringLength(255)]
        public string DpqcmpltePriorToFusion { get; set; }
        [Column("DPQCmpltePriorForFusionChanages")]
        [StringLength(255)]
        public string DpqcmpltePriorForFusionChanages { get; set; }
        [StringLength(255)]
        public string DataPrivacyApproval { get; set; }
        [Column("IT Security Approval")]
        [StringLength(255)]
        public string ItSecurityApproval { get; set; }
        [Column("WCApprovalRequired")]
        [StringLength(255)]
        public string WcapprovalRequired { get; set; }
        [Column("WCQuestionaireSent", TypeName = "ntext")]
        public string WcquestionaireSent { get; set; }
        [Column("WCQuestionaireComplete", TypeName = "ntext")]
        public string WcquestionaireComplete { get; set; }
        [Column("WCApproved", TypeName = "ntext")]
        public string Wcapproved { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("SecurityCompliance")]
        public ApplicationList IdNavigation { get; set; }
    }
}
