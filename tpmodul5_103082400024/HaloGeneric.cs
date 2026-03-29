using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul5_103082400024
{
    public class HaloGeneric
    {
        public void sapaUse<T>(T X)
        {
            Console.WriteLine($"Halo user {X}");
        }
    }

}
