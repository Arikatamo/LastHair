using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
   public  interface iGenderProv
    {
        GenderS Add(GenderS item);
        void Remove(GenderS item);
        GenderS Get(int id);
        IList<GenderS> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
