using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle_V2_Meets.Discounts
{
    class AssociateConsumerDiscount : Order
    {
        public override double OrderDiscount(double value)
        {
            return value - 10;
        }
    }
}
