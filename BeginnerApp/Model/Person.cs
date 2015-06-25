using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Model
{
    class Person : IEmployee
    {

        //Backing field for property
        private String message;

        //implements IEmployee so must have property
        public String Message
        {
            get
            {
                Console.WriteLine("Returning Message!");
                return this.message;
            }
            set
            {
<<<<<<< HEAD
                Console.Write("Setting Message!");
=======
                Console.WriteLine("Setting Message!");
>>>>>>> sideBranch
                this.message = value;
            }
        }

        //Backing Private Field
        private String name;

        //Public Property (Mutators)
        public String personName { get; set; }

        //implementing interface method
        public string sayHello()
        {
           return "Saying Hello....";
        }
    }
}
