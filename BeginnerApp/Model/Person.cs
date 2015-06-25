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

        private String message;

        public String Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        //Backing Private Field
        private String name;

        //Public Property (Mutators)
        public String personName { get; set; }

        public string sayHello()
        {
           return "Saying Hello....";
        }
    }
}
