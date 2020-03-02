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
    public partial class Form2 : Form
    {
        public static int Search(ListBox nums, int iNum)
        {
            int cont = 0;
            foreach (var num in nums.Items)
            {
                if (Convert.ToInt32(num) == iNum) cont++;
            }
            return cont;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(txtAdd.Text);
                lstNum.Items.Add(num);
                txtAdd.Clear();
                txtAdd.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtSearch.Text);
                int cont = Search(lstNum, num);
                MessageBox.Show("El numero se encuentra " + cont + " veces", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
