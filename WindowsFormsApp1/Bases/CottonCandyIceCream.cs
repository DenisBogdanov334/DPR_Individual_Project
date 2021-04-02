using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CottonCandyIceCream : AbstractIceCream, IIceCream
    {
        public CottonCandyIceCream()
        {
        }

        public CottonCandyIceCream(IIceCream icecream) : base(icecream)
        { }

        public override string GetDescription()
        {
            return "You have selected cotton candy ice cream.";
        }

        public override double GetPrice()
        {
            return 4.20;
        }
    }
}
