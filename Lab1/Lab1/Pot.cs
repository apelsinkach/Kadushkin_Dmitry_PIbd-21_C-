using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Pot
    {
        private Meat meat;

        private Oil oil;

        private Spices spices;

        private Lemon lemon;

        private bool marinadeReady = false;

        public bool OilIn { get { if (oil != null) return true; else return false; } }

        public bool MeatIn { get { if (meat != null) return true; else return false; } }

        public bool MarinadeReady { get { return marinadeReady; } }

        public bool ReadyToCook { get { return !Check(); } }
   
        public void AddOil(Oil oil)
        {
            this.oil = oil;
        }

        public void CreateMarinade(Spices spices, Lemon lemon)
        {
            if (!marinadeReady && oil != null)
            {        
                this.spices = spices;
                this.lemon = lemon;
                marinadeReady = true;
            }
        }
        public void addMeat(Meat meat)
        {
            if (this.meat == null)
            {
                this.meat = meat;
            }
        }

        public bool Check()
        {
            if (meat.Has_marinade) return false;
            return true;
        }
        public void GetMarinade()
        {
            if (!Check())
            {
                return;
            }
            if (marinadeReady)
            {
                meat.Marinade();
            }
        }
        public Meat GetMeat()
        {
            return meat;
        }
    }
}
