using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Salesman : AbstractSalesman
    {
        public delegate void ResourceLowHandler(IResourceObserver o, string s);
        public event ResourceLowHandler ResourceLowEvent;
        //Core
        public int cones = 2;
        public int cups = 2;
        public int spoons = 2;
        // Decorators
        public int sprinkles = 2;
        public int kiwiSyrup = 2;
        public int caramelSyrup = 2;


        public String iceCreamType = "";
        public String beverageType = "";
        public String[] decoratorList = null;
        public AbstractIceCream icecream;
        public IBeverage beverage;

        public Salesman()
        {
            Attach(new IceCreamCone(this));
            Attach(new IceCreamCup(this));
            Attach(new IceCreamSpoon(this));
            Attach(new SprinklesDecorator(this));
            Attach(new KiwiSyrupDecorator(this));
            Attach(new CaramelSyrupDecorator(this));
        }

        public void GetOrder(String factoryType)
        {
            if (factoryType.Equals("IceCream", StringComparison.InvariantCultureIgnoreCase))
            {
                IceCreamFactory iceFactory = new IceCreamFactory();
                icecream = iceFactory.MakeIceCream(iceCreamType);
                icecream = Decorate(decoratorList);
            }
            else if (factoryType.Equals("Beverage", StringComparison.InvariantCultureIgnoreCase))
            {
                BeverageFactory drinkFactory = new BeverageFactory();
                beverage = drinkFactory.MakeBeverage(beverageType);
            }
        }
        
        public AbstractIceCream Decorate(String[] decoratorList)
        {
            for (int i = 0; i < decoratorList.Length; i++)
            {
                String decorator = (String) decoratorList[i];
                if (decorator.Equals("Caramel Syrup"))
                {
                    icecream = new CaramelSyrupDecorator(icecream);
                }
                else if (decorator.Equals("Kiwi Syrup"))
                {
                    icecream = new KiwiSyrupDecorator(icecream);
                }
                else if (decorator.Equals("Sprinkles"))
                {
                    icecream = new SprinklesDecorator(icecream);
                }
            }
            return icecream;
        }

        public async void PreparingOrder()
        {
            string message = "Your order is getting prepared!";
            await Task.Delay(2000);
            MessageBox.Show(message);
        }

        public async void CompletedOrder()
        {
            string message = "Your order is ready!";
            await Task.Delay(4500);
            MessageBox.Show(message);
            NotifyAllObservers();
        }

        public string GiveToCustomer()
        {
            return "This is your order. Enjoy and have a nice day!";
        }
    }
}
