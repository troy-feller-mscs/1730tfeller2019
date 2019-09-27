using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfeller1730ex1d
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void BrnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountEuro.Text = "0.00";
            txtAmountYen.Text = "0.00";
            txtAmountPeso.Text = "0.00";
            txtAmountPound.Text = "0.00";

            txtRateEuro.Text = "1.09410";
            txtRateYen.Text = "0.00926300";
            txtRatePeso.Text = "0.0507815";
            txtRatePound.Text = "1.22926";

            txtUSDEuro.Text = "0.00";
            txtUSDYen.Text = "0.00";
            txtUSDPeso.Text = "0.00";
            txtUSDPound.Text = "0.00";
        }

        private void poundTextChanged(object sender, EventArgs e)
        {
            txtUSDPound.Text = (
             Convert.ToDecimal(txtAmountPound.Text) * Convert.ToDecimal(txtRatePound.Text)
             ).ToString("0.00");
        }

        private void yenTextChanged(object sender, EventArgs e)
        {
            txtUSDYen.Text = (
             Convert.ToDecimal(txtAmountYen.Text) * Convert.ToDecimal(txtRateYen.Text)
             ).ToString("0.00");
        }

        private void pesoTextChanged(object sender, EventArgs e)
        {
            txtUSDPeso.Text = (
             Convert.ToDecimal(txtAmountPeso.Text) * Convert.ToDecimal(txtRatePeso.Text)
             ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
             Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
             ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDEuro.Text) + Convert.ToDecimal(txtUSDPound.Text) + Convert.ToDecimal(txtUSDPeso.Text) + Convert.ToDecimal(txtUSDYen.Text)
                ).ToString("0.00");

        }
    }
}
