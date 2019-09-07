namespace LogInPrototype
{
    partial class frmHotDrinks
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
            this.lstHotDrinks = new System.Windows.Forms.ListBox();
            this.cmdHotDrinks = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lstHotDrinks
            // 
            this.lstHotDrinks.FormattingEnabled = true;
            this.lstHotDrinks.Location = new System.Drawing.Point(166, 12);
            this.lstHotDrinks.Name = "lstHotDrinks";
            this.lstHotDrinks.Size = new System.Drawing.Size(136, 121);
            this.lstHotDrinks.TabIndex = 0;
            // 
            // cmdHotDrinks
            // 
            this.cmdHotDrinks.FormattingEnabled = true;
            this.cmdHotDrinks.Items.AddRange(new object[] {
            "Hot Chocolate",
            "Cappuccino",
            "Flat White"});
            this.cmdHotDrinks.Location = new System.Drawing.Point(21, 13);
            this.cmdHotDrinks.Name = "cmdHotDrinks";
            this.cmdHotDrinks.Size = new System.Drawing.Size(139, 21);
            this.cmdHotDrinks.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(83, 46);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(77, 20);
            this.txtQty.TabIndex = 3;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(18, 47);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(59, 16);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Quantity:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 148);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(302, 40);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 139);
            this.panel1.TabIndex = 6;
            // 
            // frmHotDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 200);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmdHotDrinks);
            this.Controls.Add(this.lstHotDrinks);
            this.Controls.Add(this.panel1);
            this.Name = "frmHotDrinks";
            this.Text = "Hot Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHotDrinks;
        private System.Windows.Forms.ComboBox cmdHotDrinks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel1;
    }
}