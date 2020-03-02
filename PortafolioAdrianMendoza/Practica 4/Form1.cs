using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        private static double Sumar(double n1, double n2, double n3, double n4)
        {
            return n1 + n2 + n3 + n4;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text), num2 = Convert.ToDouble(txtNum2.Text), num3 = Convert.ToDouble(txtNum3.Text), num4 = Convert.ToDouble(txtNum4.Text);
                lblTotal.Text = Sumar(num1, num2, num3, num4).ToString();
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum3.Clear();
                txtNum4.Clear();
                txtNum1.Focus();
            }
            catch
            {
                MessageBox.Show("Ingrese 4 números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
