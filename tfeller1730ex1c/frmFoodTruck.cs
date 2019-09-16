using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfeller1730ex1c
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                   4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                   5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (
                   Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");
            txtTax.Text = (
                 0.06875m * Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");
            txtTotal.Text = (
                Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0.00";
            txtHotDogsSubtotal.Text = "0.00";
            txtHamburgers.Text = "0.00";
            txtHamburgersSubtotal.Text = "0.00";
            txtPretaxTotal.Text = "0.00";
            txtTax.Text = "0.00";
            txtTotal.Text = "0.00";

            txtHotDogs.Focus();
        }
    }
}
