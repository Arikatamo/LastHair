using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iResearchStatus
    {
        ResearStatus Add(ResearStatus item);
        IList<ResearStatus> GetAll();
        void Remove(ResearStatus item);
        void SaveChanges();
        void Dispose();
    }
}
