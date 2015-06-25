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
            /*
            Person p = new Person();
            p.personName = "Ted";
            Console.WriteLine("Name: {0}", p.personName);
            p.Message = "Hey Everyone!";
            Console.WriteLine("Message: {0}", p.Message);
            Console.WriteLine(p.sayHello());
            Console.ReadKey();
            */

            //FILE IO
            //String winDir = System.Environment.GetEnvironmentVariable("windir");
            //Console.WriteLine(winDir);
            //  Console.ReadKey();

            FileInfo file;
            StreamReader sr = null;

            try
            {
               // FileInfo newFile = new FileInfo(System.Environment.);
               // Console.WriteLine(newFile);
                file = new FileInfo("C:\\hello.txt");
                Console.WriteLine(file);

                string[] drives = Directory.GetFiles("C:\\");
                for (int i = 0; i < drives.Length; i++)
                {
                    Console.WriteLine(drives[i]);
                }

                if (file.Exists)
                {
                    sr = new StreamReader(file.FullName);
                    String line = sr.ReadLine();
                    while(line != null && line.Length > 0)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                } else
                {
                    Console.WriteLine("File Doesn't Exist");
                }
               


                Console.ReadKey();



                //  StreamReader reader = new StreamReader("C:\\hello.txt");
                // Console.WriteLine(reader);
                //Console.ReadKey();
                //if (reader != null)
                //{

                //}

            } catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            } finally
            { 
                if (sr != null)
                {
                    sr.Close();
                }
                
            }

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
