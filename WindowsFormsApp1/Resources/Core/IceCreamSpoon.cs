using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class IceCreamSpoon : IResourceObserver
    {
        private Salesman salesman;
        public delegate void ResourceLowHandler(IResourceObserver o, string s);
        public event ResourceLowHandler ResourceLowEvent;

        public IceCreamSpoon(Salesman salesman)
        {
            this.salesman = salesman;
        }

        public void Update()
        {
            /* try with events
            if (ResourceLowEvent != null && salesman.spoons < 5)
            {
                ResourceLowEvent.Invoke(this, "Attention !!! " + this.GetType().Name + " is running low.");
            }
            */
            if (salesman.spoons < 5)
            {
                MessageBox.Show("Attention " + this.GetType().Name + " is running low. Please restock!");
            }
        }
    }
}
