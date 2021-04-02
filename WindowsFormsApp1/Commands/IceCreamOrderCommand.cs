using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IceCreamOrder : ICommand
    {
        Salesman salesman;

        String[] decoratorList;
        String iceCreamOrder;

        public IceCreamOrder(Salesman salesman, String iceCreamOrder, String[] decoratorList)
        {
            this.salesman = salesman;
            this.iceCreamOrder = iceCreamOrder;
            this.decoratorList = decoratorList;
        }

        public void Execute()
        {
            salesman.iceCreamType = iceCreamOrder;
            salesman.decoratorList = this.decoratorList;
            salesman.GetOrder("IceCream");
        }
    }
}
