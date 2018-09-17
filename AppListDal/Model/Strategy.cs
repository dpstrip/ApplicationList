using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppListDal.Model
{
    public partial class Strategy
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("SAP")]
        [StringLength(255)]
        public string Sap { get; set; }
        [StringLength(255)]
        public string Integrated { get; set; }
        [Column("SAPIntegration")]
        [StringLength(255)]
        public string Sapintegration { get; set; }
        [StringLength(255)]
        public string FusionStrategy { get; set; }
        [StringLength(255)]
        public string LegacyOriginator { get; set; }
        [Column("SAPArea")]
        [StringLength(255)]
        public string Saparea { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Strategy")]
        public ApplicationList IdNavigation { get; set; }
    }
}
