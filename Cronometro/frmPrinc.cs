﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Cronometro.Options;
using Cronometro.Models;
using System.Linq;
using System.Collections.Generic;

namespace Cronometro
{
     public partial class frmPrinc : Form
    {

        Chrono Crono = new Chrono();
        TimeSpan initialTime;
        public frmPrinc()
        {
            InitializeComponent();
        }

        List<string> Tiempos = new List<string>();

        private void frmPrinc_Load(object sender, EventArgs e)
        {
            ToolTip ttp = new ToolTip
            {
                AutoPopDelay = 2000,
                InitialDelay = 1000,
                ReshowDelay = 200,
                ShowAlways = true
            };

            //ToolTips
            ttp.SetToolTip(txtCliente, "Nombre del cliente en el que se está trabajando.");
            ttp.SetToolTip(lblTimeInfo, "Tiempo transcurrido.");
            ttp.SetToolTip(btnIniciar, "Inicia el conteo de tiempo.");
            ttp.SetToolTip(btnDetener, "Detiene el conteo de tiempo con el cliente.");
            ttp.SetToolTip(btnInter, "Pausa el conteo.");
            ttp.SetToolTip(lstInterv, "Los tiempos seleccionados son copiados de forma automática.");

            lblTimeInfo.Text = Crono.ToString();
            lblTimeInfo.Font = new Font("DSEG7 Classic", 16, FontStyle.Regular);
            lblVersion.Text = Application.ProductVersion;
            this.Text += " v" +Application.ProductVersion;

            DateTime bkpDate = new DateTime();
            if (BackUp.Exists(out bkpDate))
                if (MessageBox.Show($"Existe un Back-Up de datos de {bkpDate} {Environment.NewLine} ¿Desea recuperarlo?",
                                     "BackUp Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    foreach (string item in BackUp.Load(bkpDate))
                        lstInterv.Items.Add(item);
                    lstInterv.SelectedIndex = lstInterv.Items.Count-1;
                }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!tmrSync.Enabled)
            {
                tmrSync.Enabled = true;
                //AgregarTiempo("Inicio");
                initialTime = Crono.Value();
                Crono.Start();
                btnIniciar.Image = Properties.Resources._002_play_ON;
                btnInter.Image = Properties.Resources._001_pause_OFF;
                btnDetener.Image = Properties.Resources._003_stop_OFF;
                lblTimeInfo.ForeColor = OptionManager.GetDisplayColor();
                lblTimeInfo.Visible = true;
                tmrPause.Enabled = false;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (tmrSync.Enabled || tmrPause.Enabled )
            {
                tmrSync.Enabled = false;
                tmrPause.Enabled = false;
                //txtTimeInfo.Text = Crono.ToString();
                lblTimeInfo.Text = Crono.ToString();
                Crono.Stop();
                AgregarTiempo();
                //btnReset.PerformClick();
                Crono.ResetValue();
                //txtTimeInfo.Text = Crono.ToString();
                lblTimeInfo.Text = Crono.ToString();
                txtCliente.Text = string.Empty;
                btnIniciar.Image = Properties.Resources._002_play_OFF;
                btnInter.Image = Properties.Resources._001_pause_OFF;
                btnDetener.Image = Properties.Resources._003_stop_ON;
                //txtTimeInfo.ForeColor = Color.Black;
                lblTimeInfo.ForeColor = Color.FromArgb(47, 47, 47);
                lblTimeInfo.Visible = true;
                if (OptionManager.GetBackUp())
                {
                    //Depura los bkp viejos teniendo en cuenta 10 veces el tiempo de bkp seleccionado
                    BackUp.Depure(DateTime.Now.AddMinutes(OptionManager.GetBackUpTime() * (-10)));
                    BackUp.Save(lstInterv.Items.Cast<string>().ToList());
                }
            }
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            if (!tmrPause.Enabled)
            {
                tmrSync.Enabled = false;
                //txtTimeInfo.Text = Crono.ToString();
                lblTimeInfo.Text = Crono.ToString();
                Crono.Stop();
                btnIniciar.Image = Properties.Resources._002_play_OFF;
                btnInter.Image = Properties.Resources._001_pause_ON;
                btnDetener.Image = Properties.Resources._003_stop_OFF;
                tmrPause.Enabled = true;
                if (OptionManager.GetBackUp())
                {
                    //Depura los bkp viejos teniendo en cuenta 10 veces el tiempo de bkp seleccionado
                    BackUp.Depure(DateTime.Now.AddMinutes(OptionManager.GetBackUpTime() * (-10)));
                    List<string> bkpList = lstInterv.Items.Cast<string>().ToList();
                    bkpList.Add(FormatearTiempo(txtCliente.Text, Crono));
                    BackUp.Save(bkpList);
                }
                //lblTimeInfo.Visible = true;
                //AgregarTiempo("Pausa");
            }
        }

        private void tmrSync_Tick(object sender, EventArgs e)
        {
            //txtTimeInfo.Text = Crono.ToString();
            lblTimeInfo.Text = Crono.ToString();
            if (OptionManager.GetPopUp())
            {
                if (Crono.Value().Minutes - initialTime.Minutes >= OptionManager.GetPopUpTime())
                {
                    btnInter.PerformClick();
                    ntfyReminder.Text = "Cronómetro";
                    //ntfyReminder.Visible = true;
                    ntfyReminder.ShowBalloonTip(10000, "¡Hola!", "¿Estás ahí? Acordate de frenar el cronómetro si no lo estás usando.", ToolTipIcon.Info);
                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Normal;
                    //MessageBox.Show("¿Estás ahí? El cronómetro está pausado hasta que me avises.", "¡Hola!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    initialTime = Crono.Value();
                    btnIniciar.PerformClick();
                }
            } 
            if(OptionManager.GetBackUp())
            {
                if (Crono.Value().Minutes - initialTime.Minutes >= OptionManager.GetBackUpTime())
                {
                    //Depura los bkp viejos teniendo en cuenta 10 veces el tiempo de bkp seleccionado
                    BackUp.Depure(DateTime.Now.AddMinutes(OptionManager.GetBackUpTime() * (-10)));
                    List<string> bkpList = lstInterv.Items.Cast<string>().ToList();
                    bkpList.Add(FormatearTiempo(txtCliente.Text, Crono));
                    BackUp.Save(bkpList);
                    initialTime = Crono.Value();
                }
            }
        }

        private void NtfyReminder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }

