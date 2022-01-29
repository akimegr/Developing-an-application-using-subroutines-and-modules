using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab3rpvs.Class1;

namespace lab3rpvs
{
    public partial class Form1 : Form
    {
        static string s = "Результаты ст.гр 10701320 Акимов Е.С.\r\n";
        static string tAns = "";
      


        public Form1()
        {
            InitializeComponent();
            this.Text = "Лаб 3 ст.гр 10701320 Акимов Егор";
            this.ans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ans.ReadOnly = true;
            H.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(x.Text);
            double x2 = double.Parse(xk.Text);
            double N = double.Parse(n.Text);
            double ansH = (x2 - x1) / N;
            H.Text = ansH.ToString();
            double sum = 0;
            int fa = 1;
            int NN = 0;
            double prim = Math.Pow((-1), N) * Math.Pow(x1, (2 * N + 1)) / (fa);
            while (x1<=x2+0.00001)
            {
                sum = 0;
                prim = 0;
                NN = 0;
                while (NN <= N)
                {
                    fa = 1;
                    int countFa = 1;
                    fa = Class1.factorial(fa, NN, countFa);
                    prim = Class1.answ(NN, x1, fa);
                    sum += prim;
                    
                    NN++;
                }
                Class1.Printer(x1, sum, ref s);
                x1 += ansH;
            }
            
            ans.Text = s;
        }

        private void ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_TextChanged(object sender, EventArgs e)
        {

        }

        private void xk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
