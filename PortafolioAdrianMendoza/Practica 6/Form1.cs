using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static ArrayList names = new ArrayList();
        public static void Lista(ref ListBox list)
        {
            list.Items.Clear();
            foreach (string name in names)
            {
                list.Items.Add(name);
            }
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            if (rdoAdd.Checked)
            {
                if (txtName.Text != string.Empty)
                {
                    names.Add(txtName.Text);
                    Lista(ref lstEmp);
                    txtName.Clear();
                    txtName.Focus();
                }
            }
            else if (rdoSrch.Checked)
            {
                lstEmp.SetSelected(names.IndexOf(txtName.Text), true);
            }
            else if (rdoDel.Checked)
            {
                lstEmp.Items.RemoveAt(lstEmp.SelectedIndex);
            }
            else if (rdoSort.Checked)
            {
                if (lstEmp.Items.Count > 1)
                {
                    names.Sort(); Lista(ref lstEmp);
                }
            }
            else if (rdoInsert.Checked)
            {
                if (lstEmp.SelectedIndex >= 0)
                {
                    names.Insert(lstEmp.SelectedIndex, txtName.Text);
                    int pos = lstEmp.SelectedIndex;
                    Lista(ref lstEmp);
                    names.Clear();
                    lstEmp.SetSelected(pos, true);
                }
            }
            else if (rdoClear.Checked)
            {
                names.Clear();
                lstEmp.Items.Clear();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
