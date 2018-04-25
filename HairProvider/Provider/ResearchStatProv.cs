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
    public class ResearchStatProv : iResearchStatProv
    {
        private iResearchStatus control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connect.Connecter CheckConnect;
        public ResearchStatProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }
        private void Conntect_Conne(EFContext context)
        {
            control = new ResearchStatusControl(context);
            CheckConnect?.Invoke();
        }
        public ResearStatus Add(ResearStatus item)
        {
            ResearStatus temp = control.GetAll().FirstOrDefault(x => x.Researches == item.Researches);
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

        public ResearStatus Get(int id)
        {
            ResearStatus temp = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("Not Found Gender in DataBase");

            }
        }

        public IList<ResearStatus> GetAll()
        {
            IList<ResearStatus> all = control.GetAll();
            if (all != null)
            {
                return all;
            }
            else
            {
                throw new Exception("DataBase is Null");

            }
        }

        public void Remove(ResearStatus item)
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
