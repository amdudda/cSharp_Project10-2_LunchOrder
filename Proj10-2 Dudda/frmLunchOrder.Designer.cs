﻿namespace Proj10_2_Dudda
{
    partial class frmLunchOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.gbxAddOns = new System.Windows.Forms.GroupBox();
            this.chkThree = new System.Windows.Forms.CheckBox();
            this.chkTwo = new System.Windows.Forms.CheckBox();
            this.chkOne = new System.Windows.Forms.CheckBox();
            this.gbxOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.gbxMainCourse.SuspendLayout();
            this.gbxAddOns.SuspendLayout();
            this.gbxOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.M. Dudda - Project 10-2";
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdoSalad);
            this.gbxMainCourse.Controls.Add(this.rdoPizza);
            this.gbxMainCourse.Controls.Add(this.rdoHamburger);
            this.gbxMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMainCourse.Location = new System.Drawing.Point(85, 46);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(147, 96);
            this.gbxMainCourse.TabIndex = 1;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalad.Location = new System.Drawing.Point(24, 68);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.Text = "&Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoMainCourse_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPizza.Location = new System.Drawing.Point(24, 44);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "&Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoMainCourse_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Checked = true;
            this.rdoHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHamburger.Location = new System.Drawing.Point(24, 20);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "&Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoMainCourse_CheckedChanged);
            // 
            // gbxAddOns
            // 
            this.gbxAddOns.Controls.Add(this.chkThree);
            this.gbxAddOns.Controls.Add(this.chkTwo);
            this.gbxAddOns.Controls.Add(this.chkOne);
            this.gbxAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddOns.Location = new System.Drawing.Point(268, 46);
            this.gbxAddOns.Name = "gbxAddOns";
            this.gbxAddOns.Size = new System.Drawing.Size(200, 96);
            this.gbxAddOns.TabIndex = 2;
            this.gbxAddOns.TabStop = false;
            this.gbxAddOns.Text = "Add-on Items ($.75/each)";
            // 
            // chkThree
            // 
            this.chkThree.AutoSize = true;
            this.chkThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThree.Location = new System.Drawing.Point(27, 68);
            this.chkThree.Name = "chkThree";
            this.chkThree.Size = new System.Drawing.Size(81, 17);
            this.chkThree.TabIndex = 2;
            this.chkThree.Text = "French fries";
            this.chkThree.UseVisualStyleBackColor = true;
            this.chkThree.CheckedChanged += new System.EventHandler(this.addons_CheckedChanged);
            // 
            // chkTwo
            // 
            this.chkTwo.AutoSize = true;
            this.chkTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTwo.Location = new System.Drawing.Point(27, 44);
            this.chkTwo.Name = "chkTwo";
            this.chkTwo.Size = new System.Drawing.Size(161, 17);
            this.chkTwo.TabIndex = 1;
            this.chkTwo.Text = "Ketchup, mustard, and mayo";
            this.chkTwo.UseVisualStyleBackColor = true;
            this.chkTwo.CheckedChanged += new System.EventHandler(this.addons_CheckedChanged);
            // 
            // chkOne
            // 
            this.chkOne.AutoSize = true;
            this.chkOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOne.Location = new System.Drawing.Point(27, 20);
            this.chkOne.Name = "chkOne";
            this.chkOne.Size = new System.Drawing.Size(158, 17);
            this.chkOne.TabIndex = 0;
            this.chkOne.Text = "Lettuce, tomato, and onions";
            this.chkOne.UseVisualStyleBackColor = true;
            this.chkOne.CheckedChanged += new System.EventHandler(this.addons_CheckedChanged);
            // 
            // gbxOrderTotal
            // 
            this.gbxOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gbxOrderTotal.Controls.Add(this.label6);
            this.gbxOrderTotal.Controls.Add(this.txtItemTotal);
            this.gbxOrderTotal.Controls.Add(this.txtTax);
            this.gbxOrderTotal.Controls.Add(this.txtSubtotal);
            this.gbxOrderTotal.Controls.Add(this.label4);
            this.gbxOrderTotal.Controls.Add(this.label3);
            this.gbxOrderTotal.Controls.Add(this.label2);
            this.gbxOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderTotal.Location = new System.Drawing.Point(85, 161);
            this.gbxOrderTotal.Name = "gbxOrderTotal";
            this.gbxOrderTotal.Size = new System.Drawing.Size(265, 130);
            this.gbxOrderTotal.TabIndex = 3;
            this.gbxOrderTotal.TabStop = false;
            this.gbxOrderTotal.Text = "Order total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(128, 97);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Order total:";
            // 
            // txtItemTotal
            // 
            this.txtItemTotal.Location = new System.Drawing.Point(128, 71);
            this.txtItemTotal.Name = "txtItemTotal";
            this.txtItemTotal.ReadOnly = true;
            this.txtItemTotal.Size = new System.Drawing.Size(100, 20);
            this.txtItemTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(129, 45);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(129, 19);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Line item total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tax(7.75%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(378, 178);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(90, 23);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Add to &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbxOrder
            // 
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.Location = new System.Drawing.Point(22, 321);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(526, 134);
            this.lbxOrder.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Order details:";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(378, 208);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(90, 23);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "&New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(378, 238);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveItem.TabIndex = 9;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 476);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gbxOrderTotal);
            this.Controls.Add(this.gbxAddOns);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.label1);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbxAddOns.ResumeLayout(false);
            this.gbxAddOns.PerformLayout();
            this.gbxOrderTotal.ResumeLayout(false);
            this.gbxOrderTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox gbxAddOns;
        private System.Windows.Forms.CheckBox chkThree;
        private System.Windows.Forms.CheckBox chkTwo;
        private System.Windows.Forms.CheckBox chkOne;
        private System.Windows.Forms.GroupBox gbxOrderTotal;
        private System.Windows.Forms.TextBox txtItemTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

