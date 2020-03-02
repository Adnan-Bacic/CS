using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections; //added

namespace collections
{
    public class LimitedArrayList : ArrayList
    {
        //new add emthod, limited size to 2
        public override int Add(object value)
        {
            if(Count < 2)
            {
                return base.Add(value);
            }
            else
            {
                return -1;
            }
        }
    }
}