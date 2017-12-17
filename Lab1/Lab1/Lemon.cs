using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Lemon
    {
        private int dirty = 10;
        private int has_cleaned = 0;

        public int Dirty
        {
            set { if (value > -1 && value < 11) { dirty = value; } }
            get { return dirty; }
        }
        
        public int Has_cleaned
        {
            set { if (value > -1 && value < 11) { has_cleaned = value; } }
            get { return has_cleaned; }
        }
    }
}
