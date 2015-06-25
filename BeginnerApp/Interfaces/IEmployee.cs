using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IEmployee
    {
    
        //Forces Implementer to have property Message
        String Message { get; set; }

        String sayHello();

    }
}
