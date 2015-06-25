using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BeginnerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.personName = "Ted";
            Console.WriteLine("Name: {0}", p.personName);
            Console.ReadKey();
        }
    }
}
