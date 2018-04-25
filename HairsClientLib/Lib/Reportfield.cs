using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblReportfield")]
    public class Reportfield
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:100)]
        public string NameDiagnos { get; set; }
        [Required]
        public virtual FieldType FieldType { get; set; }
        [Required]
        public virtual FieldVariants FieldVariant { get; set; }
        public virtual ReportTemplate Template { get; set; }
    }
}
