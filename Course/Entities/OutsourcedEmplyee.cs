using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class OutsourcedEmplyee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmplyee()
        {

        }

        public OutsourcedEmplyee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }


    }
}
