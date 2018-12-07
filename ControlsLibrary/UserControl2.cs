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
    public partial class UserControl2 : UserControl
    {
        public int openedTab { get; set; }
        public UserControl2()
        {
            InitializeComponent();
            this.AutoScroll = true;

            //ScrollBar

            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) => { this.VerticalScroll.Value = vScrollBar1.Value; };
            //this.Controls.Add(vScrollBar1);

            // Buttons

            Button button1 = new Button();
            button1.Location = new Point(0, 0);
            button1.Size = new Size(230, 100);
            this.Controls.Add(button1);
            button1.Text = "Contracts";
            button1.Click += (sender, e) => { openedTab = 1; };

            Button button2 = new Button();
            button2.Location = new Point(0, 100);
            button2.Size = new Size(230, 100);
            this.Controls.Add(button2);
            button2.Text = "Customer";
            button2.Click += (sender, e) => { openedTab = 2; };

            Button button3 = new Button();
            button3.Location = new Point(0, 200);
            button3.Size = new Size(230, 100);
            this.Controls.Add(button3);
            button3.Text = "Machines";
            button3.Click += (sender, e) => { openedTab = 3; };

            Button button4 = new Button();
            button4.Location = new Point(0, 300);
            button4.Size = new Size(230, 100);
            this.Controls.Add(button4);
            button4.Text = "Feedback";
            button4.Click += (sender, e) => { openedTab = 4; };

            Button button5 = new Button();
            button5.Location = new Point(0, 400);
            button5.Size = new Size(230, 100);
            this.Controls.Add(button5);
            button5.Text = "Service";
            button5.Click += (sender, e) => { openedTab = 5; };

            Button button6 = new Button();
            button6.Location = new Point(0, 500);
            button6.Size = new Size(230, 100);
            this.Controls.Add(button6);
            button6.Text = "Employees";
            button6.Click += (sender, e) => { openedTab = 6; };

        }

    }
}
