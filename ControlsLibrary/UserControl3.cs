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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            Contracts();
        }

        public void Refresh(int tab)
        {
            JustClearIiiit();
            PutTab(tab);
        }
        
        private void JustClearIiiit()
        {
            foreach(Control c in this.Controls)
                Controls.Remove(c);
        }

        private void Contracts()
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Size = new Size(500, 300);
            this.Controls.Add(dataGrid);
        }

        private void PutTab(int tab)
        {
            if (tab!=1)
            {
                JustClearIiiit();
                Label label = new Label();
                label.Text = tab.ToString();
                label.Font = new Font(FontFamily.GenericSerif, 48);
                label.Location = new Point(50, 50);
                this.Controls.Add(label);
            }
            else
            {
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
