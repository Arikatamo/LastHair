using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairProvider.InterfaceProvider;
using HairsClientLib.Controller;
using HairsClientLib.Lib;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
    public interface iHairProv
    {
        Hair Add(Hair item);
        void Remove(Hair item);
        Hair Get(int id);
        IList<Hair> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
