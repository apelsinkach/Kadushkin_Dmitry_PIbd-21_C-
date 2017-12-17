using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Meat
    {
        private int has_ready = 0;

        private int marinade = 0;

        private int has_cleaned = 0;

        private int dirty = 10;

        public bool Has_ready { get { if (has_ready >= 10) return true; else return false; } }

        public bool Has_marinade { get { if (marinade >= 10) return true; else return false; } }

        public int Has_cleaned { set { if (value > -1 && value < 11) has_cleaned = value; } get { return has_cleaned; } }

        public int Dirty { set { if (value > -1 && value < 11) dirty = value; } get { return dirty; } }

        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready++;
            }
        }
        public void Marinade()
        {
            if (marinade < 10)
            {
                marinade++;
            }
        }
    }
}
