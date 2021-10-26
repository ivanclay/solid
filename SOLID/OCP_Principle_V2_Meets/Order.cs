using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle_V2_Meets
{
    class Order
    {
        public virtual double OrderDiscount(double value)
        {
            return value;
        }
    }
}
