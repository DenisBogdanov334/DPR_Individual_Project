using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class IcyRainbowSelectionMonitor
    {
        //Command
        ICommand command;

        public void TakeOrder(ICommand c)
        {
            command = c;
            command.Execute();
        }

        public string OrderReadyToBeTaken()
        {
            return "The machine has processed your order.";
        }

        public string AskForPatience()
        {
            return "Please, be patient!";
        }
    }
}
