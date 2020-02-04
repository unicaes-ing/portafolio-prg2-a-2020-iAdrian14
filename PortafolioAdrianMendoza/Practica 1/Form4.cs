using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form4 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlTop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sub = 0, precio = 0, cant = 0, imp = 0, total = 0;
            if (txtPrice.Text != "")
            {
                precio = Convert.ToDouble(txtPrice.Text);
            }
            if (txtCant.Text != "")
            {
                cant = Convert.ToDouble(txtCant.Text);
            }
            sub = cant * precio;
            txtSub.Text = String.Format("{0:C2}", sub);
            imp = sub * 0.13;
            txtImp.Text = String.Format("{0:C2}", imp);
            total = sub + imp;
            txtTotal.Text = String.Format("{0:C1}", total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtImp.Clear();
            txtCant.Clear();
            txtPrice.Clear();
            txtSub.Clear();
            txtTotal.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
