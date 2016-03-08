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

    }
}
