using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SprinklesDecorator : AbstractIceCream, IResourceObserver
    {
        public delegate void ResourceLowHandler(IResourceObserver o, string s);
        public event ResourceLowHandler ResourceLowEvent;

        public SprinklesDecorator(Salesman salesman) : base(salesman) { }
        public SprinklesDecorator(IIceCream icecream) : base(icecream) { }

        public override string GetDescription()
        {
            return icecream.GetDescription() + "You added sprinkles to your icecream;";
        }

        public override double GetPrice()
        {
            return icecream.GetPrice() + 0.40;
        }

        public void Update()
        {
            /* try with events
            if (ResourceLowEvent != null && salesman.sprikles < 5)
            {
                ResourceLowEvent.Invoke(this, "Attention !!! " + this.GetType().Name + " is running low.");
            }
            */
            if (salesman.sprinkles < 5)
            {
                MessageBox.Show("Attention " + this.GetType().Name + " is running low. Please restock!");
            }
        }
    }
}
