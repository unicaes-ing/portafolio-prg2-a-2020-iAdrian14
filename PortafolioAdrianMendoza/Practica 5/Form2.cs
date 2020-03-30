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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		int[,] a = new int[5, 5];
		int[,] b = new int[5, 5];
		private void Form2_Load(object sender, EventArgs e)
		{
			dgvA.ColumnCount = 5;
			dgvB.ColumnCount = 5;
			dgvA.AllowUserToAddRows = false;
			dgvB.AllowUserToAddRows = false;
			dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			Random ran = new Random();
			for (int r = 0; r < a.GetLength(0); r++)
			{
				dgvA.Rows.Add();
				dgvB.Rows.Add();
				for (int c = 0; c < a.GetLength(1); c++)
				{
					a[r, c] = ran.Next(10, 90);
					b[r, c] = ran.Next(10, 90);
					dgvA.Rows[r].Cells[c].Value = a[r, c];
					dgvB.Rows[r].Cells[c].Value = b[r, c];
					dgvB.ForeColor = Color.FromArgb(0, 0, 0);
					dgvA.ForeColor = Color.FromArgb(0, 0, 0);
					dgvR.ForeColor = Color.FromArgb(0, 0, 0);
				}
			}
			dgvA.ClearSelection();
			dgvB.ClearSelection();
		}
		public static int[,] SumMatriz(int[,] array1, int[,] array2)
		{
			int[,] array3 = new int[5,5];
			for (int r = 0; r < array1.GetLength(0); r++)
			{
				for (int c = 0; c < array1.GetLength(1); c++)
				{
					array3[r, c] = array1[r, c] + array2[r, c];
				}
			}
			return array3;
		}
		public static int[,] MultMatriz(int[,] array1, int[,] array2)
		{
			int[,] array3 = new int[5, 5];
			for (int r = 0; r < array1.GetLength(0); r++)
			{
				for (int c = 0; c < array1.GetLength(1); c++)
				{
					array3[r, c] = array1[r, c] * array2[r, c];
				}
			}
			return array3;
		}
		private void btnCalc_Click(object sender, EventArgs e)
		{
			dgvR.Rows.Clear();
			dgvR.Columns.Clear();
			dgvR.AllowUserToAddRows = false;
			dgvR.ScrollBars = ScrollBars.None;
			dgvR.ColumnCount = 5;
			dgvR.ColumnHeadersVisible = false;
			dgvR.RowHeadersVisible = false;
			dgvR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			int[,] z = new int[5, 5];
			if (rdoSum.Checked)
			{
				z = SumMatriz(a, b);
				for (int r = 0; r < z.GetLength(0); r++)
				{
					dgvR.Rows.Add();
					for (int c = 0; c < z.GetLength(1); c++)
					{
						dgvR.Rows[r].Cells[c].Value = z[r, c];
					}
				}
			}
			else
			{
				z = MultMatriz(a, b);
				for (int r = 0; r < z.GetLength(0); r++)
				{
					dgvR.Rows.Add();
					for (int c = 0; c < z.GetLength(1); c++)
					{
						dgvR.Rows[r].Cells[c].Value = z[r, c];
					}
				}

			}
			dgvR.ClearSelection();
		}
	}
}
