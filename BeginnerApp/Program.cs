using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.IO;

namespace BeginnerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.personName = "Ted";
            Console.WriteLine("Name: {0}", p.personName);
            p.Message = "Hey Everyone!";
            Console.WriteLine("Message: {0}", p.Message);
            Console.WriteLine(p.sayHello());
            Console.ReadKey();

            //FILE IO


            //POINTERS (Just for show, must be compiled with /unsafe flag)
            /*
            unsafe
            {
                int i = 5;
                int* p; //declare ptr p
                p = &i; //get mem addr of i
                *p = 10; //assign value pointed to by p to be 10

            }
            */
            


        }
    }
}
