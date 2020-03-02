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
    public partial class Form4 : Form
    {
        public static int Mayor(int n1, int n2, int n3)
        {
            int mayor=0;
            for (int i = 0; i < 3; i++)
            {
                if (n1 > n2 && n1 > n3) mayor = n1;
                else if (n2 > n1 && n2 > n3) mayor = n2;
                else if (n3 > n1 && n3 > n2) mayor = n3;
                else mayor = 0;
            }
            return mayor;
        }
        public static int Mayor(int n1, int n2)
        {

            int mayor=0;
            for (int i = 0; i < 3; i++)
            {
                if (n1 > n2) mayor = n1;
                else if (n2 > n1) mayor = n2;
                else mayor = 0;
            }
            return mayor;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, n3;
                if (txtNum1.Text == "")
                {
                    n2 = Convert.ToInt32(txtNum2.Text);
                    n3 = Convert.ToInt32(txtNum3.Text);
                    lblTotal.Text = Mayor(n2, n3).ToString();
                }
                else if (txtNum2.Text == "")
                {
                    n1 = Convert.ToInt32(txtNum1.Text);
                    n3 = Convert.ToInt32(txtNum3.Text);
                    lblTotal.Text = Mayor(n1, n3).ToString();
                }
                else if (txtNum3.Text == "")
                {
                    n1 = Convert.ToInt32(txtNum1.Text);
                    n2 = Convert.ToInt32(txtNum2.Text);
                    lblTotal.Text = Mayor(n1, n2).ToString();
                }
                else
                {
                    n1 = Convert.ToInt32(txtNum1.Text);
                    n2 = Convert.ToInt32(txtNum2.Text);
                    n3 = Convert.ToInt32(txtNum3.Text);
                    lblTotal.Text = Mayor(n1, n2, n3).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese dos o tres numeros enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
