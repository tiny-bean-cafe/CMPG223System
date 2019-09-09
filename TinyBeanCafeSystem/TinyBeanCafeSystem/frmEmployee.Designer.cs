namespace TinyBeanCafeSystem
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColdDrinks = new System.Windows.Forms.Button();
            this.btnHotDrinks = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalDue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.blOrderNum = new System.Windows.Forms.Label();
            this.lblDiscountHeading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lstOrderTotal = new System.Windows.Forms.ListBox();
            this.lstOrderEach = new System.Windows.Forms.ListBox();
            this.lstOrderQty = new System.Windows.Forms.ListBox();
            this.lblTotalHead = new System.Windows.Forms.Label();
            this.lblEach = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lstOrderName = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBakedGoods = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripOwner";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnColdDrinks
            // 
            this.btnColdDrinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColdDrinks.BackgroundImage")));
            this.btnColdDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColdDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColdDrinks.ForeColor = System.Drawing.Color.White;
            this.btnColdDrinks.Location = new System.Drawing.Point(24, 221);
            this.btnColdDrinks.Name = "btnColdDrinks";
            this.btnColdDrinks.Size = new System.Drawing.Size(263, 78);
            this.btnColdDrinks.TabIndex = 2;
            this.btnColdDrinks.Text = "Cold Drinks";
            this.btnColdDrinks.UseVisualStyleBackColor = true;
            // 
            // btnHotDrinks
            // 
            this.btnHotDrinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotDrinks.BackgroundImage")));
            this.btnHotDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotDrinks.ForeColor = System.Drawing.Color.White;
            this.btnHotDrinks.Location = new System.Drawing.Point(24, 28);
            this.btnHotDrinks.Name = "btnHotDrinks";
            this.btnHotDrinks.Size = new System.Drawing.Size(263, 78);
            this.btnHotDrinks.TabIndex = 0;
            this.btnHotDrinks.Text = "Hot Drinks";
            this.btnHotDrinks.UseVisualStyleBackColor = true;
            this.btnHotDrinks.Click += new System.EventHandler(this.BtnHotDrinks_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(278, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 25);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "R0.00";
            // 
            // lblBalDue
            // 
            this.lblBalDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalDue.AutoSize = true;
            this.lblBalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalDue.ForeColor = System.Drawing.Color.Red;
            this.lblBalDue.Location = new System.Drawing.Point(254, 61);
            this.lblBalDue.Name = "lblBalDue";
            this.lblBalDue.Size = new System.Drawing.Size(93, 25);
            this.lblBalDue.TabIndex = 18;
            this.lblBalDue.Text = "R000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "TOTAL:";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(95, 65);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(52, 20);
            this.lblTax.TabIndex = 16;
            this.lblTax.Text = "R0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Balance Due:";
            // 
            // blOrderNum
            // 
            this.blOrderNum.AutoSize = true;
            this.blOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blOrderNum.Location = new System.Drawing.Point(168, 37);
            this.blOrderNum.Name = "blOrderNum";
            this.blOrderNum.Size = new System.Drawing.Size(49, 16);
            this.blOrderNum.TabIndex = 22;
            this.blOrderNum.Text = "Order#";
            // 
            // lblDiscountHeading
            // 
            this.lblDiscountHeading.AutoSize = true;
            this.lblDiscountHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountHeading.Location = new System.Drawing.Point(5, 10);
            this.lblDiscountHeading.Name = "lblDiscountHeading";
            this.lblDiscountHeading.Size = new System.Drawing.Size(72, 16);
            this.lblDiscountHeading.TabIndex = 10;
            this.lblDiscountHeading.Text = "Discount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sub Total:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(95, 37);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(52, 20);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "R0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(95, 7);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 20);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "R0.00";
            // 
            // lstOrderTotal
            // 
            this.lstOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderTotal.FormattingEnabled = true;
            this.lstOrderTotal.ItemHeight = 16;
            this.lstOrderTotal.Location = new System.Drawing.Point(271, 77);
            this.lstOrderTotal.Name = "lstOrderTotal";
            this.lstOrderTotal.Size = new System.Drawing.Size(88, 148);
            this.lstOrderTotal.TabIndex = 9;
            // 
            // lstOrderEach
            // 
            this.lstOrderEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderEach.FormattingEnabled = true;
            this.lstOrderEach.ItemHeight = 16;
            this.lstOrderEach.Location = new System.Drawing.Point(204, 77);
            this.lstOrderEach.Name = "lstOrderEach";
            this.lstOrderEach.Size = new System.Drawing.Size(62, 148);
            this.lstOrderEach.TabIndex = 4;
            // 
            // lstOrderQty
            // 
            this.lstOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderQty.FormattingEnabled = true;
            this.lstOrderQty.ItemHeight = 16;
            this.lstOrderQty.Location = new System.Drawing.Point(168, 77);
            this.lstOrderQty.Name = "lstOrderQty";
            this.lstOrderQty.Size = new System.Drawing.Size(30, 148);
            this.lstOrderQty.TabIndex = 3;
            // 
            // lblTotalHead
            // 
            this.lblTotalHead.AutoSize = true;
            this.lblTotalHead.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHead.Location = new System.Drawing.Point(255, 2);
            this.lblTotalHead.Name = "lblTotalHead";
            this.lblTotalHead.Size = new System.Drawing.Size(36, 13);
            this.lblTotalHead.TabIndex = 6;
            this.lblTotalHead.Text = "Total";
            // 
            // lblEach
            // 
            this.lblEach.AutoSize = true;
            this.lblEach.BackColor = System.Drawing.Color.Transparent;
            this.lblEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEach.Location = new System.Drawing.Point(187, 2);
            this.lblEach.Name = "lblEach";
            this.lblEach.Size = new System.Drawing.Size(36, 13);
            this.lblEach.TabIndex = 7;
            this.lblEach.Text = "Each";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(151, 2);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Qty";
            // 
            // lstOrderName
            // 
            this.lstOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderName.FormattingEnabled = true;
            this.lstOrderName.ItemHeight = 16;
            this.lstOrderName.Location = new System.Drawing.Point(17, 77);
            this.lstOrderName.Name = "lstOrderName";
            this.lstOrderName.Size = new System.Drawing.Size(145, 148);
            this.lstOrderName.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblTotalHead);
            this.panel3.Controls.Add(this.lblEach);
            this.panel3.Controls.Add(this.lblQty);
            this.panel3.Location = new System.Drawing.Point(17, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 22);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(8, 12);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(138, 20);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(470, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Search";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(341, 23);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(111, 28);
            this.btnOrders.TabIndex = 12;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(211, 24);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(114, 28);
            this.btnTab.TabIndex = 11;
            this.btnTab.Text = "Customer Tab";
            this.btnTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tiny Bean Café";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDiscountHeading);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblBalDue);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Location = new System.Drawing.Point(12, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 104);
            this.panel2.TabIndex = 20;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnColdDrinks);
            this.pnlMenu.Controls.Add(this.btnBakedGoods);
            this.pnlMenu.Controls.Add(this.btnHotDrinks);
            this.pnlMenu.Location = new System.Drawing.Point(377, 57);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(311, 376);
            this.pnlMenu.TabIndex = 13;
            // 
            // btnBakedGoods
            // 
            this.btnBakedGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBakedGoods.BackgroundImage")));
            this.btnBakedGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBakedGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakedGoods.ForeColor = System.Drawing.Color.White;
            this.btnBakedGoods.Location = new System.Drawing.Point(24, 119);
            this.btnBakedGoods.Name = "btnBakedGoods";
            this.btnBakedGoods.Size = new System.Drawing.Size(263, 96);
            this.btnBakedGoods.TabIndex = 1;
            this.btnBakedGoods.Text = "Baked Goods";
            this.btnBakedGoods.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.blOrderNum);
            this.panel1.Controls.Add(this.lstOrderTotal);
            this.panel1.Controls.Add(this.lstOrderEach);
            this.panel1.Controls.Add(this.lstOrderQty);
            this.panel1.Controls.Add(this.lstOrderName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Location = new System.Drawing.Point(4, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 376);
            this.panel1.TabIndex = 10;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 440);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnColdDrinks;
        private System.Windows.Forms.Button btnHotDrinks;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label blOrderNum;
        private System.Windows.Forms.Label lblDiscountHeading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ListBox lstOrderTotal;
        private System.Windows.Forms.ListBox lstOrderEach;
        private System.Windows.Forms.ListBox lstOrderQty;
        private System.Windows.Forms.Label lblTotalHead;
        private System.Windows.Forms.Label lblEach;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ListBox lstOrderName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnBakedGoods;
        private System.Windows.Forms.Panel panel1;
    }
}