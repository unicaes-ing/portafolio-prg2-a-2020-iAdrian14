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
    public partial class Form3 : Form
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
		public Form3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
			double n1 = 0, n2 = 0, n3 = 0, total = 0;
			if (txtInv1.Text != "")
			{
				n1 = Convert.ToDouble(txtInv1.Text);
			}
			if (txtInv2.Text != "")
			{
				n2 = Convert.ToDouble(txtInv2.Text);
			}
			if (txtInv3.Text != "")
			{
				n3 = Convert.ToDouble(txtInv3.Text);
			}
			total = n1 + n2 + n3;
			txtTotal.Text = String.Format("{0:C2}", total);
			txtPor1.Text = String.Format("{0:F1}{1}", ((n1 / total) * 100), "%");
			txtPor2.Text = String.Format("{0:F1}{1}", ((n2 / total) * 100), "%");
			txtPor3.Text = String.Format("{0:F1}{1}", ((n3 / total) * 100), "%");
		}

		private void btnClear_Click(object sender, EventArgs e)
		{ 
			txtInv1.Clear();
			txtInv2.Clear();
			txtInv3.Clear();
			txtPor1.Clear();
			txtPor2.Clear();
			txtPor3.Clear();
			txtTotal.Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
