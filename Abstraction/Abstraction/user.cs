using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class user:Amazon
    {
        public override void purchase()
        {
            Console.WriteLine("purchasing mobile");
        }

    }
}
