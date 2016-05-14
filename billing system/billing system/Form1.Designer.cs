namespace billing_system
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnremovefromlist = new System.Windows.Forms.Button();
            this.btnaddtolist = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblnettotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblgrosstotal = new System.Windows.Forms.Label();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Green Super Market Billing System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------------------";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.txtrate);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtproductname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Entry";
            // 
            // txtamount
            // 
            this.txtamount.Enabled = false;
            this.txtamount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(456, 67);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(196, 30);
            this.txtamount.TabIndex = 9;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(456, 31);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(196, 30);
            this.txtrate.TabIndex = 8;
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.ForeColor = System.Drawing.Color.Black;
            this.txtquantity.Location = new System.Drawing.Point(134, 67);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(196, 30);
            this.txtquantity.TabIndex = 7;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity:";
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.Location = new System.Drawing.Point(134, 28);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(196, 30);
            this.txtproductname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnremovefromlist);
            this.panel1.Controls.Add(this.btnaddtolist);
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 52);
            this.panel1.TabIndex = 4;
            // 
            // btnremovefromlist
            // 
            this.btnremovefromlist.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovefromlist.Location = new System.Drawing.Point(281, 3);
            this.btnremovefromlist.Name = "btnremovefromlist";
            this.btnremovefromlist.Size = new System.Drawing.Size(204, 42);
            this.btnremovefromlist.TabIndex = 1;
            this.btnremovefromlist.Text = "Remove from List";
            this.btnremovefromlist.UseVisualStyleBackColor = true;
            // 
            // btnaddtolist
            // 
            this.btnaddtolist.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtolist.Location = new System.Drawing.Point(22, 3);
            this.btnaddtolist.Name = "btnaddtolist";
            this.btnaddtolist.Size = new System.Drawing.Size(204, 42);
            this.btnaddtolist.TabIndex = 0;
            this.btnaddtolist.Text = "Add to List";
            this.btnaddtolist.UseVisualStyleBackColor = true;
            this.btnaddtolist.Click += new System.EventHandler(this.btnaddtolist_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvresult);
            this.panel2.Location = new System.Drawing.Point(12, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 193);
            this.panel2.TabIndex = 5;
            // 
            // dgvresult
            // 
            this.dgvresult.AllowUserToAddRows = false;
            this.dgvresult.AllowUserToDeleteRows = false;
            this.dgvresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.productname,
            this.quantity,
            this.rate,
            this.amount});
            this.dgvresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvresult.Location = new System.Drawing.Point(0, 0);
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.Size = new System.Drawing.Size(680, 189);
            this.dgvresult.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gross total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Net total:";
            // 
            // lblnettotal
            // 
            this.lblnettotal.AutoSize = true;
            this.lblnettotal.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnettotal.Location = new System.Drawing.Point(190, 528);
            this.lblnettotal.Name = "lblnettotal";
            this.lblnettotal.Size = new System.Drawing.Size(36, 37);
            this.lblnettotal.TabIndex = 8;
            this.lblnettotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(386, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Discount:";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(498, 477);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(198, 30);
            this.txtdiscount.TabIndex = 10;
            // 
            // lblgrosstotal
            // 
            this.lblgrosstotal.AutoSize = true;
            this.lblgrosstotal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosstotal.Location = new System.Drawing.Point(165, 470);
            this.lblgrosstotal.Name = "lblgrosstotal";
            this.lblgrosstotal.Size = new System.Drawing.Size(24, 25);
            this.lblgrosstotal.TabIndex = 11;
            this.lblgrosstotal.Text = "0";
            // 
            // sn
            // 
            this.sn.HeaderText = "S.no";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.HeaderText = "Productname";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(708, 574);
            this.Controls.Add(this.lblgrosstotal);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblnettotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Billing system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnremovefromlist;
        private System.Windows.Forms.Button btnaddtolist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvresult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblnettotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblgrosstotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}

