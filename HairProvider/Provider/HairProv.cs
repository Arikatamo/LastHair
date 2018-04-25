using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairProvider.InterfaceProvider;
using HairsClientLib.Lib;
using HairsClientLib;
using HairsClientLib.Interfaces;
using HairsClientLib.Controller;
using static HairProvider.Provider.Connect;

namespace HairProvider.Provider
{
   public class HairProv : iHairProv
    {
        private iHair control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connecter CheckConnect;
        public HairProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }

        private void Conntect_Conne(EFContext context)
        {
            control = new HairControl(context);
            CheckConnect?.Invoke();
        }

        public Hair Add(Hair hairIn)
        {
            Hair temp = control.Add(hairIn);
            control.SaveChanges();
            return temp;
        }

        public Hair Get(int id)
        {
            Hair hair = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (hair != null)
            {
                return hair;
            }
            else
            {
                throw new Exception("Not such id in Database");
            }
           
        }

        public IList<Hair> GetAll()
        {
            IList<Hair> hair = control.GetAll();
            if (hair!= null)
            {
                return hair;
            }
            else
            {
                throw new Exception("DataBase is Null");
            }
        }

        public void Remove(Hair item)
        {
            if (item != null)
            {
                control.Remove(item);
                control.SaveChanges();
            }
            else
            {
                throw new Exception("Item is Null");
            }
        }

        public void Dispose()
        {
            control.Dispose();
        }
    }
}
