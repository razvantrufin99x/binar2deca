using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace binar2deca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bin2deca(TextBox i, TextBox o)
        {
            int lenA = i.Text.Length;
            int k = 0;
            Int64 rez=0;

            for (int j = lenA; j >=0; j--)
            {
               
                i.Select(j,1);
                if (i.SelectedText == "1")
                {
                    rez += 1 * Convert.ToInt64(Math.Pow(2, (k)));
                }
                k++;
            }

            o.Text = rez.ToString();
          
        }

        public void dec2bin(Int64 x, TextBox tout)
        {
            while (x > 0)
            {
                tout.Text = x % 2 + tout.Text;
                x = x / 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bin2deca(textBox1, textBox2);

            textBox3.Text = "";
            try
            {
                dec2bin(Int64.Parse(textBox2.Text), textBox3);
            }
            catch { }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox3.Text)
            {
                Text = "Corect !";

            }
            else
            {
                Text = "Error !!!";
            }
        }
    }
}
