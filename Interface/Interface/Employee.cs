using System;

namespace Interface
{
    internal class Employee : Iperson 
    {
        public void work()
        {
            Console.WriteLine("working");
        }
    }
}
