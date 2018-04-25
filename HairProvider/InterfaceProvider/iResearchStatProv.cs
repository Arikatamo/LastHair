using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
    public interface iResearchStatProv
    {
        ResearStatus Add(ResearStatus item);
        void Remove(ResearStatus item);
        ResearStatus Get(int id);
        IList<ResearStatus> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
