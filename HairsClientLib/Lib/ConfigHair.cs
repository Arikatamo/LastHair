using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblConfigHair")]
    public class ConfigHair
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual ConfigHairSize ConfHairSize { get; set; }
        [Required]
        public virtual ConfigStaticNormales ConfStatNormal { get; set; }
        public virtual IList<Research> Researches { get; set; }
        public virtual IList<User> Users { get; set; }




    }
}
