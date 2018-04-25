using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:50)]
        public string Login { get; set; }
        [Required, MaxLength(256)]
        public byte[] Password { get; set; }
        public virtual Objectives Linse { get; set; }
        public virtual IList<Research> ResearchsUser { get; set; }
        public virtual ConfigHair Config { get; set; }
        public virtual IList<ContactS> Contacts { get; set; }
        public virtual AccesRight Access { get; set; }
        public virtual IList <ReportTemplate> Repors { get; set; }
        public virtual IList<Visit> Visits { get; set; }



    }
}
