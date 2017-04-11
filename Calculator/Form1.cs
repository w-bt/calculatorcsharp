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
        float num, ans;
        int count;
        
        public void disable()
        {
            b0.Enabled = false;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            bPoint.Enabled = false;
            bMulti.Enabled = false;
            bDiv.Enabled = false;
            bMin.Enabled = false;
            bPlus.Enabled = false;
            bEq.Enabled = false;
            bBack.Enabled = false;
            bClear.Enabled = false;
            hasil.Enabled = false;
            bOff.Hide();
            bOn.Show();
        }

        public void enable()
        {
            b0.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            bPoint.Enabled = true;
            bMulti.Enabled = true;
            bDiv.Enabled = true;
            bMin.Enabled = true;
            bPlus.Enabled = true;
            bEq.Enabled = true;
            bBack.Enabled = true;
            bClear.Enabled = true;
            hasil.Enabled = true;
            bOff.Show();
            bOn.Hide();
        }

        public Form1()
        {
            InitializeComponent();
            bOn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // on
            enable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (prev.Text.Contains("x") || prev.Text.Contains("/") || prev.Text.Contains("-") || prev.Text.Contains("+"))
            {
                compute();
            }
            num = float.Parse(hasil.Text);
            hasil.Clear();
            hasil.Focus();
            prev.Text = num.ToString() + "x";
            count = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if(!hasil.Text.Contains(".")){
                hasil.Text      = hasil.Text + ".";
                hasil.ForeColor = Color.Black;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "0";
            hasil.ForeColor = Color.Black;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "1";
            hasil.ForeColor = Color.Black;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "2";
            hasil.ForeColor = Color.Black;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "3";
            hasil.ForeColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "4";
            hasil.ForeColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "5";
            hasil.ForeColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "6";
            hasil.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "7";
            hasil.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "8";
            hasil.ForeColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text + "9";
            hasil.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hasil.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            int lengthInt   = hasil.TextLength - 1;
            string text     = hasil.Text;
            hasil.Clear();
            for (int i = 0; i < lengthInt; i++ )
            {
                hasil.Text = hasil.Text + text[i];
            }
        }

        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num * float.Parse(hasil.Text);
                    hasil.Text = ans.ToString();
                    break;
                case 2:
                    ans = num / float.Parse(hasil.Text);
                    hasil.Text = ans.ToString();
                    break;
                case 3:
                    ans = num - float.Parse(hasil.Text);
                    hasil.Text = ans.ToString();
                    break;
                case 4:
                    ans = num + float.Parse(hasil.Text);
                    hasil.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (prev.Text.Contains("x") || prev.Text.Contains("/") || prev.Text.Contains("-") || prev.Text.Contains("+"))
            {
                compute();
            }
            num = float.Parse(hasil.Text);
            hasil.Clear();
            hasil.Focus();
            prev.Text = num.ToString() + "/";
            count = 2;
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            if (prev.Text.Contains("x") || prev.Text.Contains("/") || prev.Text.Contains("-") || prev.Text.Contains("+"))
            {
                compute();
            }
            num = float.Parse(hasil.Text);
            hasil.Clear();
            hasil.Focus();
            prev.Text = num.ToString() + "-";
            count = 3;
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (prev.Text.Contains("x") || prev.Text.Contains("/") || prev.Text.Contains("-") || prev.Text.Contains("+"))
            {
                compute();
            }
            num = float.Parse(hasil.Text);
            hasil.Clear();
            hasil.Focus();
            prev.Text = num.ToString() + "+";
            count = 4;
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            compute();
            prev.Text = "";
        }
    }
}
