using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iResearchType
    {
        ResearchType Add(ResearchType item);
        IList<ResearchType> GetAll();
        void Remove(ResearchType item);
        void SaveChanges();
        void Dispose();
    }
}
