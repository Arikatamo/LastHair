using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HairProvider.Provider.Connect;

namespace HairProvider.InterfaceProvider
{
   public interface iFieldVariantsProv
    {
        FieldVariants Add(FieldVariants item);
        void Remove(FieldVariants item);
        FieldVariants Get(int id);
        IList<FieldVariants> GetAll();
        event Connecter CheckConnect;
        void Dispose();
    }
}
