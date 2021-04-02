using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IceTea : IBeverage
    {
        public string GetDescription()
        {
            return "You have selected ice tea.";
        }

        public double GetPrice()
        {
            return 2.80;
        }
    }
}
