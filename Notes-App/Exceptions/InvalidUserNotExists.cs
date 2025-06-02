using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Exceptions
{
    public class InvalidUserNotExists:Exception
    {
        public InvalidUserNotExists(string message) : base(message) { }
    }
}
