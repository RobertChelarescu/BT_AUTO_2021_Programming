using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class BuildingException:Exception
    {
        string myCustomMessage;
        public BuildingException(string Message)
        {
            this.myCustomMessage = "There is an exception!!! " + Message;
        }

        public BuildingException() : base("There is an exception!!! ")  
        {

        }

        public override string ToString()
        {
            return myCustomMessage + base.ToString();
        }
    }
}
