using System;
using System.Collections.Generic;
using System.Text;

namespace funcionarios__com_polimorfismo_.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return Hours * ValuePerHour + (AdditionalCharge * 1.1);
        }
    }
}
