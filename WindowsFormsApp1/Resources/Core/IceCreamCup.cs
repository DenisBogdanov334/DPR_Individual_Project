using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class IceCreamCup : IResourceObserver
    {
        
        private Salesman salesman;
        public delegate void ResourceLowHandler(IResourceObserver o, string s);
        public event ResourceLowHandler ResourceLowEvent;

        public IceCreamCup(Salesman salesman)
        {
            this.salesman = salesman;
        }

        public void Update()
        {
            /*try with events
            if (ResourceLowEvent != null && salesman.cups < 5)
            {
                ResourceLowEvent.Invoke(this, "Attention !!! " + this.GetType().Name + " is running low.");
            }
            */
            if (this.salesman.cups < 5)
            {
                MessageBox.Show("Attention " + this.GetType().Name + " is running low. Please restock!");
            }
        }
    }
}
