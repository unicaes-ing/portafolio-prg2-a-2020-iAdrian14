namespace Practica_6
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
            this.lstEmp = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSrch = new System.Windows.Forms.RadioButton();
            this.rdoInsert = new System.Windows.Forms.RadioButton();
            this.rdoDel = new System.Windows.Forms.RadioButton();
            this.rdoSort = new System.Windows.Forms.RadioButton();
            this.rdoClear = new System.Windows.Forms.RadioButton();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados:";
            // 
            // lstEmp
            // 
            this.lstEmp.BackColor = System.Drawing.Color.White;
            this.lstEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmp.ForeColor = System.Drawing.Color.Black;
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.ItemHeight = 22;
            this.lstEmp.Location = new System.Drawing.Point(32, 90);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(201, 378);
            this.lstEmp.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdoClear);
            this.groupBox1.Controls.Add(this.rdoSort);
            this.groupBox1.Controls.Add(this.rdoDel);
            this.groupBox1.Controls.Add(this.rdoInsert);
            this.groupBox1.Controls.Add(this.rdoSrch);
            this.groupBox1.Controls.Add(this.rdoAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(262, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accion";
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.rdoAdd.Location = new System.Drawing.Point(6, 45);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(106, 26);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Agregar";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSrch
            // 
            this.rdoSrch.AutoSize = true;
            this.rdoSrch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.rdoSrch.Location = new System.Drawing.Point(6, 75);
            this.rdoSrch.Name = "rdoSrch";
            this.rdoSrch.Size = new System.Drawing.Size(97, 26);
            this.rdoSrch.TabIndex = 1;
            this.rdoSrch.Text = "Buscar";
            this.rdoSrch.UseVisualStyleBackColor = true;
            // 
            // rdoInsert
            // 
            this.rdoInsert.AutoSize = true;
            this.rdoInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.rdoInsert.Location = new System.Drawing.Point(6, 105);
            this.rdoInsert.Name = "rdoInsert";
            this.rdoInsert.Size = new System.Drawing.Size(103, 26);
            this.rdoInsert.TabIndex = 2;
            this.rdoInsert.Text = "Insertar";
            this.rdoInsert.UseVisualStyleBackColor = true;
            // 
            // rdoDel
            // 
            this.rdoDel.AutoSize = true;
            this.rdoDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.rdoDel.Location = new System.Drawing.Point(6, 135);
            this.rdoDel.Name = "rdoDel";
            this.rdoDel.Size = new System.Drawing.Size(90, 26);
            this.rdoDel.TabIndex = 3;
            this.rdoDel.Text = "Quitar";
            this.rdoDel.UseVisualStyleBackColor = true;
            // 
            // rdoSort
            // 
            this.rdoSort.AutoSize = true;
            this.rdoSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.rdoSort.Location = new System.Drawing.Point(6, 165);
            this.rdoSort.Name = "rdoSort";
            this.rdoSort.Size = new System.Drawing.Size(108, 26);
            this.rdoSort.TabIndex = 4;
            this.rdoSort.Text = "Ordenar";
            this.rdoSort.UseVisualStyleBackColor = true;
            // 
            // rdoClear
            // 
            this.rdoClear.AutoSize = true;
            this.rdoClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.rdoClear.Location = new System.Drawing.Point(6, 195);
            this.rdoClear.Name = "rdoClear";
            this.rdoClear.Size = new System.Drawing.Size(100, 26);
            this.rdoClear.TabIndex = 5;
            this.rdoClear.Text = "Limpiar";
            this.rdoClear.UseVisualStyleBackColor = true;
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.btnInit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInit.FlatAppearance.BorderSize = 3;
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.ForeColor = System.Drawing.Color.White;
            this.btnInit.Location = new System.Drawing.Point(277, 309);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(162, 45);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "Ejecutar";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(322, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.txtName.Location = new System.Drawing.Point(32, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 28);
            this.txtName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 530);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstEmp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Ejer1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoClear;
        private System.Windows.Forms.RadioButton rdoSort;
        private System.Windows.Forms.RadioButton rdoDel;
        private System.Windows.Forms.RadioButton rdoInsert;
        private System.Windows.Forms.RadioButton rdoSrch;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
    }
}

