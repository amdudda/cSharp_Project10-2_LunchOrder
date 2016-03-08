using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj10_2_Dudda
{
    public partial class frmLunchOrder : Form
    {
        // store the check box labels as arrays to make them easy to reference and update
        string[] hambOptions = { "Lettuce, tomato, and onions", "Ketchup, mustard, and mayo", "French fries" };
        string[] pizzaOptions = { "Pepperoni", "Sausage", "Olives" };
        string[] saladOptions = { "Croutons", "Bacon bits", "Bread sticks" };
        double basePrice = 6.95;  // hamburger will be the default selection

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void rdoMainCourse_CheckedChanged(object sender, EventArgs e)
        {
            // clear the checkboxes
            chkOne.Checked = false;
            chkTwo.Checked = false;
            chkThree.Checked = false;

            // identify which button is checked and update the checkbox labels to reflect the selected option
            // also update base price
            if (rdoHamburger.Checked)
            {
                updateAddOns(hambOptions);
                basePrice = 6.95;
            }
            if (rdoPizza.Checked)
            {
                updateAddOns(pizzaOptions);
                basePrice = 5.95;
            }
            if (rdoSalad.Checked)
            {
                updateAddOns(saladOptions);
                basePrice = 4.95;
            }
        }

        private void updateAddOns(string[] addons)
        {
            chkOne.Text = addons[0];
            chkTwo.Text = addons[1];
            chkThree.Text = addons[2];
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            // set the hambruger option as the selected option.
            rdoHamburger.Checked = true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // base price is set globally
            // convert.toInt32 on a boolean converts true to 1.  let's take advantage of that!
            // https://msdn.microsoft.com/en-us/library/2cew9dz7(v=vs.110).aspx
            int numberOfSides = Convert.ToInt32(chkOne.Checked) + Convert.ToInt32(chkTwo.Checked) +
                Convert.ToInt32(chkThree.Checked);
            
            // figure out the subtotal and tax
            double subtotal = basePrice + (numberOfSides * 0.75);
            double tax = subtotal * 0.0775;  // 7.75% tax rate
            // and add them together for the total
            double orderTotal = subtotal + tax;

            // update the form with the results converted to currency format
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
