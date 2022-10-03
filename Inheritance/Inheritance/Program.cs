using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Batsman b = new Batsman();  
            b.play();

            Console.WriteLine("Team: "+b.team);
            Console.WriteLine("Batsman age is: "+b.age);
        }
    }
}
