using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Controller
{
    public class ResearchTypeControl : iResearchType
    {
        EFContext context;
        public ResearchTypeControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ResearchType Add(ResearchType item)
        {
            return context.ResearType.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ResearchType> GetAll()
        {
            return context.ResearType.ToList();
        }

        public void Remove(ResearchType item)
        {
            context.ResearType.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
