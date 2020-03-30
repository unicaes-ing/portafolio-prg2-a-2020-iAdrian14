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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string[] vendedores = new string[10] { "Adrian", "Jorge", "Alejandro", "Pedro", "Juan", "Juana", "Gabriela", "Joel", "Carlos", "Mario"};

		private void Form1_Load(object sender, EventArgs e)
		{
			lstVen.DataSource = vendedores;
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			//-------------------------Opcion 1-----------------------
			//string[] temp = new string[vendedores.Length];
			//int n = 0;
			//for (int i = 0; i < vendedores.Length; i++)
			//{
			//	if (i != lstVen.SelectedIndex)
			//	{
			//		temp[n] = vendedores[i];
			//		n++;
			//	}
			//}
			//vendedores = temp;
			//lstVen.DataSource = vendedores;
			//--------------------------Opcion 2----------------------
			//if (lstVen.SelectedIndex >= 0)
			//{
			//	List<string> lista = new List<string>(vendedores);
			//	lista.RemoveAt(lstVen.SelectedIndex);
			//	vendedores = lista.ToArray();
			//	lstVen.DataSource = vendedores;
			//	lstVen.SelectedIndex = -1;
			//}
			//-------------------------Opcion 3------------------------
			if (lstVen.SelectedIndex >= 0)
			{
				vendedores = vendedores.Where((item, index) => index != lstVen.SelectedIndex).ToArray();
				lstVen.DataSource = vendedores;
				lstVen.SelectedIndex = -1;
			}
		}

		private void btnAZ_Click(object sender, EventArgs e)
		{
			lstVen.DataSource = null;
			Array.Sort(vendedores);
			lstVen.DataSource = vendedores;
		}

		private void btnZA_Click(object sender, EventArgs e)
		{
			lstVen.DataSource = null;
			Array.Sort(vendedores);
			Array.Reverse(vendedores);
			lstVen.DataSource = vendedores;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtSearch.TextLength > 0)
			{
				int i = Array.IndexOf(vendedores, txtSearch.Text);
				if (i >= 0)
				{
					lstVen.SelectedIndex = i;
				}
				else
				{
					MessageBox.Show("No se encuentra en la lista");
				}
			}
		}
	}
}
