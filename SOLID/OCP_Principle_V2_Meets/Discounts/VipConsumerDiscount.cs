using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle_V2_Meets.Discounts
{
    class VipConsumerDiscount : Order
    {
        public override double OrderDiscount(double value)
        {
            return value - 100;
        }
    }
}
