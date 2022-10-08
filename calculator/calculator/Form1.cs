using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class form1 : Form
    {
        double result = 0;
        String opt = "";
        Boolean isopt = false;
        public form1()
        {
            InitializeComponent();
        }

        private void button_clock(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (label1.Text == "0" || isopt == true)
            {
                label1.Text = btn.Text;
            }
            else
            {
                if (btn.Text == ".")
                {
                    if (!label1.Text.Contains("."))
                    {
                        label1.Text = label1.Text + btn.Text;
                        
                    }
                }
                else
                {
                    label1.Text = label1.Text + btn.Text;
                }
                isopt = false;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            opt = btn.Text;

            label2.Text = label1.Text +" "+btn.Text;
            result = double.Parse(label1.Text);
            isopt = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            result = 0;
            label2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (opt == "+")
            {
                label1.Text = (result + double.Parse(label1.Text)).ToString();
            }
            else if (opt == "-")
            {
                label1.Text = (result - double.Parse(label1.Text)).ToString();
            }
            else if (opt == "*")
            {
                label1.Text = (result * double.Parse(label1.Text)).ToString();
            }
            else if (opt == "/")
            {
                label1.Text = (result / double.Parse(label1.Text)).ToString();
            }
        }

        private void back_click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
    }

