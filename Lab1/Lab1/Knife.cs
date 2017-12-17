using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Knife
    {
        public void CuttingMeat(Meat m)
        {
            if (m.Has_cleaned == 0)
            {
                m.Has_cleaned = 10;
            }
        }
        public void CuttingLemon(Lemon l)
        {
            if (l.Has_cleaned == 0)
            {
                l.Has_cleaned = 10;
            }
        }
    }
}
