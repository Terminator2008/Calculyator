using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float x, y;
        string count;
        bool znak = true;

        private void button17_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }
         private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak==false)
            {
                textBox1.Text=textBox1.Text.Replace("-", "");
                znak = true;
            }
            
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = "+";
            label1.Text = x.ToString() + "+";
            znak = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = "-";
            label1.Text = x.ToString() + "-";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = "*";
            label1.Text = x.ToString() + "*";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = "/";
            label1.Text = x.ToString() + "/";
            znak = true;
        }

   

        private void button19_Click(object sender, EventArgs e)
        {
            y = float.Parse(textBox1.Text);
            res = MathClass.Calculate(x, y, count);
            textBox1.Text = res.ToString();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void button21_Click_1(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = "tan";
            label1.Text = "tan" +  x.ToString();
            znak = true;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = "log";
            label1.Text = "log" + x.ToString();
            znak = true;
        }

      

       

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        
    }
}
