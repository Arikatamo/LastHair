using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
    public interface iDiagnosesProv
    {
        Diagnoses Add(Diagnoses item);
        void Remove(Diagnoses item);
        Diagnoses Get(int id);
        IList<Diagnoses> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
