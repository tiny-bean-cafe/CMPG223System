namespace TinyBeanCafeSystem
{
    partial class frmBakedGoods
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
            this.cmdBakedGoods = new System.Windows.Forms.ComboBox();
            this.lstBakedGoods = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 157);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(302, 40);
            this.btnDone.TabIndex = 19;
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
            this.lblQty.TabIndex = 18;
            this.lblQty.Text = "Quantity:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(83, 55);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(77, 20);
            this.txtQty.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmdBakedGoods
            // 
            this.cmdBakedGoods.FormattingEnabled = true;
            this.cmdBakedGoods.Location = new System.Drawing.Point(21, 22);
            this.cmdBakedGoods.Name = "cmdBakedGoods";
            this.cmdBakedGoods.Size = new System.Drawing.Size(139, 21);
            this.cmdBakedGoods.TabIndex = 15;
            // 
            // lstBakedGoods
            // 
            this.lstBakedGoods.FormattingEnabled = true;
            this.lstBakedGoods.Location = new System.Drawing.Point(166, 21);
            this.lstBakedGoods.Name = "lstBakedGoods";
            this.lstBakedGoods.Size = new System.Drawing.Size(116, 121);
            this.lstBakedGoods.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lstQty);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 139);
            this.panel1.TabIndex = 20;
            // 
            // lstQty
            // 
            this.lstQty.FormattingEnabled = true;
            this.lstQty.Location = new System.Drawing.Point(269, 9);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(30, 121);
            this.lstQty.TabIndex = 0;
            // 
            // frmBakedGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 208);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmdBakedGoods);
            this.Controls.Add(this.lstBakedGoods);
            this.Controls.Add(this.panel1);
            this.Name = "frmBakedGoods";
            this.Text = "frmBakedGoods";
            this.Load += new System.EventHandler(this.FrmBakedGoods_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBakedGoods;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.ComboBox cmdBakedGoods;
        private System.Windows.Forms.ListBox lstQty;
    }
}