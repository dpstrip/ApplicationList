using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppListDal.Model
{
    public partial class ApplicationList
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        public string Application { get; set; }
        [Column(TypeName = "ntext")]
        public string FunctionalArea { get; set; }
        [Column(TypeName = "ntext")]
        public string ApplicationDescription { get; set; }
        [StringLength(255)]
        public string EnterprisevsPlantSpecific { get; set; }
        [StringLength(255)]
        public string ArchitectureLayer { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [Column(TypeName = "ntext")]
        public string BusinessOwner { get; set; }
        [Column("ITOwner")]
        [StringLength(255)]
        public string Itowner { get; set; }
        [StringLength(255)]
        public string TechOwner { get; set; }
        [StringLength(255)]
        public string Path { get; set; }
        [Column(TypeName = "ntext")]
        public string LocationUsed { get; set; }
        [StringLength(255)]
        public string ApplicationType { get; set; }
        [Column(TypeName = "ntext")]
        public string TypesofUsers { get; set; }

        [InverseProperty("IdNavigation")]
        public Arch Arch { get; set; }
        [InverseProperty("IdNavigation")]
        public InfraSlas InfraSlas { get; set; }
        [InverseProperty("IdNavigation")]
        public SecurityCompliance SecurityCompliance { get; set; }
        [InverseProperty("IdNavigation")]
        public Strategy Strategy { get; set; }
    }
}
