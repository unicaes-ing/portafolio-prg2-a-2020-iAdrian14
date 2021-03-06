﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double ex1 = 0, ex2 = 0, ex3 = 0, total = 0;
            if (txtExam1.Text != "")
            {
                ex1 = Convert.ToDouble(txtExam1.Text);
            }
            if (txtExam2.Text != "")
            {
                ex2 = Convert.ToDouble(txtExam2.Text);
            }
            if (txtExam3.Text != "")
            {
                ex3 = Convert.ToDouble(txtExam3.Text);
            }
            total = (ex1 + ex2 + ex3)/3.0;
            txtProm.Text = String.Format("{0:F2}",total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExam1.Clear();
            txtExam2.Clear();
            txtExam3.Clear();
            txtProm.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
