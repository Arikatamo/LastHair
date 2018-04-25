using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
   public  interface iResearchTypeProv
    {
        ResearchType Add(ResearchType item);
        void Remove(ResearchType item);
        ResearchType Get(int id);
        IList<ResearchType> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
