using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IcyRainbowForm : Form
    {
        IcyRainbowSelectionMonitor orderingMachine;
        Salesman salesman;
        IcyRainbowAdminForm icyRainbowAdminForm;
        String iceCreamType = null;
        String beverageType = null;
        private List<String> decoratorsIceCream = new List<string>();
        bool cupClicked = false;
        bool coneClicked = false;

        public IcyRainbowForm()
        {
            InitializeComponent();
            orderingMachine = new IcyRainbowSelectionMonitor();
            salesman = new Salesman();
            icyRainbowAdminForm = new IcyRainbowAdminForm();
            icyRainbowAdminForm.Show();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            // salesman.ResourceLowEvent += icyRainbowAdminForm.InformAboutLowResources;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button12.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button8.Enabled = false;
            button7.Enabled = false;
            listBox1.Items.Add("You have selected a cone");
            salesman.cones--;
            coneClicked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button8.Enabled = false;
            button7.Enabled = false;
            listBox1.Items.Add("You have selected a cup");
            salesman.cups--;
            cupClicked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button12.Enabled = true;
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            iceCreamType = button1.Text;
            listBox1.Items.Add($"You have selected {button1.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button12.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            iceCreamType = button2.Text;
            listBox1.Items.Add($"You have selected {button2.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button12.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            iceCreamType = button3.Text;
            listBox1.Items.Add($"You have selected {button3.Text}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            decoratorsIceCream.Add(button11.Text);

            listBox1.Items.Add($"You have selected {button11.Text}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            decoratorsIceCream.Add(button10.Text);

            listBox1.Items.Add($"You have selected {button10.Text}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            decoratorsIceCream.Add(button9.Text);

            listBox1.Items.Add($"You have selected {button9.Text}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            beverageType = button4.Text;
            listBox1.Items.Add($"You have selected {button4.Text}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            beverageType = button5.Text;
            listBox1.Items.Add($"You have selected {button5.Text}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            beverageType = button6.Text;
            listBox1.Items.Add($"You have selected {button6.Text}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (iceCreamType == null && cupClicked || iceCreamType == null && coneClicked)
            {
                MessageBox.Show("You have not selected any ice cream for your vessel.");
            }
            else if (beverageType == null && iceCreamType == null)
            {
                MessageBox.Show("You have not selected any item");
            }
            else if (beverageType == null)
            {

                String[] decoratorArr = new String[decoratorsIceCream.Capacity];
                decoratorArr = (String[])decoratorsIceCream.ToArray();
                IceCreamOrder iceCreamOrderNoDrink = new IceCreamOrder(salesman, iceCreamType, decoratorArr);
                orderingMachine.TakeOrder(iceCreamOrderNoDrink);
                listBox1.Items.Add(orderingMachine.OrderReadyToBeTaken());
                salesman.PreparingOrder();
                listBox1.Items.Add(orderingMachine.AskForPatience());
                DisableAllButtons();
                salesman.CompletedOrder();
                ShowPriceIceCream();
                ShowOrderIceCream();
                listBox1.Items.Add(salesman.GiveToCustomer());
            }
            else if (iceCreamType == null)
            {
                BeverageOrder beverageOrderNoIceCream = new BeverageOrder(salesman, beverageType);
                orderingMachine.TakeOrder(beverageOrderNoIceCream);
                listBox1.Items.Add(orderingMachine.OrderReadyToBeTaken());
                salesman.PreparingOrder();
                listBox1.Items.Add(orderingMachine.AskForPatience());
                DisableAllButtons();
                salesman.CompletedOrder();
                ShowPriceBeverage();
                ShowOrderBeverage();
                listBox1.Items.Add(salesman.GiveToCustomer());
            }
            else
            {
                String[] decoratorArr = new String[decoratorsIceCream.Capacity];
                decoratorArr = (String[])decoratorsIceCream.ToArray();
                BeverageOrder beverageOrder = new BeverageOrder(salesman, beverageType);
                orderingMachine.TakeOrder(beverageOrder);
                IceCreamOrder iceCreamOrder = new IceCreamOrder(salesman, iceCreamType, decoratorArr);
                orderingMachine.TakeOrder(iceCreamOrder);
                listBox1.Items.Add(orderingMachine.OrderReadyToBeTaken());
                salesman.PreparingOrder();
                listBox1.Items.Add(orderingMachine.AskForPatience());
                DisableAllButtons();
                salesman.CompletedOrder();
                ShowPriceIceCream();
                ShowOrderIceCream();
                ShowPriceBeverage();
                ShowOrderBeverage();
                ShowTotalPrice();
                listBox1.Items.Add(salesman.GiveToCustomer());
            }
        }

        public void DisableAllButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }

        public void ShowPriceIceCream()
        {
            listBox1.Items.Add("Price of icecream: " + salesman.icecream.GetPrice());
        }

        public void ShowOrderIceCream()
        {
            listBox1.Items.Add(salesman.icecream.GetDescription());
        }

        public void ShowPriceBeverage()
        {
            listBox1.Items.Add("Price of beverages: " + salesman.beverage.GetPrice());
        }

        public void ShowOrderBeverage()
        {
            listBox1.Items.Add(salesman.beverage.GetDescription());
        }

        public void ShowTotalPrice()
        {
            double total = salesman.icecream.GetPrice() + salesman.beverage.GetPrice();
            listBox1.Items.Add("Your total is: " + total);
        }
    }
}
