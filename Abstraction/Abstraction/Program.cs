using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user u = new user();
            //u.purchase();

            Amazon A = new user();//Parent class refrence child class object this is also possible
            A.purchase();

        }
    }
}
