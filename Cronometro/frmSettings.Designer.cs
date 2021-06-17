namespace Cronometro
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpUni = new System.Windows.Forms.GroupBox();
            this.chkBoth = new System.Windows.Forms.CheckBox();
            this.rdSex = new System.Windows.Forms.RadioButton();
            this.rdDec = new System.Windows.Forms.RadioButton();
            this.chkRemind = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.brnSave = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.grpReminder = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.colorDiag = new System.Windows.Forms.ColorDialog();
            this.grpBkp = new System.Windows.Forms.GroupBox();
            this.txtBkp = new System.Windows.Forms.TextBox();
            this.chkBkp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnElegir = new System.Windows.Forms.Button();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.grpUni.SuspendLayout();
            this.grpReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.grpBkp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUni
            // 
            this.grpUni.Controls.Add(this.chkBoth);
            this.grpUni.Controls.Add(this.rdSex);
            this.grpUni.Controls.Add(this.rdDec);
            this.grpUni.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUni.ForeColor = System.Drawing.Color.White;
            this.grpUni.Location = new System.Drawing.Point(12, 12);
            this.grpUni.Name = "grpUni";
            this.grpUni.Size = new System.Drawing.Size(218, 74);
            this.grpUni.TabIndex = 0;
            this.grpUni.TabStop = false;
            this.grpUni.Text = "Unidades";
            // 
            // chkBoth
            // 
            this.chkBoth.AutoSize = true;
            this.chkBoth.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoth.ForeColor = System.Drawing.Color.White;
            this.chkBoth.Location = new System.Drawing.Point(74, 48);
            this.chkBoth.Name = "chkBoth";
            this.chkBoth.Size = new System.Drawing.Size(64, 20);
            this.chkBoth.TabIndex = 2;
            this.chkBoth.Text = "Ambas";
            this.chkBoth.UseVisualStyleBackColor = true;
            this.chkBoth.CheckedChanged += new System.EventHandler(this.chkBoth_CheckedChanged);
            // 
            // rdSex
            // 
            this.rdSex.AutoSize = true;
            this.rdSex.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSex.ForeColor = System.Drawing.Color.White;
            this.rdSex.Location = new System.Drawing.Point(105, 19);
            this.rdSex.Name = "rdSex";
            this.rdSex.Size = new System.Drawing.Size(107, 20);
            this.rdSex.TabIndex = 1;
            this.rdSex.TabStop = true;
            this.rdSex.Text = "Sexagecimales";
            this.rdSex.UseVisualStyleBackColor = true;
            this.rdSex.CheckedChanged += new System.EventHandler(this.rdSex_CheckedChanged);
            // 
            // rdDec
            // 
            this.rdDec.AutoSize = true;
            this.rdDec.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDec.ForeColor = System.Drawing.Color.White;
            this.rdDec.Location = new System.Drawing.Point(6, 19);
            this.rdDec.Name = "rdDec";
            this.rdDec.Size = new System.Drawing.Size(81, 20);
            this.rdDec.TabIndex = 0;
            this.rdDec.TabStop = true;
            this.rdDec.Text = "Decimales";
            this.rdDec.UseVisualStyleBackColor = true;
            this.rdDec.CheckedChanged += new System.EventHandler(this.rdDec_CheckedChanged);
            // 
            // chkRemind
            // 
            this.chkRemind.AutoSize = true;
            this.chkRemind.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemind.ForeColor = System.Drawing.Color.White;
            this.chkRemind.Location = new System.Drawing.Point(7, 25);
            this.chkRemind.Name = "chkRemind";
            this.chkRemind.Size = new System.Drawing.Size(78, 20);
            this.chkRemind.TabIndex = 1;
            this.chkRemind.Text = "Activado";
            this.chkRemind.UseVisualStyleBackColor = true;
            this.chkRemind.CheckedChanged += new System.EventHandler(this.chkRemind_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // brnSave
            // 
            this.brnSave.BackColor = System.Drawing.Color.Gray;
            this.brnSave.FlatAppearance.BorderSize = 0;
            this.brnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSave.ForeColor = System.Drawing.Color.White;
            this.brnSave.Location = new System.Drawing.Point(155, 373);
            this.brnSave.Name = "brnSave";
            this.brnSave.Size = new System.Drawing.Size(75, 23);
            this.brnSave.TabIndex = 3;
            this.brnSave.Text = "Guardar";
            this.brnSave.UseVisualStyleBackColor = false;
            this.brnSave.Click += new System.EventHandler(this.brnSave_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(6, 49);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(144, 16);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Recordar cada          min.";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Gray;
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.ForeColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(96, 46);
            this.txtMin.MaxLength = 3;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(24, 14);
            this.txtMin.TabIndex = 0;
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // grpReminder
            // 
            this.grpReminder.Controls.Add(this.txtMin);
            this.grpReminder.Controls.Add(this.chkRemind);
            this.grpReminder.Controls.Add(this.lblMin);
            this.grpReminder.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReminder.ForeColor = System.Drawing.Color.White;
            this.grpReminder.Location = new System.Drawing.Point(12, 92);
            this.grpReminder.Name = "grpReminder";
            this.grpReminder.Size = new System.Drawing.Size(218, 78);
            this.grpReminder.TabIndex = 6;
            this.grpReminder.TabStop = false;
            this.grpReminder.Text = "Recordatorio de actividad";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // grpBkp
            // 
            this.grpBkp.Controls.Add(this.txtBkp);
            this.grpBkp.Controls.Add(this.chkBkp);
            this.grpBkp.Controls.Add(this.label1);
            this.grpBkp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBkp.ForeColor = System.Drawing.Color.White;
            this.grpBkp.Location = new System.Drawing.Point(12, 176);
            this.grpBkp.Name = "grpBkp";
            this.grpBkp.Size = new System.Drawing.Size(218, 78);
            this.grpBkp.TabIndex = 8;
            this.grpBkp.TabStop = false;
            this.grpBkp.Text = "BackUp actividad";
            // 
            // txtBkp
            // 
            this.txtBkp.BackColor = System.Drawing.Color.Gray;
            this.txtBkp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBkp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBkp.ForeColor = System.Drawing.Color.White;
            this.txtBkp.Location = new System.Drawing.Point(88, 46);
            this.txtBkp.MaxLength = 3;
            this.txtBkp.Name = "txtBkp";
            this.txtBkp.Size = new System.Drawing.Size(24, 14);
            this.txtBkp.TabIndex = 5;
            // 
            // chkBkp
            // 
            this.chkBkp.AutoSize = true;
            this.chkBkp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBkp.ForeColor = System.Drawing.Color.White;
            this.chkBkp.Location = new System.Drawing.Point(7, 25);
            this.chkBkp.Name = "chkBkp";
            this.chkBkp.Size = new System.Drawing.Size(78, 20);
            this.chkBkp.TabIndex = 1;
            this.chkBkp.Text = "Activado";
            this.chkBkp.UseVisualStyleBackColor = true;
            this.chkBkp.CheckedChanged += new System.EventHandler(this.chkBkp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Realizar cada          min.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnElegir);
            this.groupBox1.Controls.Add(this.lblEjemplo);
            this.groupBox1.Controls.Add(this.lblDisp);
            this.groupBox1.Controls.Add(this.txtSeparator);
            this.groupBox1.Controls.Add(this.lblSeparator);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 94);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato";
            // 
            // btnElegir
            // 
            this.btnElegir.BackColor = System.Drawing.Color.Gray;
            this.btnElegir.FlatAppearance.BorderSize = 0;
            this.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegir.Location = new System.Drawing.Point(137, 58);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 8;
            this.btnElegir.Text = "Elegir Color";
            this.btnElegir.UseVisualStyleBackColor = false;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(68, 58);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(14, 16);
            this.lblEjemplo.TabIndex = 7;
            this.lblEjemplo.Text = "8";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(9, 58);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(46, 16);
            this.lblDisp.TabIndex = 6;
            this.lblDisp.Text = "Display";
            // 
            // txtSeparator
            // 
            this.txtSeparator.BackColor = System.Drawing.Color.Gray;
            this.txtSeparator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeparator.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeparator.ForeColor = System.Drawing.Color.White;
            this.txtSeparator.Location = new System.Drawing.Point(84, 30);
            this.txtSeparator.MaxLength = 1;
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(24, 14);
            this.txtSeparator.TabIndex = 5;
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.ForeColor = System.Drawing.Color.White;
            this.lblSeparator.Location = new System.Drawing.Point(9, 30);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(69, 16);
            this.lblSeparator.TabIndex = 4;
            this.lblSeparator.Text = "Separador:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(242, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBkp);
            this.Controls.Add(this.grpReminder);
            this.Controls.Add(this.brnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpUni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpUni.ResumeLayout(false);
            this.grpUni.PerformLayout();
            this.grpReminder.ResumeLayout(false);
            this.grpReminder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.grpBkp.ResumeLayout(false);
            this.grpBkp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUni;
        private System.Windows.Forms.RadioButton rdSex;
        private System.Windows.Forms.RadioButton rdDec;
        private System.Windows.Forms.CheckBox chkRemind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button brnSave;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.CheckBox chkBoth;
        private System.Windows.Forms.GroupBox grpReminder;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColorDialog colorDiag;
        private System.Windows.Forms.GroupBox grpBkp;
        private System.Windows.Forms.TextBox txtBkp;
        private System.Windows.Forms.CheckBox chkBkp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Label lblDisp;
    }
}