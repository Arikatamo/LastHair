using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblResearch")]
    public class Research
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        public ResearchType ResearchType { get; set; }
        [Required]
        public ResearStatus ResearchStatuses { get; set; }
        [Required]
        public byte[] Thunmbnail { get; set; }
        public virtual IList<Photoses> Photos { get; set; }
        [Required]
        public virtual Hair Hair { get; set; }
        [Required]
        public int ResearchArea { get; set; }
        [Required,StringLength(maximumLength:2000)]
        public string Commentary { get; set; }
        [Required]
        public DateTime TimeResearch { get; set; }
        [Required]
        public virtual Diagnoses Diagnos { get; set; }
        [Required]
        public string Treatment { get; set; }
        [Required]
        public virtual ConfigHair Config { get; set; }
        [Required]
        public virtual Objectives Lens { get; set; }
        [Required]
        public virtual Visit Visit { get; set; }
        [Required]
        public virtual User User { get; set; }


    }
}
