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
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
			dgvTabla.Size = new Size(210, 220);
			dgvTabla.AllowUserToAddRows = false;
			dgvTabla.ScrollBars = ScrollBars.None;
			dgvTabla.ColumnCount = 10;
			dgvTabla.ColumnHeadersVisible = false;
			dgvTabla.RowHeadersVisible = false;
			dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			Random r = new Random();
			for (int f = 0; f < 10; f++)
			{
				dgvTabla.Rows.Add();
				for (int c = 0; c < 10; c++)
				{
					dgvTabla.Rows[f].Cells[c].Value = r.Next(10, 100);
                    dgvTabla.Rows[f].Cells[c].Style.BackColor = Color.Black;
                }
			}
			dgvTabla.ClearSelection();
		}

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNum.Text);
                for (int f = 0; f < 10; f++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (dgvTabla.Rows[f].Cells[i].Value.Equals(num))
                        {
                            dgvTabla.Rows[f].Cells[i].Style.BackColor = Color.Crimson;
                        }
                        else
                        {
                            dgvTabla.Rows[f].Cells[i].Style.BackColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }
    }
}
