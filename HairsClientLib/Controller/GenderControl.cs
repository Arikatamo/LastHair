using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Controller
{
    public class GenderControl : iGender
    {
        EFContext context;
        public GenderControl(EFContext _context)
        {
            context = _context;
        }
        public GenderS Add(GenderS item)
        {
           return context.Genders.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<GenderS> GetAll()
        {
            return context.Genders.ToList();
        }

        public void Remove(GenderS item)
        {
            context.Genders.Remove(item); 
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
