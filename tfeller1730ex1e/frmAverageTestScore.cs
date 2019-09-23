using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfeller1730ex1e
{
    public partial class frmAverageTestScore : Form
    {
        public frmAverageTestScore()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                (Convert.ToDecimal(txtTestOne.Text) + Convert.ToDecimal(txtTestTwo.Text) + Convert.ToDecimal(txtTestThree.Text)) / 3
               ).ToString("0.00");

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAverage.Text = "";
            txtTestOne.Text = "0";
            txtTestThree.Text = "0";
            txtTestTwo.Text = "0";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
