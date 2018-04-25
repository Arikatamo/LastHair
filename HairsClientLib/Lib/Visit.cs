using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblVisit")]
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public virtual IList<User> Users { get; set; }
        public virtual Patient Patients { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public virtual IList<CommentaryToVisit> Commentary { get; set; }
        public virtual IList<Research> Reserches { get; set; }
    }
}
