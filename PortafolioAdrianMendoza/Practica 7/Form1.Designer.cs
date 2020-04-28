namespace Practica_7
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mtxPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(469, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(107, 81);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(469, 26);
            this.txtMail.TabIndex = 4;
            // 
            // mtxPhone
            // 
            this.mtxPhone.Location = new System.Drawing.Point(107, 125);
            this.mtxPhone.Mask = "0000-0000";
            this.mtxPhone.Name = "mtxPhone";
            this.mtxPhone.Size = new System.Drawing.Size(216, 26);
            this.mtxPhone.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(338, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.mail,
            this.tel});
            this.dgvClient.Location = new System.Drawing.Point(36, 177);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidth = 62;
            this.dgvClient.RowTemplate.Height = 28;
            this.dgvClient.Size = new System.Drawing.Size(540, 175);
            this.dgvClient.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mail.HeaderText = "Correo";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefono";
            this.tel.MinimumWidth = 8;
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Width = 75;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(472, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPets
            // 
            this.btnPets.Location = new System.Drawing.Point(36, 370);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(107, 35);
            this.btnPets.TabIndex = 9;
            this.btnPets.Text = "Mascotas";
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtxPhone);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mtxPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPets;
    }
}

