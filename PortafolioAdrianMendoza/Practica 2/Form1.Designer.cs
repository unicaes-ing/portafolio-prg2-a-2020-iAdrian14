namespace Practica_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRom = new System.Windows.Forms.Label();
            this.txtRom = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConv = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.pnlTop.Controls.Add(this.picClose);
            this.pnlTop.Controls.Add(this.picMin);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(557, 60);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(514, 11);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 40);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picMin
            // 
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
            this.picMin.Location = new System.Drawing.Point(468, 12);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(40, 40);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 9;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Conversor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero:";
            // 
            // lblRom
            // 
            this.lblRom.AutoSize = true;
            this.lblRom.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblRom.ForeColor = System.Drawing.Color.Black;
            this.lblRom.Location = new System.Drawing.Point(13, 196);
            this.lblRom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRom.Name = "lblRom";
            this.lblRom.Size = new System.Drawing.Size(18, 26);
            this.lblRom.TabIndex = 12;
            this.lblRom.Text = " ";
            // 
            // txtRom
            // 
            this.txtRom.BackColor = System.Drawing.Color.White;
            this.txtRom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRom.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txtRom.ForeColor = System.Drawing.Color.Black;
            this.txtRom.Location = new System.Drawing.Point(121, 99);
            this.txtRom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRom.Name = "txtRom";
            this.txtRom.Size = new System.Drawing.Size(268, 33);
            this.txtRom.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(176)))), ((int)(((byte)(227)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(397, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConv
            // 
            this.btnConv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.btnConv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConv.FlatAppearance.BorderSize = 3;
            this.btnConv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnConv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(176)))), ((int)(((byte)(227)))));
            this.btnConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConv.ForeColor = System.Drawing.Color.White;
            this.btnConv.Location = new System.Drawing.Point(397, 91);
            this.btnConv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(150, 50);
            this.btnConv.TabIndex = 15;
            this.btnConv.Text = "Convertir";
            this.btnConv.UseVisualStyleBackColor = false;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 270);
            this.ControlBox = false;
            this.Controls.Add(this.btnConv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtRom);
            this.Controls.Add(this.lblRom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRom;
        private System.Windows.Forms.TextBox txtRom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConv;
    }
}

