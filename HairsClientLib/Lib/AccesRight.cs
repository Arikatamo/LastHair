﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblAccesRight")]
    public class AccesRight
    {
        [Key]
        public int Id { get; set; }
        public string AccessName { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
