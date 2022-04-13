using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        Tech.MultiTasking.Entities.Pipe pipe = new Tech.MultiTasking.Entities.Pipe();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Int32.Parse(textBox1.Text);

             pipe.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox2.Text = random.Next(1, 1999).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pipe.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pipe.RunAndDelete();
        }
    }
}
