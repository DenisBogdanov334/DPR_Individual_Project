using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HotTea : IBeverage
    {
        public string GetDescription()
        {
            return "You have selected hot tea.";
        }

        public double GetPrice()
        {
            return 4.50;
        }
    }
}
