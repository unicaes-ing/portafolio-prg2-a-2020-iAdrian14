using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            FileStream fs = null;
            BinaryWriter bw = null;

            if (txtName.Text.Length == 0 && txtMail.Text.Length == 0 && !mtxPhone.MaskFull)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
            }
            else
            {

                dgvClient.Rows.Add(txtName.Text, txtMail.Text, mtxPhone.Text);
                dgvClient.ClearSelection();
                try
                {
                    fs = new FileStream("propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txtName.Text);
                    bw.Write(txtMail.Text);
                    bw.Write(mtxPhone.Text);
                    MessageBox.Show("Todos los datos se guardaron correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtMail.Clear();
                    mtxPhone.Clear();
                    txtName.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al guardar los datos.");
                }
                finally
                {
                    if (bw != null)
                    {
                        bw.Close();
                    }
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string name, mail, tel;
            FileStream fs = null;
            BinaryReader bw = null;

            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                bw = new BinaryReader(fs);
                dgvClient.Rows.Clear();
                while (true)
                {
                    name = bw.ReadString();
                    mail = bw.ReadString();
                    tel = bw.ReadString();
                    dgvClient.Rows.Add(name, mail, tel);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (bw != null)
                {
                    bw.Close();
                    dgvClient.ClearSelection();
                }
            }
        }
        private void btnPets_Click(object sender, EventArgs e)
        {
            if (dgvClient.Rows.Count != 0)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe agregar por lo menos un propietario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }

        }
    }
}
