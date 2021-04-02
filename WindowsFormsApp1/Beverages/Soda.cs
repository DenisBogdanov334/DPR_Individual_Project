using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Soda : IBeverage
    {
        public string GetDescription()
        {
            return "You have selected a soda.";
        }

        public double GetPrice()
        {
            return 3.50;
        }
    }
}
