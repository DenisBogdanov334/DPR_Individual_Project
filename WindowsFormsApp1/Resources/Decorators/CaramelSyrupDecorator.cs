using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CaramelSyrupDecorator : AbstractIceCream, IResourceObserver
    {
        public CaramelSyrupDecorator(Salesman salesman) : base(salesman) { }
        public CaramelSyrupDecorator(IIceCream icecream) : base(icecream) { }

        public delegate void ResourceLowHandler(IResourceObserver o, string s);
        public event ResourceLowHandler ResourceLowEvent;

        public override string GetDescription()
        {
            return icecream.GetDescription() + "You added caramel syrup to your icecream;";
        }

        public override double GetPrice()
        {
            return icecream.GetPrice() + 1.00;
        }

        public void Update()
        {
            /*try with events
            if (ResourceLowEvent != null && salesman.caramelSyrup < 5)
            {
                ResourceLowEvent.Invoke(this, "Attention !!! " + this.GetType().Name + " is running low.");
            }
            */

            if (salesman.caramelSyrup < 5)
            {
                MessageBox.Show("Attention " + this.GetType().Name + " is running low. Please restock!");
            }
        }
    }
}
