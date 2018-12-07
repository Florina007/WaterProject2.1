using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibrary
{
    public partial class UserControl1 : UserControl
    {
        String name; 
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControlI_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello, " + name + "!"; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel;
            switch(comboBox1.SelectedIndex)
            {
                case 0: sel = 0; return;
                case 1: return;
                case 2: return;
                case 3: return;
                default: return;
            }
        }
    }
}
