namespace MedicalManagementLogin.AdministratorUC
{
    partial class UC_Report
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnmedic = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(52, 243);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 129);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "  Users";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnmedic
            // 
            this.btnmedic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnmedic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmedic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedic.ForeColor = System.Drawing.Color.White;
            this.btnmedic.Location = new System.Drawing.Point(332, 243);
            this.btnmedic.Margin = new System.Windows.Forms.Padding(2);
            this.btnmedic.Name = "btnmedic";
            this.btnmedic.Size = new System.Drawing.Size(128, 129);
            this.btnmedic.TabIndex = 58;
            this.btnmedic.Text = "  Medicine";
            this.btnmedic.UseVisualStyleBackColor = false;
            this.btnmedic.Click += new System.EventHandler(this.btnmedic_Click);
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btncust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.ForeColor = System.Drawing.Color.White;
            this.btncust.Location = new System.Drawing.Point(623, 243);
            this.btncust.Margin = new System.Windows.Forms.Padding(2);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(128, 129);
            this.btncust.TabIndex = 59;
            this.btncust.Text = " Customer";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.btnmedic);
            this.Controls.Add(this.btnAdd);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(828, 626);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnmedic;
        private System.Windows.Forms.Button btncust;
    }
}
