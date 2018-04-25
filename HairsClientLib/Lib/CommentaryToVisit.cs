﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblCommentaryToVisit")]
    public class CommentaryToVisit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual CommentaryType CommentaryType { get; set; }
        [StringLength(maximumLength:2000)]
        public string Commentary { get; set; }
        [Required]
        public virtual Visit Visit { get; set; }
    }
}
