using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Customer
    {
        public string Name => "Cedric";
        public int Age => 25;

        public int GetOdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // throw new ArgumentNullException("name");
                throw new ArgumentException("Add a Name");
            }
            return 100;
        }
    }

    public class LoyaltyPoint : Customer
    {
        public int Discount { get; set; }

        public LoyaltyPoint()
        {
            Discount = 10;
        }

    }
}
