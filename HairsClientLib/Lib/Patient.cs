using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblPatient")]
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public virtual IList<ContactS> Contacts { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        [Required,StringLength(maximumLength:2000)]
        public string Comment { get; set; }
        public virtual IList<Photoses> Photos { get; set; }
        [Required]
        public DateTime DateNextVisit { get; set; }
        [Required]
        public DateTime TimeNextVisit { get; set; }
        [Required]
        public virtual StatusesForPatient Status { get; set; }
        public IList<Visit> Visits { get; set; }
    }
}
