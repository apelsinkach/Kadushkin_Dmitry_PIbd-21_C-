using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class DepoIndexOutOfRangeException:Exception
    {
        public DepoIndexOutOfRangeException():base("В депо нет поезда по такому месту") { }
    }
}
