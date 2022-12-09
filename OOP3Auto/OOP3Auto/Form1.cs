using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            button2.Enabled = false;
            button3.Enabled = false;
            this.BackColor = Color.Gold;
            
        }

        Auto auto;

        private void button1_Click(object sender, EventArgs e)
        {
            auto = new Auto(textBox1.Text, (float)numericUpDown1.Value);
            button2.Enabled = true;
            button3.Enabled = true;
            label6.Text = auto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Rozjezd();
            label6.Text = auto.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.Zastav((int)numericUpDown2.Value);
            label6.Text = auto.ToString();
        }

        

    }
}
