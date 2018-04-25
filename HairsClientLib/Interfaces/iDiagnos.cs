﻿using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iDiagnos
    {
        Diagnoses Add(Diagnoses item);
        IList<Diagnoses> GetAll();
        void Remove(Diagnoses item);
        void SaveChanges();
        void Dispose();
    }
}
