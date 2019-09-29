using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfeller1730ex1f
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnBritish.BackgroundImage = picBritish.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "1.22926";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnBritish.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnBritish_Click(object sender, EventArgs e)
        {
            btnBritish.BackgroundImage = picBritish.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "1.22926";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnBritish.Text + ": ";
            txtCurrency.Focus();
            txtTotalUSD.Text = txtTotalUSD.Text;
        }

        private void BtnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnBritish.BackgroundImage = picBritishDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.00926300";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnJapan.Text + ": ";
            txtCurrency.Focus();
            txtTotalUSD.Text = txtTotalUSD.Text;
        }

        private void BtnMexico_Click(object sender, EventArgs e)
        {
            btnMexico.BackgroundImage = picMexico.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnBritish.BackgroundImage = picBritishDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.0507815";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnMexico.Text + ": ";
            txtCurrency.Focus();
            txtTotalUSD.Text = txtTotalUSD.Text;
        }

        private void BtnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnBritish.BackgroundImage = picBritishDim.Image;
            txtRate.Text = "1.09410";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnEuro.Text + ": ";
            txtCurrency.Focus();
            txtTotalUSD.Text = txtTotalUSD.Text;
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;

            txtTotalUSD.Text = (
                Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)
                ).ToString("0.00");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnBritish.BackgroundImage = picBritish.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "1.22926";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnBritish.Text + ": ";
            txtCurrency.Focus();
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = " ";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
