using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblReportTemplate")]
    public class ReportTemplate
    {
        [Key]
        public int Id { get; set; }
        public virtual IList<ImageLogo> Images { get; set; }
        public virtual IList<FieldType> FieldTypes { get; set; }
        public virtual IList<Reportfield> ReportFields { get; set; }
        public virtual Research Research { get; set; }
        public virtual User User { get; set; }
    }
}
