﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblResearchType")]
    public class ResearchType
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:50)]
        public string Name { get; set; }
        public virtual IList<Research> Researches { get; set; }
    }
}
