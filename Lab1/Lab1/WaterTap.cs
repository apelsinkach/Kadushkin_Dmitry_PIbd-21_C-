using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class WaterTap
    {
        public bool State;

        public void WashingMeat(Meat m)
        {
            if (State)
            {
                m.Dirty = 0;
            }
        }
        public void WashingLemon(Lemon l)
        {
            if (State)
            {
                l.Dirty = 0;
            }
        }
    }
}
