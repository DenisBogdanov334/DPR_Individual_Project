using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class AbstractIceCream : IIceCream
    {
        protected IIceCream icecream;
        protected Salesman salesman;

        public AbstractIceCream()
        {

        }

        protected AbstractIceCream(Salesman salesman)
        {
            this.salesman = salesman;
        }

        protected AbstractIceCream(IIceCream icecream)
        {
            this.icecream = icecream;
        }

        public virtual string GetDescription()
        {
            return null;
        }

        public virtual double GetPrice()
        {
            return 0;
        }
    }
}
