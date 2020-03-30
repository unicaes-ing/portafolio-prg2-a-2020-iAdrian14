using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[][] ven = new string[6][];
        private void Form3_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int r = 0; r < ven.GetLength(0); r++)
            {
                int m = ran.Next(1, 10);
                ven[r] = new string[m];
                for (int c = 0; c < m; c++)
                {
                    ven[r][c] = ran.Next(1, 60).ToString();
                }
            }
            lstSuc.Items.Clear();
            for (int i = 0; i < ven.GetLength(0); i++)
            {
                lstSuc.Items.Add("Sucursal #" + (i + 1));
            }
        }
        private void lstSuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = 0;
            if (lstSuc.SelectedIndex >= 0)
            {
                lstVen.Items.Clear();
                foreach (string v in ven[lstSuc.SelectedIndex])
                {
                    lstVen.Items.Add(v);
                    total = total + Convert.ToDouble(v);
                }
            }
            lblVen.Text = total.ToString("C2");

        }
    }
}
