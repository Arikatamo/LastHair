using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
   public interface iConfigHairSizeProv
    {
        ConfigHairSize Add(ConfigHairSize item);
        void Remove(ConfigHairSize item);
        ConfigHairSize Get(int id);
        IList<ConfigHairSize> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
