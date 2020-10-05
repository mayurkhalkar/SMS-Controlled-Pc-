using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Controlled_PC
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }
        Timer t;
        private void StartPage_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 4000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
        }
        void t_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
//// FF8C00