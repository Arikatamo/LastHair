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
using static HairProvider.Provider.Connect;

namespace HairProvider.Provider
{
    public class ResearchTypeProv : iResearchTypeProv
    {
        private iResearchType control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connecter CheckConnect;
        public ResearchTypeProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }

        private void Conntect_Conne(EFContext context)
        {
            control = new ResearchTypeControl(context);
            CheckConnect?.Invoke();
        }

        public ResearchType Add(ResearchType item)
        {
            ResearchType temp = control.GetAll().FirstOrDefault(x => x.Name == item.Name);
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

        public ResearchType Get(int id)
        {
            ResearchType temp = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("Not Found Gender in DataBase");

            }
        }

        public IList<ResearchType> GetAll()
        {
            IList<ResearchType> all = control.GetAll();
            if (all != null)
            {
                return all;
            }
            else
            {
                throw new Exception("DataBase is Null");

            }
        }

        public void Remove(ResearchType item)
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
