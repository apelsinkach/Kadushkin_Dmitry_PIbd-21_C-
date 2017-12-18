using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class DepoAlreadyHaveException : Exception
    {
        public DepoAlreadyHaveException() : base("Такой поезд уже существует!") { }
    }
}
