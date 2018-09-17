using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppListDal.Model
{
    public partial class Arch
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CrossID")]
        public double? CrossId { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Arch")]
        public ApplicationList IdNavigation { get; set; }
    }
}
