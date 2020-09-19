using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(SideA.Text); int b = int.Parse(SideB.Text); int c = int.Parse(SideC.Text);

            if (a != 0 && b != 0 && c != 0)
            {
                int p = a + b + c;
                PLabel.Text = "Периметр = " + p;
                SLabel.Text = "Площадь = " + Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            }
        }
    }
}
