using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ChocolateIceCream : AbstractIceCream, IIceCream
    {
        public ChocolateIceCream()
        {

        }
        public ChocolateIceCream(Salesman salesman) : base(salesman) { }

        public override string GetDescription()
        {
            return "You have selected chocolate ice cream.";
        }

        public override double GetPrice()
        {
            return 3.25;
        }
    }
}
