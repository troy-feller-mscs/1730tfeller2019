using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfeller1730ex2f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            //#1: if
            result1TextBox.Text = Ex2fCalculations.Calc01(Input1ATextBox.Text);

            //#2: if {block}
            result2TextBox.Text = Ex2fCalculations.Calc02(Input2ATextBox.Text);

            //#3: if else
            result3TextBox.Text = Ex2fCalculations.Calc03(Input3ATextBox.Text);

            //#4: if else if
            result4TextBox.Text = Ex2fCalculations.Calc04(Input4ATextBox.Text);

            //#5: Better Range Test
            result5TextBox.Text = Ex2fCalculations.Calc05(Input5ATextBox.Text);

            //#6: nested if statements
            result6TextBox.Text = Ex2fCalculations.Calc06(Input6ATextBox.Text, Input6BTextBox.Text);

            //#7 Validate input: non-empty string
            result7TextBox.Text = Ex2fCalculations.Calc07(Input7ATextBox.Text);

            // #8 Validate input, calculate quantity * price, shipping
            result8TextBox.Text = Ex2fCalculations.Calc08(Input8ATextBox.Text, Input8BTextBox.Text);

            // #9 Validate input, calculate difference * rate
            result9TextBox.Text = Ex2fCalculations.Calc09(Input9ATextBox.Text, Input9BTextBox.Text);

            // #10 Validate input, divide large num by small
            result10TextBox.Text = Ex2fCalculations.Calc10(Input10ATextBox.Text, Input10BTextBox.Text);
        }
    }
}
