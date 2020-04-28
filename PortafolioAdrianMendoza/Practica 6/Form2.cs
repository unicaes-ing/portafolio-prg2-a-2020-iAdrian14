using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Dictionary<string, string> dict = new Dictionary<string, string> {};
        private void FillList()
        {
            lvProd.Items.Clear();
            foreach (KeyValuePair<string, string> prod in dict)
            {
                string[] data = { prod.Key, prod.Value };
                ListViewItem item = new ListViewItem(data);
                lvProd.Items.Add(item);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mskTel.MaskFull && txtName.TextLength > 0)
            {
                if (dict.ContainsKey(mskTel.Text)) MessageBox.Show("El numero de telefono ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string tel = mskTel.Text, name = txtName.Text;
                    dict.Add(mskTel.Text, txtName.Text);
                    mskTel.Clear();
                    txtName.Clear();
                    mskTel.Focus();
                    FillList();
                }
            }
            else MessageBox.Show("Ingrese los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSrch_Click(object sender, EventArgs e)
        {
            if (mskTel.MaskFull)
            {
                if (!dict.ContainsKey(mskTel.Text))
                {
                    MessageBox.Show("El numero de telefono no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = lvProd.Items.Count - 1; i >= 0; i--)
                    {
                        var item = lvProd.Items[i];
                        if (item.Text.ToLower().Contains(mskTel.Text.ToLower()))
                        {
                            item.BackColor = SystemColors.Highlight;
                            item.ForeColor = SystemColors.HighlightText;
                        }
                        else
                        {
                            item.BackColor = Color.White;
                            item.ForeColor = Color.Black;
                        }
                    }
                    if (lvProd.SelectedItems.Count == 1)
                    {
                        lvProd.Focus();
                    }
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!dict.ContainsKey(mskTel.Text)) MessageBox.Show("El numero de telefono ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dict.Remove(mskTel.Text);
                mskTel.Clear();
                txtName.Clear();
                mskTel.Focus();
                FillList();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
