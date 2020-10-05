using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SMS_Controlled_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            timer1.Stop();

        }

        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            projectInfoUC1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aboutUSUC1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            helpUC1.BringToFront();
        }
    }
}




/// size 686, 284