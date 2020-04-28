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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public struct Empleado
        {
            public string nit;
            public string nombre;
            public double sueldo;
        }
        Dictionary<string, Empleado> empDict = new Dictionary<string, Empleado>();
        public double total = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtSu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtSu.Text.Contains("."))
            {
                e.Handled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!mtxNit.MaskFull || txtName.Text == "" || txtSu.Text == "")
            {
                mtxNit.Focus();
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (empDict.ContainsKey(mtxNit.Text))
            {
                MessageBox.Show("Este número de NIT ya existe\nIngrese un numero de NIT diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Empleado emp = new Empleado();

                emp.nit = mtxNit.Text;
                emp.nombre = txtName.Text;
                emp.sueldo = Convert.ToDouble(txtSu.Text);

                empDict.Add(emp.nit, emp);

                dgvPlan.Rows.Add(emp.nit, emp.nombre, emp.sueldo);

                total = total + Convert.ToDouble(emp.sueldo);
                lblTotal.Text = total.ToString();
                dgvPlan.ClearSelection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mtxNit2.Text == "" || !mtxNit2.MaskFull)
            {
                MessageBox.Show("Ingrese un codigo para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxNit2.Focus();
                mtxNit2.SelectAll();
            }
            else if (empDict.ContainsKey(mtxNit2.Text))
            {
                foreach (DataGridViewRow Row in dgvPlan.Rows)
                {
                    int strFila = Row.Index;
                    string valor = Convert.ToString(Row.Cells[0].Value);

                    if (valor == mtxNit2.Text)
                    {
                        dgvPlan.Rows[strFila].DefaultCellStyle.BackColor = Color.FromArgb(250, 175, 175);
                    }
                    else dgvPlan.Rows[strFila].DefaultCellStyle.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("El NIT que desea buscar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!mtxNit2.MaskFull)
            {
                MessageBox.Show("Ingrese el NIT", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxNit2.Focus();
            }
            else if (empDict.ContainsKey(mtxNit2.Text))
            {
                foreach (DataGridViewRow Row in dgvPlan.Rows)
                {
                    int delFila = Row.Index;
                    string valor = Convert.ToString(Row.Cells[0].Value);
                    if (valor == mtxNit2.Text)
                    {
                        dgvPlan.Rows.RemoveAt(delFila);
                        total -= Convert.ToDouble(Row.Cells[2].Value);
                    }
                }
                empDict.Remove(mtxNit2.Text);
                lblTotal.Text = total.ToString();
            }
            else
            {
                lblTotal.Text = total.ToString();
                MessageBox.Show("El NIT que desea eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxNit2.Focus();
                mtxNit2.SelectAll();
            }
        }
    }
}
