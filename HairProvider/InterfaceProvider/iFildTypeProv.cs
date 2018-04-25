using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
    public interface iFildTypeProv
    {
        FieldType Add(FieldType item);
        void Remove(FieldType item);
        FieldType Get(int id);
        IList<FieldType> GetAll();

        event Connecter CheckConnect;
        void Dispose();
    }
}
