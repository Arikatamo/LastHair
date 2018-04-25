using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
   public interface iPatientStatusProv
    {
        StatusesForPatient Add(StatusesForPatient item);
        void Remove(StatusesForPatient item);
        StatusesForPatient Get(int id,string status);
        IList<StatusesForPatient> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
