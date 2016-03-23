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
        static string[] hambOptions = { "Lettuce, tomato, and onions", "Ketchup, mustard, and mayo", "French fries" };
        static string[] pizzaOptions = { "Pepperoni", "Sausage", "Olives" };
        static string[] saladOptions = { "Croutons", "Bacon bits", "Bread sticks" };
        Dictionary<string[], double> priceinfo =  new Dictionary<string[],double>() { 
                                                      { hambOptions, 6.95 },
                                                      { pizzaOptions, 5.95 },
                                                      { saladOptions, 4.95 }
                                                 };
        double basePrice = 6.95;  // hamburger will be the default selection
        // and an array to store the entire order as it accumulates
        List<double[]> listOrders = new List<double[]>();

        public frmLunchOrder()
        {
            InitializeComponent();
        }
        
        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            // add tags to radiobuttons
            rdoHamburger.Tag = hambOptions;
            rdoPizza.Tag = pizzaOptions;
            rdoSalad.Tag = saladOptions;
        }

        // react to user changing which menu option is selected
        private void rdoMainCourse_CheckedChanged(object sender, EventArgs e)
        {
            // clear the checkboxes
            chkOne.Checked = false;
            chkTwo.Checked = false;
            chkThree.Checked = false;

            // clear the text boxes, in case they aren't cleared already
            clearItemTotals();

            // identify which button is checked and update the checkbox labels to reflect the selected option
            // also update base price
            // use Tag attribute and an interation to figure this out.
            foreach (RadioButton rb in gbxMainCourse.Controls)
            {
                if (rb.Checked)
                {
                    string[] toUpdate = (string[]) rb.Tag;
                    updateAddOns(toUpdate);
                    basePrice = priceinfo[toUpdate];
                    break; // we've found our item, break out of the loop.
                }
            }
        }

        private void clearItemTotals()
        {
            // clear the order total boxes
            txtItemTotal.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
        }

        //this clears the form so the user can start a brand-new order
        private void clearAllOrders()
        {
            // clear user input
            clearInput();
            
            // clear the array of orders and the listbox
            listOrders.Clear();
            lbxOrder.Items.Clear();

        }

        private void clearInput()
        {
            // clear the text boxes
            clearItemTotals();
            txtOrderTotal.Text = "";

            // clear the radio buttons and checkboxes - each groupbox has only one type of control
            foreach (RadioButton rb in gbxMainCourse.Controls)
                rb.Checked = false;
            foreach (CheckBox cb in gbxAddOns.Controls)
                cb.Checked = false;
        }

        private void updateAddOns(string[] addons)
        {
            int i = 0;
            foreach (CheckBox c in gbxAddOns.Controls)
            {
                c.Text = addons[i];
                i++;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // there isn't any user input that needs to be parsed or validated, so there shouldn't  
            // be a need for anything more elaborate than a generic try-catch block and an overflow error block
            try
            {
                // debugging:  throw new OverflowException();
                // update pricing info
                updatePriceInfo();
                // and update the listbox
                addOrderToList();
            }
            catch (OverflowException)
            {
                string msg = "It appears that your order has gotten too large.  Either start a 'new' order " +
                    "or delete some unneeded line items to continue.";
                string caption = "Order too large.";

                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                // give the user an error message that isn't uselessly cryptic.
                string msg = "An error has occurred.  You can share the details below with your IT staff to assist in troubleshooting:\n";
                msg += ex.Message.ToString() + "\n";
                msg += ex.ToString();
                string caption = "Error";

                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatePriceInfo()
        {
            // base price is set globally
            int numberOfSides = 0;
            foreach (CheckBox cb in gbxAddOns.Controls)
            {
                if (cb.Checked) numberOfSides++;
            }
            

            // figure out the subtotal and tax
            double subtotal = basePrice + (numberOfSides * 0.75);
            double tax = subtotal * 0.0775;  // 7.75% tax rate
            // and add them together for the total
            double orderTotal = subtotal + tax;

            // update the form with the results converted to currency format
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtItemTotal.Text = orderTotal.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addons_CheckedChanged(object sender, EventArgs e)
        {
            clearItemTotals();
        }

        // a method to add an order to the list box and to the order array so a grand total can be calculated
        private void addOrderToList() 
        {
            // stores an array of doubles representing the choices made so they can be retrieved later if needed
            double[] currentOrder = new double[7];
            
            // populate the array
            // start with the main course selection
            if (rdoHamburger.Checked) currentOrder[0] = 0;
            if (rdoPizza.Checked) currentOrder[0] = 1;
            if (rdoSalad.Checked) currentOrder[0] = 2;
            // add the sides
            currentOrder[1] = Convert.ToDouble(chkOne.Checked);
            currentOrder[2] = Convert.ToDouble(chkTwo.Checked);
            currentOrder[3] = Convert.ToDouble(chkThree.Checked);
            // and the order total info - strip off the leading dollar sign
            currentOrder[4] = Convert.ToDouble(txtSubtotal.Text.Substring(1));
            currentOrder[5] = Convert.ToDouble(txtTax.Text.Substring(1));
            currentOrder[6] = Convert.ToDouble(txtItemTotal.Text.Substring(1));

            // and add the order to the arry of orders
            listOrders.Add(currentOrder);

            // also parse the order info and convert it to a user-friendly string for the listbox
            string orderinfo = StringifyOrderInfo();

            // then add it to the list box showing all orders
            lbxOrder.Items.Add(orderinfo);

            // also generate a grand total
            updateOrderTotal();

        }

        private string StringifyOrderInfo()
        {
            string main = "";
            if (rdoHamburger.Checked) main += "Hamburger with:";
            if (rdoPizza.Checked) main += "Pizza with:";
            if (rdoSalad.Checked) main += "Salad with:";

            string sides = "";
            if (chkOne.Checked) sides += " " + chkOne.Text.ToLower() + ";";
            if (chkTwo.Checked)
            {
                sides += " " + chkTwo.Text.ToLower() + ";";
            }
            if (chkThree.Checked)
            {
                sides += " " + chkThree.Text.ToLower() + ";";
            }
            if (sides == "") sides = "no side items;";

            string moneyinfo = " Line item total: " + txtItemTotal.Text;

            string orderinfo = main + sides + moneyinfo;
            return orderinfo;
        }

        private void updateOrderTotal()
        {
            double grandTotal = 0;
            foreach (double[] order in listOrders)
            {
                grandTotal += order[6];  // sixth value is the order total.
            }
            txtOrderTotal.Text = grandTotal.ToString("c");
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            clearAllOrders();
            // set the hambruger option as the selected option.
            rdoHamburger.Checked = true;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int indexToRemove = lbxOrder.SelectedIndex;  // nb: -1 means no item selected.
            // MessageBox.Show("selected index is: " + indexToRemove);
            // notify the user if no item is selected
            if (indexToRemove == -1)
            {
                MessageBox.Show("You must select a line item to remove.", "No Line Selected");
            }
            else  // OK to proceed with removal
            {
                // remove entry from listbox and from array of orders
                lbxOrder.Items.RemoveAt(indexToRemove);
                listOrders.RemoveAt(indexToRemove);

                // and recalculate the order total
                updateOrderTotal();
            }
        }
    }
}
