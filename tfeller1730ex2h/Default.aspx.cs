using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tfeller1730ex2h
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox1aResult.Text = DateTime.Now.ToShortDateString();
            TextBox1bResult.Text = DateTime.Now.ToShortTimeString();
            TextBox2aResult.Text = DateTime.Today.ToShortDateString();
            TextBox2bResult.Text = DateTime.Today.ToShortTimeString();
            TextBox3aResult.Text = DateTime.Today.Year.ToString();
            TextBox3bResult.Text = DateTime.Today.Month.ToString();
            TextBox3cResult.Text = DateTime.Today.Day.ToString();
            TextBox4Result.Text = DateTime.Today.AddDays(90).ToShortDateString();
            TextBox5Result.Text = DateTime.Today.AddMonths(3).ToShortDateString();
            TextBox6Result.Text = Ex2hCalculations.DateCalc06(TextBox6a.Text, TextBox6b.Text, TextBox6c.Text);
            TextBox7Result.Text = Ex2hCalculations.DateCalc07(TextBox7a.Text);
            TextBox8Result.Text = Ex2hCalculations.DateCalc08(TextBox8a.Text);
            TextBox9Result.Text = Ex2hCalculations.DateCalc09(TextBox9a.Text, TextBox9b.Text);
            TextBox10Result.Text = Ex2hCalculations.DateCalc10(TextBox10a.Text, TextBox10b.Text);
        }

        protected void StringCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox11Result.Text = Ex2hCalculations.StringCalc01(TextBox11a.Text);
            TextBox12Result.Text = Ex2hCalculations.StringCalc02(TextBox12a.Text);
            TextBox13Result.Text = Ex2hCalculations.StringCalc03(TextBox13a.Text);
            TextBox14Result.Text = Ex2hCalculations.StringCalc04(TextBox14a.Text);
            TextBox15Result.Text = Ex2hCalculations.StringCalc05(TextBox15a.Text);
            TextBox16Result.Text = Ex2hCalculations.StringCalc06(TextBox16a.Text);
            TextBox17Result.Text = Ex2hCalculations.StringCalc07(TextBox17a.Text);
            //TextBox18Result.Text = Ex2hCalculations.StringCalc08(TextBox18a.Text);
            //TextBox19Result.Text = Ex2hCalculations.StringCalc09(TextBox19a.Text);
            //Label20Result.Text = Ex2hCalculations.StringCalc10(TextBox17a.Text, TextBox18a.Text, TextBox19a.Text);

        }
    }
}