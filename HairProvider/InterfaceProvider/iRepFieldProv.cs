using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
    public interface iRepFieldProv
    {
        Reportfield Add(Reportfield item);
        void Remove(Reportfield item);
        Reportfield Get(int id);
        IList<Reportfield> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
