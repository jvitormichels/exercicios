using System;
using System.Globalization;

namespace produtor_Polimorfismo_.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
