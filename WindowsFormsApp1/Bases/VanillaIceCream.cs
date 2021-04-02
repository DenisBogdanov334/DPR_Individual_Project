using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class VanillaIceCream : AbstractIceCream, IIceCream
    {
        public VanillaIceCream()
        {

        }
        public VanillaIceCream(IIceCream icecream) : base(icecream)
        {}

        public override string GetDescription()
        {
            return "You have selected vanilla ice cream.";
        }

        public override double GetPrice()
        {
            return 2.90;
        }
    }
}
