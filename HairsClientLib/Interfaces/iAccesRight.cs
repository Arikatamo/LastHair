using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    /// <summary>
    /// Права доступа
    /// </summary>
    public interface iAccesRight
    {
        AccesRight Add(AccesRight item);
        IList<AccesRight> GetAll();
        void Remove(AccesRight item);
        void SaveChanges();
        void Dispose();
    }
}