        private void lstInterv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = string.Empty;
            foreach (var item in lstInterv.SelectedItems)
            {
                data += item + Environment.NewLine;
            }
            Clipboard.SetText(data);
        }

        private void AgregarTiempo(string Accion = "")
        {
            Accion = !string.IsNullOrEmpty(Accion) ? OptionManager.GetSeparator() + Accion : Accion;
            string tiempo = FormatearTiempo(txtCliente.Text + Accion, Crono);
            lstInterv.Items.Add(tiempo);
            Tiempos.Add(tiempo.Replace(OptionManager.GetSeparator(),";"));
            lstInterv.SelectedIndex = lstInterv.Items.Count - 1;
        }

        private string FormatearTiempo(string texto, Chrono crono)
        {
            string separator = OptionManager.GetSeparator();
            switch (OptionManager.GetDisplayUnit())
            {
                case (int)OptionManager.units.Sexagecimal:
                    if (string.IsNullOrEmpty(texto))
                        return (string.Concat(DateTime.Now.ToString("dd/MM/yyyy"), separator, crono.ToString()));
                    else
                        return (string.Concat(DateTime.Now.ToString("dd/MM/yyyy"), separator, txtCliente.Text, separator, Crono.ToString()));
                case (int)OptionManager.units.Decimal:
                    if (string.IsNullOrEmpty(texto))
                        return (string.Concat(DateTime.Now.ToString("dd/MM/yyyy"), separator, crono.ToDecimalValue()));
                    else
                        return (string.Concat(DateTime.Now.ToString("dd/MM/yyyy"), separator, txtCliente.Text, separator, Crono.ToDecimalValue()));
                case (int)OptionManager.units.Both:
                    if (string.IsNullOrEmpty(texto))
                        return (string.Concat(DateTime.Now.ToString("dd/MM/yyyy"), separator, crono.ToString(), separator, Crono.ToDecimalValue()));
                    else
                        return (string.Concat(DateTime.Now.ToString("dd/MM/yyyy"), separator, txtCliente.Text, separator, Crono.ToString(), separator, Crono.ToDecimalValue()));
                default:
                    return string.Empty;
            }

        }

        private void frmPrinc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstInterv.Items.Count != 0)
                if (MessageBox.Show("¿Está seguro que desea cerrar? Se perderán los datos no copiados.",
                                    "Cerrar",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (OptionManager.GetBackUp())
                        BackUp.ToMasterBackUp(BackUp.GetLast());
                    BackUp.DepureAll();
                    BackUp.DepureMasterBackUp();
                }
        }

        private void tmrPause_Tick(object sender, EventArgs e)
        {
            //txtTimeInfo.Visible = !//txtTimeInfo.Visible;
            if (lblTimeInfo.ForeColor == OptionManager.GetDisplayColor())
                lblTimeInfo.ForeColor = Color.FromArgb(47, 47, 47);
            else
                lblTimeInfo.ForeColor = OptionManager.GetDisplayColor();
            //lblTimeInfo.Visible = !lblTimeInfo.Visible;
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIniciar.PerformClick();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settingsDialog = new frmSettings();
            settingsDialog.ShowDialog(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivos separados por coma (*.csv)|*.csv";
            saveDialog.FileName = $"timeExport_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            saveDialog.ShowDialog();
            System.IO.File.WriteAllLines(saveDialog.FileName, Tiempos);
        }
    }
    
}
