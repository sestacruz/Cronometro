using System;
using System.Windows.Forms;
using Cronometro.Options;
using System.Drawing;

namespace Cronometro
{
    public partial class frmSettings : Form
    {
        int actualUnit = OptionManager.GetDisplayUnit(),
            actualRemindTime = OptionManager.GetPopUpTime(),
            actualBkpTime = OptionManager.GetBackUpTime();
        bool actualRemind = OptionManager.GetPopUp(),
             actualBkp = OptionManager.GetBackUp();
        Color actualColor = OptionManager.GetDisplayColor();
        string actualSeparator = OptionManager.GetSeparator();

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            switch (actualUnit)
            {
                case (int)OptionManager.units.Decimal:
                    rdDec.Select();
                    break;
                case (int)OptionManager.units.Sexagecimal:
                    rdSex.Select();
                    break;
            }
            chkRemind.Checked = actualRemind;
            txtMin.Text = actualRemindTime.ToString();
            txtMin.Enabled = actualRemind;
            chkBkp.Checked = actualBkp;
            txtBkp.Text = actualBkpTime.ToString();
            txtBkp.Enabled = actualBkp;
            lblEjemplo.Font = new Font("DSEG7 Classic", 16, FontStyle.Regular);
            lblEjemplo.ForeColor = actualColor;
            txtSeparator.Text = actualSeparator;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdDec_CheckedChanged(object sender, EventArgs e)
        {
            actualUnit = (int)OptionManager.units.Decimal;
        }

        private void rdSex_CheckedChanged(object sender, EventArgs e)
        {
            actualUnit = (int)OptionManager.units.Sexagecimal;
        }

        private void brnSave_Click(object sender, EventArgs e)
        {
            OptionManager.SetDisplayUnit(actualUnit);
            OptionManager.SetPopUp(chkRemind.Checked);
            OptionManager.SetBackUp(chkBkp.Checked);
            OptionManager.SetDisplayColor(actualColor);
            if (chkRemind.Checked)
                OptionManager.SetPopUpTime(Convert.ToInt32(txtMin.Text));
            if (chkBkp.Checked)
                OptionManager.SetBackUpTime(Convert.ToInt32(txtBkp.Text));
            OptionManager.SetSeparator(txtSeparator.Text);
            MessageBox.Show("Datos guardados correctamente.\n" +
                            "Los cambios se verán reflejados a partir de ahora, no se modificarán los datos ya adquiridos.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void chkBkp_CheckedChanged(object sender, EventArgs e)
        {
            txtBkp.Enabled = chkBkp.Checked;
        }

        private void chkBoth_CheckedChanged(object sender, EventArgs e)
        {
            rdDec.Enabled = !chkBoth.Checked;
            rdSex.Enabled = !chkBoth.Checked;
            if (chkBoth.Checked)
                actualUnit = (int)OptionManager.units.Both;
            else if (rdDec.Checked)
                actualUnit = (int)OptionManager.units.Decimal;
            else
                actualUnit = (int)OptionManager.units.Sexagecimal;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            colorDiag.Color = OptionManager.GetDisplayColor();
            if (colorDiag.ShowDialog() == DialogResult.OK)
                actualColor=colorDiag.Color;
            
            lblEjemplo.ForeColor = actualColor;
        }

        private void chkRemind_CheckedChanged(object sender, EventArgs e)
        {
            txtMin.Enabled = chkRemind.Checked;
        }
    }
}
