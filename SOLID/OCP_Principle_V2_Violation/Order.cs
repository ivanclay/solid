using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle_V2_Violation
{
    public enum ConsumerType
    {
        Common,
        Associate,
        Special
    };

    class Order
    {
        public double OrderDiscount(double value, ConsumerType consumerType)
        {
            double finalValue;

            if (consumerType == ConsumerType.Special)
            {
                finalValue = value - 50;
            }
            else if (consumerType == ConsumerType.Associate)
            {
                finalValue = value - 10;
            }
            else
            {
                finalValue = value;
            }
            return finalValue;
        }
    }
}
