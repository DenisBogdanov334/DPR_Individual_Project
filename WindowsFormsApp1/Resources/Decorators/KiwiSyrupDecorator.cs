using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class KiwiSyrupDecorator : AbstractIceCream, IResourceObserver
    {
        public delegate string ResourceLowHandler(IResourceObserver o, string s);
        public event ResourceLowHandler ResourceLowEvent;

        public KiwiSyrupDecorator(Salesman salesman) : base(salesman) { }
        public KiwiSyrupDecorator(IIceCream icecream) : base(icecream) { }

        public override string GetDescription()
        {
            return icecream.GetDescription() + "You added kiwi syrup to your icecream;";
        }

        public override double GetPrice()
        {
            return icecream.GetPrice() + 0.80;
        }

        public void Update()
        {
            /*try with events
            if (ResourceLowEvent != null && salesman.kiwiSyrup < 5)
            {
                ResourceLowEvent.Invoke(this, "Attention !!! " + this.GetType().Name + " is running low.");
            }
            */
            if (this.salesman.kiwiSyrup < 5)
            {
                MessageBox.Show("Attention " + this.GetType().Name + " is running low. Please restock!");
            }
        }
    }
}
