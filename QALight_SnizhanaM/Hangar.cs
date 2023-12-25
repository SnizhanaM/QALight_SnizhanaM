using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_SnizhanaM
{
    class Hangar
    {
        public void AddFlyingTransport(IFlyable flyable)
        {
            flyable.RegisterFlyingTransport();
       
        }
    }
}
