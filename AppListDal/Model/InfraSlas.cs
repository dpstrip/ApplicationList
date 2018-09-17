using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppListDal.Model
{
    [Table("InfraSLAs")]
    public partial class InfraSlas
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string Availability { get; set; }
        [StringLength(255)]
        public string MnthlyDwnTmeMax { get; set; }
        [StringLength(255)]
        public string PriorityLevel { get; set; }
        [Column("DB", TypeName = "ntext")]
        public string Db { get; set; }
        [Column(TypeName = "ntext")]
        public string InfraComment { get; set; }
        [Column("CloudOn-PremSAAS")]
        [StringLength(255)]
        public string CloudOnPremSaas { get; set; }
        [Column("OS")]
        [StringLength(255)]
        public string Os { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("InfraSlas")]
        public ApplicationList IdNavigation { get; set; }
    }
}
