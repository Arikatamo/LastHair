using HairProvider.InterfaceProvider;
using HairsClientLib;
using HairsClientLib.Controller;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.Provider
{
    public class FieldVariantsProv : iFieldVariantsProv
    {
        private iFieldVariant control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connect.Connecter CheckConnect;

        public FieldVariantsProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }
        private void Conntect_Conne(EFContext context)
        {
            control = new FieldVariantControl(context);
            CheckConnect?.Invoke();
        }
        public FieldVariants Add(FieldVariants item)
        {
            FieldVariants temp = null;
            if (item != null)
            {
                temp = control.Add(item);
                control.SaveChanges();
                return temp;
            }
            else
            {
                throw new Exception("This Gender alredy in base");
            }
        }


        public void Dispose()
        {
            control.Dispose();
        }

        public FieldVariants Get(int id)
        {
            FieldVariants temp = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("Not Found Gender in DataBase");

            }
        }

        public IList<FieldVariants> GetAll()
        {
            IList<FieldVariants> all = control.GetAll();
            if (all != null)
            {
                return all;
            }
            else
            {
                throw new Exception("DataBase is Null");

            }
        }

        public void Remove(FieldVariants item)
        {
            if (item != null)
            {
                control.Remove(item);
                control.SaveChanges();
            }
            else
            {
                throw new Exception("This item not found in DataBase");
            }
        }
    }
}
