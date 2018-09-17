using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppListDal.Model
{
    public partial class TbleColumn
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string OldName { get; set; }
        [StringLength(255)]
        public string ColumnName { get; set; }
        [StringLength(255)]
        public string Definition { get; set; }
        [StringLength(255)]
        public string Table { get; set; }
        [StringLength(255)]
        public string Values { get; set; }
    }
}
