namespace TinyBeanCafeSystem
{
    partial class frmColdDrinks
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
            this.btnDone = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmdColdDrinks = new System.Windows.Forms.ComboBox();
            this.lstColdDrinks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 157);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(302, 40);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(18, 56);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(59, 16);
            this.lblQty.TabIndex = 11;
            this.lblQty.Text = "Quantity:";
            this.lblQty.Click += new System.EventHandler(this.LblQty_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(83, 55);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(77, 20);
            this.txtQty.TabIndex = 10;
            this.txtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmdColdDrinks
            // 
            this.cmdColdDrinks.FormattingEnabled = true;
            this.cmdColdDrinks.Items.AddRange(new object[] {
            "Hot Chocolate",
            "Cappuccino",
            "Flat White"});
            this.cmdColdDrinks.Location = new System.Drawing.Point(21, 22);
            this.cmdColdDrinks.Name = "cmdColdDrinks";
            this.cmdColdDrinks.Size = new System.Drawing.Size(139, 21);
            this.cmdColdDrinks.TabIndex = 8;
            this.cmdColdDrinks.SelectedIndexChanged += new System.EventHandler(this.CmdColdDrinks_SelectedIndexChanged);
            // 
            // lstColdDrinks
            // 
            this.lstColdDrinks.FormattingEnabled = true;
            this.lstColdDrinks.Location = new System.Drawing.Point(166, 21);
            this.lstColdDrinks.Name = "lstColdDrinks";
            this.lstColdDrinks.Size = new System.Drawing.Size(136, 121);
            this.lstColdDrinks.TabIndex = 7;
            this.lstColdDrinks.SelectedIndexChanged += new System.EventHandler(this.LstColdDrinks_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 139);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // frmColdDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 205);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmdColdDrinks);
            this.Controls.Add(this.lstColdDrinks);
            this.Controls.Add(this.panel1);
            this.Name = "frmColdDrinks";
            this.Text = "frmColdDrinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmdColdDrinks;
        private System.Windows.Forms.ListBox lstColdDrinks;
        private System.Windows.Forms.Panel panel1;
    }
}