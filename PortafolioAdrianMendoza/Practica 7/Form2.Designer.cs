namespace Practica_7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWe = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboPro = new System.Windows.Forms.ComboBox();
            this.cboScp = new System.Windows.Forms.ComboBox();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.rdoH = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtxCod = new System.Windows.Forms.MaskedTextBox();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Propietario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha nac:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Peso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // txtWe
            // 
            this.txtWe.Location = new System.Drawing.Point(162, 198);
            this.txtWe.Name = "txtWe";
            this.txtWe.Size = new System.Drawing.Size(137, 26);
            this.txtWe.TabIndex = 8;
            this.txtWe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWe_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 26);
            this.txtName.TabIndex = 9;
            // 
            // cboPro
            // 
            this.cboPro.FormattingEnabled = true;
            this.cboPro.Location = new System.Drawing.Point(162, 98);
            this.cboPro.Name = "cboPro";
            this.cboPro.Size = new System.Drawing.Size(269, 28);
            this.cboPro.TabIndex = 10;
            // 
            // cboScp
            // 
            this.cboScp.FormattingEnabled = true;
            this.cboScp.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Loro",
            "Perico",
            "Otro"});
            this.cboScp.Location = new System.Drawing.Point(162, 132);
            this.cboScp.Name = "cboScp";
            this.cboScp.Size = new System.Drawing.Size(223, 28);
            this.cboScp.TabIndex = 11;
            // 
            // dtpNac
            // 
            this.dtpNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNac.Location = new System.Drawing.Point(162, 167);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(137, 26);
            this.dtpNac.TabIndex = 12;
            // 
            // rdoH
            // 
            this.rdoH.AutoSize = true;
            this.rdoH.Location = new System.Drawing.Point(162, 230);
            this.rdoH.Name = "rdoH";
            this.rdoH.Size = new System.Drawing.Size(91, 24);
            this.rdoH.TabIndex = 13;
            this.rdoH.Text = "Hembra";
            this.rdoH.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Checked = true;
            this.rdoM.Location = new System.Drawing.Point(283, 232);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(82, 24);
            this.rdoM.TabIndex = 14;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "Macho";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // dgvPet
            // 
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.N,
            this.p,
            this.e,
            this.F,
            this.pe,
            this.se});
            this.dgvPet.Location = new System.Drawing.Point(32, 266);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.RowHeadersVisible = false;
            this.dgvPet.RowHeadersWidth = 62;
            this.dgvPet.RowTemplate.Height = 28;
            this.dgvPet.Size = new System.Drawing.Size(656, 295);
            this.dgvPet.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(447, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(241, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar mascota";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(559, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 37);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtxCod
            // 
            this.mtxCod.Location = new System.Drawing.Point(162, 37);
            this.mtxCod.Mask = "LL0000";
            this.mtxCod.Name = "mtxCod";
            this.mtxCod.Size = new System.Drawing.Size(91, 26);
            this.mtxCod.TabIndex = 18;
            // 
            // a
            // 
            this.a.HeaderText = "Codigo";
            this.a.MinimumWidth = 8;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Width = 75;
            // 
            // N
            // 
            this.N.HeaderText = "Nombre";
            this.N.MinimumWidth = 8;
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // p
            // 
            this.p.FillWeight = 200F;
            this.p.HeaderText = "Propietario";
            this.p.MinimumWidth = 8;
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Width = 150;
            // 
            // e
            // 
            this.e.HeaderText = "Especie";
            this.e.MinimumWidth = 8;
            this.e.Name = "e";
            this.e.ReadOnly = true;
            // 
            // F
            // 
            this.F.HeaderText = "Fecha de nacimiento";
            this.F.MinimumWidth = 8;
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // pe
            // 
            this.pe.HeaderText = "Peso";
            this.pe.MinimumWidth = 8;
            this.pe.Name = "pe";
            this.pe.ReadOnly = true;
            this.pe.Width = 75;
            // 
            // se
            // 
            this.se.HeaderText = "Sexo";
            this.se.MinimumWidth = 8;
            this.se.Name = "se";
            this.se.ReadOnly = true;
            this.se.Width = 75;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 628);
            this.Controls.Add(this.mtxCod);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.rdoM);
            this.Controls.Add(this.rdoH);
            this.Controls.Add(this.dtpNac);
            this.Controls.Add(this.cboScp);
            this.Controls.Add(this.cboPro);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtWe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboPro;
        private System.Windows.Forms.ComboBox cboScp;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.RadioButton rdoH;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox mtxCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn se;
    }
}