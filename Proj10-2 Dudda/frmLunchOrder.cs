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
            if (rdoHamburger.Checked) updateAddOns(hambOptions);
            if (rdoPizza.Checked) updateAddOns(pizzaOptions);
            if (rdoSalad.Checked) updateAddOns(saladOptions);
        }

        private void updateAddOns(string[] addons)
        {
            chkOne.Text = addons[0];
            chkTwo.Text = addons[1];
            chkThree.Text = addons[2];
        }

        
    }
}
