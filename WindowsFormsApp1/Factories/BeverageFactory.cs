using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BeverageFactory
    {
        public IBeverage MakeBeverage(String beverageType)
        {
            if (beverageType.Equals(null))
            {
                return null;
            }
            else if (beverageType.Equals("Hot Tea"))
            {
                return new HotTea();
            }
            else if (beverageType.Equals("Ice Tea"))
            {
                return new IceTea();
            }
            else if (beverageType.Equals("Soda"))
            {
                return new Soda();
            }
            return null;
        }
    }
}
