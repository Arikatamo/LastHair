using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
   public interface iStatNormalProv
    {
        ConfigStaticNormales Add(ConfigStaticNormales item);
        void Remove(ConfigStaticNormales item);
        ConfigStaticNormales Get(int id);
        IList<ConfigStaticNormales> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
