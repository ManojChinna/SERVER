using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcheverryAssign5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Declare Variables 
            string description = txtAsset.Text;
            int year = int.Parse(txtPurchaseYear.Text);
            double purchasePrice = double.Parse(txtPurchasePrice.Text);
            double depreciation = double.Parse(txtDepreciationRate.Text) / 100;
               

            CalculateDepreciation(purchasePrice, depreciation);

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description can not be empty", "Input Error ");
                return;
            }

        

        }



        private void CalculateDepreciation(double purchasePrice, double depreciation)
        {
            double currentBookValue = purchasePrice;
            double accumulatedDepreciation = 0;
            int yearCounter = 1;

            // Calculate depreciation 
            while (currentBookValue > 0.005)
            {
                // Calculate yearly depreciation
                double yearlyDepreciation = currentBookValue * depreciation;
                accumulatedDepreciation += yearlyDepreciation;
                double endOfYearValue = currentBookValue - yearlyDepreciation;

                // Display
                lstOutput.Items.Add($"Year {yearCounter}:");
                lstOutput.Items.Add($"  Start Book Value: {currentBookValue:C}");
                lstOutput.Items.Add($"  Depreciation Amount: {yearlyDepreciation:C}");
                lstOutput.Items.Add($"  Accumulated Depreciation: {accumulatedDepreciation:C}");
                lstOutput.Items.Add($"  End Book Value: {endOfYearValue:C}");
                lstOutput.Items.Add("--------------");

                // Book value update
                currentBookValue = endOfYearValue;
                yearCounter++;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAsset.Clear();
            txtPurchasePrice.Clear();
            txtPurchaseYear.Clear();
            txtDepreciationRate.Clear();
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
