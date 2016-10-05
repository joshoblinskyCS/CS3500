using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class tipCalculator : Form
    {
        public tipCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void computeButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Computes the tip of a given input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void billTextbox_TextChanged(object sender, EventArgs e)
        {
            string bill = billTextbox.Text;

            // If the textbox is empty, do nothing
            if(bill == "") {
                computeTextbox.Text = "";
                return;
            }
            double billval = 0;

            // Attempt to parse the data in the textbox to a double for calculations.
            try
            {
                billval = Convert.ToDouble(bill);
            }
            // If an exception occurs, inform the user.
            catch (Exception)
            {
                computeTextbox.Text = "Invalid bill";
                return;
            }

            /*
             * Compute tip, reformat and send to result textbox. Note: N2 in the ToString function
             * formats the double to contain 2 decimal places.
             */

            // If no percentage input, return the bill itself.
            if(percentageTextbox.Text == "")
            {
                computeTextbox.Text = (billval).ToString("N2") + "";
                return;
            }
            else
            {
                // Attempt to parse percentage
                try
                {
                    // Attempt to parse to double and format for computation
                    double percentage = Convert.ToDouble(percentageTextbox.Text) * .01 + 1;

                    // Compute with tip
                    computeTextbox.Text = (billval * percentage).ToString("N2") + "";
                    return;
                }
                // If percentage value is invalid, let the user know.
                catch (Exception)
                {
                    computeTextbox.Text = "Invalid %";
                    return;
                }
               
            }

        }

        /// <summary>
        /// Called when changes are made to the percentages textbox. 
        /// Updates total bill on the fly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void percentageTextbox_TextChanged(object sender, EventArgs e)
        {
            billTextbox_TextChanged(sender, e);
        }
    }
}
