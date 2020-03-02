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
    public partial class Form3 : Form
    {
        private static int FuncionFibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return FuncionFibonacci(n - 1) + FuncionFibonacci(n - 2);
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                txtFib.Text = FuncionFibonacci(Convert.ToInt32(txtNum.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
