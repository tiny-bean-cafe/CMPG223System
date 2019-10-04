namespace TinyBeanCafeSystem
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
            this.components = new System.ComponentModel.Container();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmdHotDrinks = new System.Windows.Forms.ComboBox();
            this.lstHotDrinks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(83, 55);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(56, 20);
            this.txtQty.TabIndex = 10;
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
            // cmdHotDrinks
            // 
            this.cmdHotDrinks.FormattingEnabled = true;
            this.cmdHotDrinks.Location = new System.Drawing.Point(21, 22);
            this.cmdHotDrinks.Name = "cmdHotDrinks";
            this.cmdHotDrinks.Size = new System.Drawing.Size(139, 21);
            this.cmdHotDrinks.TabIndex = 8;
            // 
            // lstHotDrinks
            // 
            this.lstHotDrinks.FormattingEnabled = true;
            this.lstHotDrinks.Location = new System.Drawing.Point(166, 21);
            this.lstHotDrinks.Name = "lstHotDrinks";
            this.lstHotDrinks.Size = new System.Drawing.Size(111, 121);
            this.lstHotDrinks.TabIndex = 7;
            this.lstHotDrinks.SelectedIndexChanged += new System.EventHandler(this.LstHotDrinks_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lstQty);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 139);
            this.panel1.TabIndex = 13;
            // 
            // lstQty
            // 
            this.lstQty.FormattingEnabled = true;
            this.lstQty.Location = new System.Drawing.Point(265, 9);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(34, 121);
            this.lstQty.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHotDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 209);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmdHotDrinks);
            this.Controls.Add(this.lstHotDrinks);
            this.Controls.Add(this.panel1);
            this.Name = "frmHotDrinks";
            this.Text = "frmHotDrinks";
            this.Load += new System.EventHandler(this.FrmHotDrinks_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.ComboBox cmdHotDrinks;
        public System.Windows.Forms.ListBox lstHotDrinks;
        private System.Windows.Forms.ListBox lstQty;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}