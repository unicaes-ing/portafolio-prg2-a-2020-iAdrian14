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

namespace Practica_3
{
    public partial class Form5 : Form
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
        public Form5()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                double  total = 0, subtotal = 0, imp = 0, horas = Convert.ToDouble(txtHora.Text), cantH = Convert.ToDouble(txtHcant.Text), t = 0;
                subtotal = horas * cantH;
                imp = subtotal * 0.10;
                total = subtotal - imp;
                dgvTabla.Rows.Add(name, horas, String.Format("{0:C2}", cantH), String.Format("{0:C2}",subtotal), String.Format("{0:C2}",imp), String.Format("{0}",total));
                for (int i = 0; i < dgvTabla.Rows.Count; ++i)
                {
                    t += Convert.ToDouble(dgvTabla.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = String.Format("{0:C2}", t);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error");
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            txtHcant.Clear();
            txtHora.Clear();
            txtName.Clear();
            txtTotal.Clear();
        }
    }
}
