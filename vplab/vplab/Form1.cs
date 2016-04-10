using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vplab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Text = "Hello form up";
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text = "Hello form key press";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "mouse hover";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "mouse leave";
        }
    }
}
