using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Concrete
{
    public class AccesRightsController : iAccesRight
    {
        EFContext context;
        public AccesRightsController(EFContext _context)
        {
            context = _context;
        }
        public AccesRight Add(AccesRight item)
        {
            return context.Access.Add(item);
        }

        public IList<AccesRight> GetAll()
        {
            return context.Access.ToList();
        }

        public void Remove(AccesRight item)
        {
            context.Access.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
