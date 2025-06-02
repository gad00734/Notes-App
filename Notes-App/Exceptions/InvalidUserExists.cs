using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager
{
    public class InvalidUserExists:Exception
    {
      public InvalidUserExists(string message):base(message){ }
    }
}
