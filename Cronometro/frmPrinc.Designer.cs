﻿namespace Cronometro
{
    partial class frmPrinc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinc));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.lstInterv = new System.Windows.Forms.ListBox();
            this.tmrSync = new System.Windows.Forms.Timer(this.components);
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tmrPause = new System.Windows.Forms.Timer(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.ntfyReminder = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTimeInfo = new System.Windows.Forms.Label();
            this.lblFondo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DimGray;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.Location = new System.Drawing.Point(12, 80);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(40, 40);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.DimGray;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Image = global::Cronometro.Properties.Resources._003_stop_ON;
            this.btnDetener.Location = new System.Drawing.Point(178, 80);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(40, 40);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnInter
            // 
            this.btnInter.BackColor = System.Drawing.Color.DimGray;
            this.btnInter.FlatAppearance.BorderSize = 0;
            this.btnInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInter.Image = ((System.Drawing.Image)(resources.GetObject("btnInter.Image")));
            this.btnInter.Location = new System.Drawing.Point(95, 80);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(40, 40);
            this.btnInter.TabIndex = 3;
            this.btnInter.UseVisualStyleBackColor = false;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // lstInterv
            // 
            this.lstInterv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInterv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstInterv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInterv.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lstInterv.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInterv.ForeColor = System.Drawing.Color.White;
            this.lstInterv.FormattingEnabled = true;
            this.lstInterv.ItemHeight = 16;
            this.lstInterv.Location = new System.Drawing.Point(228, 16);
            this.lstInterv.Name = "lstInterv";
            this.lstInterv.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstInterv.Size = new System.Drawing.Size(258, 128);
            this.lstInterv.TabIndex = 5;
            this.lstInterv.SelectedIndexChanged += new System.EventHandler(this.lstInterv_SelectedIndexChanged);
            // 
            // tmrSync
            // 
            this.tmrSync.Interval = 15;
            this.tmrSync.Tick += new System.EventHandler(this.tmrSync_Tick);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(61, 16);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(158, 14);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(12, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 16);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente:";
            // 
            // tmrPause
            // 
            this.tmrPause.Interval = 500;
            this.tmrPause.Tick += new System.EventHandler(this.tmrPause_Tick);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(446, 167);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 16);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Gray;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(12, 132);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 40);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Opciones";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // ntfyReminder
            // 
            this.ntfyReminder.Text = "Cronómetro";
            this.ntfyReminder.Visible = true;
            // 
            // lblTimeInfo
            // 
            this.lblTimeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblTimeInfo.Location = new System.Drawing.Point(57, 49);
            this.lblTimeInfo.Name = "lblTimeInfo";
            this.lblTimeInfo.Size = new System.Drawing.Size(140, 25);
            this.lblTimeInfo.TabIndex = 10;
            this.lblTimeInfo.Text = "00:00:00";
            // 
            // lblFondo
            // 
            this.lblFondo.AutoSize = true;
            this.lblFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblFondo.Location = new System.Drawing.Point(57, 49);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(96, 25);
            this.lblFondo.TabIndex = 11;
            this.lblFondo.Text = "88:88:88";
            // 
            // frmPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(495, 185);
            this.Controls.Add(this.lblTimeInfo);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lstInterv);
            this.Controls.Add(this.btnInter);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(422, 184);
            this.Name = "frmPrinc";
            this.Text = "Cronómetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrinc_FormClosing);
            this.Load += new System.EventHandler(this.frmPrinc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.ListBox lstInterv;
        private System.Windows.Forms.Timer tmrSync;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Timer tmrPause;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.NotifyIcon ntfyReminder;
        private System.Windows.Forms.Label lblTimeInfo;
        //private WinFormsControls.TransparentLabel lblTimeInfo;
        private System.Windows.Forms.Label lblFondo;
    }
}

