using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
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

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool validado = true;
            err.Clear();
            if(txtCorreo.TextLength <= 0 )
            {
                err.SetError(txtCorreo, "Ingrese su correo");
                validado = false;
            }
            else
            {
                string patronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    err.SetError(txtCorreo, "Ingrese correctamente su correo");
                    validado = false;
                }
            }
            if(txtPass1.TextLength <= 0)
            {
                err.SetError(txtPass1, "Ingrese la contraseña");
                validado = false;
            }
            else
            {
                string patronContra = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
                if(!Regex.IsMatch(txtPass1.Text, patronContra))
                {
                    err.SetError(txtPass1, "Formato de contraseña no valido");
                    validado = false;
                }
            }
            if(!Equals(txtPass1.Text, txtPass2.Text) || txtPass2.TextLength <= 0)
            {
                err.SetError(txtPass2, "La contraseña no es igual");
                validado = false;
            }
            if(validado)
            {
                MessageBox.Show("Los Datos fueron validados correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
