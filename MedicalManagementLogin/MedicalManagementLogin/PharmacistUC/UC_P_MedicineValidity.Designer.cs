namespace MedicalManagementLogin.PharmacistUC
{
    partial class UC_P_MedicineValidity
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.setLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 44);
            this.label1.TabIndex = 42;
            this.label1.Text = "Medicine Validitiy Check";
            // 
            // txtCheck
            // 
            this.txtCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCheck.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtCheck.ForeColor = System.Drawing.Color.Black;
            this.txtCheck.FormattingEnabled = true;
            this.txtCheck.Items.AddRange(new object[] {
            "Vaild Medicines",
            "Expired Medicines",
            "View All Medicines"});
            this.txtCheck.Location = new System.Drawing.Point(328, 126);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(399, 38);
            this.txtCheck.TabIndex = 43;
            this.txtCheck.SelectedIndexChanged += new System.EventHandler(this.txtCheck_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Check";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(20, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 484);
            this.dataGridView1.TabIndex = 45;
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLabel.Location = new System.Drawing.Point(14, 198);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(104, 34);
            this.setLabel.TabIndex = 46;
            this.setLabel.Text = "label3";
            // 
            // UC_P_MedicineValidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.setLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_MedicineValidity";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_P_MedicineValidity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label setLabel;
    }
}
