using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TipAmount_Click(object sender, EventArgs e)
        {

        }

        private void CalcTotal_Click(object sender, EventArgs e)
        {
            Double.TryParse(TotalBillBox.Text, out double result);
            Double.TryParse(TipPercentageBox.Text, out double percentage);
            //float percentage2 = percentage/100 + result;
            double result2 = (percentage / 100 * result) + result;
            TipAmountBox.Text = "" + percentage * result / 100;
            CalculatedTotalBox.Text = "" + result2;
        }

        private void TipAmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatedTotalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TipPercentageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalBillBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalBill_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
