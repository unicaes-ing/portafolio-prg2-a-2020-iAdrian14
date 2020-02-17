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

namespace Practica_2
{
    public partial class Form3 : Form
    {
        //-------------Esto es para mover el programa sin los bordes predeterminados--------------

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
        public Form3()
        {
            InitializeComponent();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            try
            {
                double total, cant = Convert.ToDouble(txtCant.Text);
                if (lstConv1.Text == "Pulgadas" && lstConv2.Text == "Pies")
                {
                    total = cant * 1 / 12;
                }
                else if (lstConv1.Text == "Pulgadas" && lstConv2.Text == "Yardas")
                {
                    total = cant * 1 / 36;
                }
                else if (lstConv1.Text == "Pies" && lstConv2.Text == "Pulgadas")
                {
                    total = cant * 12;
                }
                else if (lstConv1.Text == "Pies" && lstConv2.Text == "Yardas")
                {
                    total = cant * 1 / 3;
                }
                else if (lstConv1.Text == "Yardas" && lstConv2.Text == "Pulgadas")
                {
                    total = cant * 36;
                }
                else if (lstConv1.Text == "Yardas" && lstConv2.Text == "Pies")
                {
                    total = cant * 3;
                }
                else
                {
                    total = cant;
                }
                txtTotal.Text = Convert.ToString(total);
            }
            catch
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}