namespace MedicalManagementLogin.PharmacistUC
{
    partial class UC_P_SellMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_SellMedicine));
            this.btnSync1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.listBoxMedicines = new System.Windows.Forms.ListBox();
            this.txtMediName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.txtNoofUnits = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPurchasePrint = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSync1
            // 
            this.btnSync1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync1.FlatAppearance.BorderSize = 0;
            this.btnSync1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync1.Image = ((System.Drawing.Image)(resources.GetObject("btnSync1.Image")));
            this.btnSync1.Location = new System.Drawing.Point(300, 17);
            this.btnSync1.Name = "btnSync1";
            this.btnSync1.Size = new System.Drawing.Size(53, 41);
            this.btnSync1.TabIndex = 34;
            this.btnSync1.UseVisualStyleBackColor = true;
            this.btnSync1.Click += new System.EventHandler(this.btnSync1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sell Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBox.Location = new System.Drawing.Point(37, 108);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(210, 36);
            this.txtSearchBox.TabIndex = 36;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // listBoxMedicines
            // 
            this.listBoxMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicines.FormattingEnabled = true;
            this.listBoxMedicines.ItemHeight = 29;
            this.listBoxMedicines.Location = new System.Drawing.Point(37, 159);
            this.listBoxMedicines.Name = "listBoxMedicines";
            this.listBoxMedicines.Size = new System.Drawing.Size(210, 584);
            this.listBoxMedicines.TabIndex = 37;
            this.listBoxMedicines.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicines_SelectedIndexChanged);
            // 
            // txtMediName
            // 
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMediName.ForeColor = System.Drawing.Color.Black;
            this.txtMediName.Location = new System.Drawing.Point(314, 209);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.ReadOnly = true;
            this.txtMediName.Size = new System.Drawing.Size(340, 36);
            this.txtMediName.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Medicine Name";
            // 
            // txtMediID
            // 
            this.txtMediID.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMediID.ForeColor = System.Drawing.Color.Black;
            this.txtMediID.Location = new System.Drawing.Point(314, 108);
            this.txtMediID.Name = "txtMediID";
            this.txtMediID.ReadOnly = true;
            this.txtMediID.Size = new System.Drawing.Size(340, 36);
            this.txtMediID.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Medicine ID";
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpireDate.Location = new System.Drawing.Point(316, 322);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(340, 36);
            this.txtExpireDate.TabIndex = 74;
            // 
            // txtNoofUnits
            // 
            this.txtNoofUnits.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtNoofUnits.ForeColor = System.Drawing.Color.Black;
            this.txtNoofUnits.Location = new System.Drawing.Point(714, 209);
            this.txtNoofUnits.Name = "txtNoofUnits";
            this.txtNoofUnits.Size = new System.Drawing.Size(340, 36);
            this.txtNoofUnits.TabIndex = 73;
            this.txtNoofUnits.TextChanged += new System.EventHandler(this.txtNoofUnits_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 72;
            this.label8.Text = "No of Units";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.Location = new System.Drawing.Point(714, 108);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.ReadOnly = true;
            this.txtPricePerUnit.Size = new System.Drawing.Size(340, 36);
            this.txtPricePerUnit.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(709, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "Price Per Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Expire Date";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.Location = new System.Drawing.Point(716, 324);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(340, 36);
            this.txtTotalPrice.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(711, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Total Price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(874, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.Location = new System.Drawing.Point(863, 375);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(193, 48);
            this.btnAddtoCart.TabIndex = 77;
            this.btnAddtoCart.Text = "   Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(818, 698);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // btnPurchasePrint
            // 
            this.btnPurchasePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPurchasePrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurchasePrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasePrint.ForeColor = System.Drawing.Color.White;
            this.btnPurchasePrint.Location = new System.Drawing.Point(817, 689);
            this.btnPurchasePrint.Name = "btnPurchasePrint";
            this.btnPurchasePrint.Size = new System.Drawing.Size(253, 48);
            this.btnPurchasePrint.TabIndex = 80;
            this.btnPurchasePrint.Text = " Purchase And Print";
            this.btnPurchasePrint.UseVisualStyleBackColor = false;
            this.btnPurchasePrint.Click += new System.EventHandler(this.btnPurchasePrint_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(323, 698);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(314, 689);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 48);
            this.btnRemove.TabIndex = 82;
            this.btnRemove.Text = "      Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(550, 686);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(192, 48);
            this.totalLabel.TabIndex = 84;
            this.totalLabel.Text = "Rs. 00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(314, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 237);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expiry Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Unit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No of Units ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // UC_P_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPurchasePrint);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.txtNoofUnits);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxMedicines);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSync1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_SellMedicine";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_P_SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ListBox listBoxMedicines;
        private System.Windows.Forms.TextBox txtMediName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMediID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtExpireDate;
        private System.Windows.Forms.TextBox txtNoofUnits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPurchasePrint;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
