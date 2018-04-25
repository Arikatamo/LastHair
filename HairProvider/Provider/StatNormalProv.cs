﻿using HairProvider.InterfaceProvider;
using HairsClientLib;
using HairsClientLib.Interfaces;
using HairsClientLib.Controller;

using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.Provider
{
    public class StatNormalProv : iStatNormalProv
    {
        private iConfigStaticNorm control;
        private AsyncConnection conntect = new AsyncConnection();
        public event Connect.Connecter CheckConnect;

        public StatNormalProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }
        private void Conntect_Conne(EFContext context)
        {
            control = new ConfigStaticNormControl(context);
            CheckConnect?.Invoke();
        }
        public ConfigStaticNormales Add(ConfigStaticNormales item)
        {
            ConfigStaticNormales temp = new ConfigStaticNormales();
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

        public ConfigStaticNormales Get(int id)
        {
            ConfigStaticNormales temp = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("Not Found Gender in DataBase");

            }
        }

        public IList<ConfigStaticNormales> GetAll()
        {
            IList<ConfigStaticNormales> all = control.GetAll();
            if (all != null)
            {
                return all;
            }
            else
            {
                throw new Exception("DataBase is Null");

            }
        }

        public void Remove(ConfigStaticNormales item)
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
