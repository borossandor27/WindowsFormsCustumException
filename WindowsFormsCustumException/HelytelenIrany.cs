using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCustumException
{
    internal class HelytelenIrany : Exception
    {
        public HelytelenIrany(string message) : base(message)
        {

        }
    }
}
