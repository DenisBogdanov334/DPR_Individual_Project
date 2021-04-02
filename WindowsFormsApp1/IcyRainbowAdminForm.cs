using System;
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
    public partial class IcyRainbowAdminForm : Form
    {
        public IcyRainbowAdminForm()
        {
            InitializeComponent();
        }

        public void InformAboutLowResources(IResourceObserver o, string info)
        {
            this.listBox1.Items.Add(o.GetType() + " is running low. Please restock!");
        }
    }
}
