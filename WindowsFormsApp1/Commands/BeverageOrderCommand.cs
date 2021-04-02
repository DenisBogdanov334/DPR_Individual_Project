using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BeverageOrder : ICommand
    {
        Salesman salesman;
        String beverageOrder;

        public BeverageOrder(Salesman salesman, String beverageOrder)
        {
            this.salesman = salesman;
            this.beverageOrder = beverageOrder;
        }

        public void Execute()
        {
            salesman.beverageType = beverageOrder;
            salesman.GetOrder("Beverage");
        }
    }
}
