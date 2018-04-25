using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public  class ResearchStatusControl: iResearchStatus
    {
        EFContext context;
        public ResearchStatusControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ResearStatus Add(ResearStatus item)
        {
            return context.ResearStatus.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ResearStatus> GetAll()
        {
            return context.ResearStatus.ToList();
        }

        public void Remove(ResearStatus item)
        {
            context.ResearStatus.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
