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
        double fnum, snum,res;
        String ops;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            String input = output.Text+btn_0.Text;
            output.Text = input;

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_1.Text;
            output.Text = input;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_2.Text;
            output.Text = input;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_3.Text;
            output.Text = input;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_4.Text;
            output.Text = input;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_5.Text;
            output.Text = input;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_6.Text;
            output.Text = input;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_7.Text;
            output.Text = input;
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            ops = "+";
            fnum = Convert.ToDouble(output.Text);
            output.Text = "";
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            ops = "-";
            fnum = Convert.ToDouble(output.Text);
            output.Text = "";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_8.Text;
            output.Text = input;
        }

        private void Btn_mult_Click(object sender, EventArgs e)
        {
            ops = "*";
            fnum = Convert.ToDouble(output.Text);
            output.Text = "";
        }

        private void Btn_divide_Click(object sender, EventArgs e)
        {
            ops = "/";
            fnum = Convert.ToDouble(output.Text);
            output.Text = "";
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            ops = "%";
            fnum = Convert.ToDouble(output.Text);
            output.Text = "";
        }

        private void Btn_equal_Click(object sender, EventArgs e)
        {
            if (ops == "+")
            {
                snum = Convert.ToDouble(output.Text);
                res = fnum + snum;
                String result = res.ToString();
                output.Text = result;
            }else if(ops == "-")
            {
                snum = Convert.ToDouble(output.Text);
                res = fnum - snum;
                String result = res.ToString();
                output.Text = result;
            }else if(ops == "*")
            {
                snum = Convert.ToDouble(output.Text);
                res = fnum * snum;
                String result = res.ToString();
                output.Text = result;
            }else if(ops == "/")
            {
                snum = Convert.ToDouble(output.Text);
                res = fnum / snum;
                String result = res.ToString();
                output.Text = result;
            }else if(ops == "%")
            {
                snum = Convert.ToDouble(output.Text);
                res = fnum % snum;
                String result = res.ToString();
                output.Text = result;
            }
        }

        private void Btn_backspace_Click(object sender, EventArgs e)
        {
            if ((String.Compare(output.Text, " ") < 0))
            {
                output.Text = output.Text.Substring(0, output.Text.Length - 1 + 1);
            }
            else
            {
                output.Text = output.Text.Substring(0, output.Text.Length - 1);
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_9.Text;
            output.Text = input;
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            String input = output.Text + btn_dot.Text;
            output.Text = input;
        }
    }
}
