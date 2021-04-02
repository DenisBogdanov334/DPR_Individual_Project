using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IceCreamFactory
    {
        public AbstractIceCream MakeIceCream(String iceCreamType)
        {
            if (iceCreamType.Equals(null))
            {
                return null;
            }
            else if (iceCreamType.Equals("Chocolate"))
            {
                return new ChocolateIceCream();
            }
            else if (iceCreamType.Equals("Vanilla"))
            {
                return new VanillaIceCream();
            }
            else if (iceCreamType.Equals("Cotton Candy"))
            {
                return new CottonCandyIceCream();
            }
            return null;
        }
    }
}
