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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
			try
			{
				lblRom.ForeColor = Color.Black;
				int n = Convert.ToInt32(txtRom.Text);
				string romano = "";
				if (n >= 1 && n <= 10)
				{
					if (n == 1)
					{
						romano = "I";
					}
					else if (n == 2)
					{
						romano = "II";
					}
					else if (n == 3)
					{
						romano = "III";
					}
					else if (n == 4)
					{
						romano = "IV";
					}
					else if (n == 5)
					{
						romano = "V";
					}
					else if (n == 6)
					{
						romano = "vI";
					}
					else if (n == 7)
					{
						romano = "VII";
					}
					else if (n == 8)
					{
						romano = "VIII";
					}
					else if (n == 9)
					{
						romano = "IX";
					}
					else
					{
						romano = "X";
					}

					lblRom.Text = "Equivale a " + romano + " en Romano";
				}
				else
				{
					txtRom.Focus();
					txtRom.SelectAll();
					lblRom.ForeColor = Color.Red;
					lblRom.Text = "Solo numeros del 1-10";
				}
			}
			catch (Exception)
			{
				txtRom.Focus();
				txtRom.SelectAll();
				lblRom.ForeColor = Color.Red;
				lblRom.Text = "Error, Solo numeros...";
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
