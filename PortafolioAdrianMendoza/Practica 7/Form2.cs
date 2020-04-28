using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        [Serializable]
        public struct Mascotas
        {
            public string codigo;
            public string nombre;
            public string propietario;
            public string especie;
            public string fecha;
            public double peso;
            public string sexo;
        }

        Mascotas pets = new Mascotas();
        Dictionary<string, Mascotas> petDict = new Dictionary<string, Mascotas>();
        BinaryFormatter formatter = new BinaryFormatter();
        const string NOMBRE_ARCHIVO = "mascotas.dat";

        private void Form2_Load(object sender, EventArgs e)
        {
            string name, mail, phone;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("Propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cboPro.Items.Clear();
                while (true)
                {
                    name = br.ReadString();
                    mail = br.ReadString();
                    phone = br.ReadString();
                    cboPro.Items.Add(name);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }

            if (File.Exists(NOMBRE_ARCHIVO))
            {
                try
                {
                    FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                    petDict = (Dictionary<string, Mascotas>)formatter.Deserialize(ReaderFS);
                    ReaderFS.Close();
                }
                catch (Exception)
                {

                }

                if (petDict.Count > 0)
                {
                    dgvPet.Rows.Clear();
                    foreach (Mascotas mascota in petDict.Values)
                    {
                        dgvPet.Rows.Add(mascota.codigo, mascota.nombre, mascota.propietario, mascota.especie, mascota.fecha, mascota.peso, mascota.sexo);
                    }
                    dgvPet.ClearSelection();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!mtxCod.MaskFull || txtName.Text == "" || cboPro.SelectedIndex == -1 || cboScp.SelectedIndex == -1 || txtWe.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pets.codigo = mtxCod.Text;
                pets.nombre = txtName.Text;
                pets.propietario = cboPro.SelectedItem + "";
                pets.especie = cboScp.SelectedItem + "";
                pets.fecha = dtpNac.Text;
                pets.peso = Convert.ToDouble(txtWe.Text);
                mtxCod.Clear();
                txtName.Clear();
                cboPro.SelectedIndex = -1;
                cboScp.SelectedIndex = -1;
                txtWe.Clear();
                mtxCod.Focus();
                if (rdoM.Checked)
                {
                    pets.sexo = rdoM.Text;
                }
                else
                {
                    pets.sexo = rdoH.Text;
                }
                if (petDict.ContainsKey(pets.codigo))
                {
                    MessageBox.Show("Esta clave ya existe.");
                }
                else
                {
                    petDict.Add(pets.codigo, pets);
                    dgvPet.Rows.Add(
                        pets.codigo,
                        pets.nombre,
                        pets.propietario, 
                        pets.especie, 
                        pets.fecha,
                        pets.peso,
                        pets.sexo);
                    try
                    {
                        FileStream writerFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFS, petDict);
                        writerFS.Close();
                        MessageBox.Show("Los datos fueron almacenados correctamente.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al guardar los datos.");
                    }
                }
            }
        }
        private void txtWe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtWe.Text.Contains("."))
            {
                e.Handled = false;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
