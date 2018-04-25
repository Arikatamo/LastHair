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
    public class GenderProv : iGenderProv
    {
        private iGender control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connect.Connecter CheckConnect;

        public GenderProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }
        private void Conntect_Conne(EFContext context)
        {
            control = new GenderControl(context);
            CheckConnect?.Invoke();
        }
        public GenderS Add(GenderS item)
        {
            GenderS temp = control.GetAll().FirstOrDefault(x => x.Gender == item.Gender);
            if (temp == null)
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

        public GenderS Get(int id)
        {
            GenderS temp = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("Not Found Gender in DataBase");

            }
        }

        public IList<GenderS> GetAll()
        {
            IList<GenderS> all = control.GetAll();
            if (all != null)
            {
                return all;
            }
            else
            {
                throw new Exception("DataBase is Null");

            }
        }

        public void Remove(GenderS item)
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
