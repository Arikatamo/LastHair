using HairProvider.InterfaceProvider;
using HairsClientLib;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Controller;
namespace HairProvider.Provider
{
    public class PatientStatProv : iPatientStatusProv
    {
        private iPatientStatus control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connect.Connecter CheckConnect;

        public PatientStatProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }

        private void Conntect_Conne(EFContext context)
        {
            control = new StatusPatientController(context);
            CheckConnect?.Invoke();
        }



        public StatusesForPatient Add(StatusesForPatient item)
        {
            StatusesForPatient temp = control.GetAll().FirstOrDefault(x => x.Status == item.Status);
            if (temp!= null)
            {
                temp = control.Add(temp);
                control.SaveChanges();
                return temp;
            }
            else
            {
                throw new Exception("This Status alredy in base");
            }

        }

        public void Dispose()
        {
            control.Dispose();
        }

        public StatusesForPatient Get(int id,string status)
        {
            StatusesForPatient temp = control.GetAll().FirstOrDefault(x => x.Id == id || x.Status == status);
            if (temp != null)
            {
                return temp;

            }
            else
            {
                throw new Exception("Not Found Status in DataBase");

            }
        }

        public IList<StatusesForPatient> GetAll()
        {
            IList<StatusesForPatient> all = control.GetAll();
            if (all != null)
            {
                return all;
            }
            else
            {
                throw new Exception("DataBase is Null");

            }
        }
        /// <summary>
        ///  First Get from db then use Delete
        /// </summary>
        /// <param name="item"></param>
        public void Remove(StatusesForPatient item)
        {
            if (item != null)
            {
                control.Remove(item);
            }
            else
            {
                throw new Exception("This item not found in DataBase");
            }
        }
    }
}
