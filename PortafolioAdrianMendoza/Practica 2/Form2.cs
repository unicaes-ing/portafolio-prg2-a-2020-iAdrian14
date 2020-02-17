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
    public partial class Form2 : Form
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
		public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
			try
			{
				double precio = 0, cant = 0, desc = 0, tdesc = 0;
				if (rdoDesc1.Checked)
				{
					desc = 0;
				}
				else if (rdoDesc2.Checked)
				{
					desc = 0.05;
				}
				else if (rdoDesc3.Checked)
				{
					desc = 0.10;
				}
				else if (rdoDesc4.Checked)
				{
					desc = 0.15;
				}
				else if (rdoDesc5.Checked)
				{
					desc = 0.20;
				}
				precio = Convert.ToDouble(txtPrice.Text);
				cant = Convert.ToDouble(txtCant.Text);
				tdesc = (precio * cant) * desc;
				txtDesc.Text = String.Format("{0:C2}", tdesc);
				txtTotal.Text = String.Format("{0:C2}", (precio * cant) - tdesc);
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese correctamente los datos", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
		}

		private void picMin_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtCant.Clear();
			txtDesc.Clear();
			txtPrice.Clear();
			txtTotal.Clear();
			txtCant.Focus();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
