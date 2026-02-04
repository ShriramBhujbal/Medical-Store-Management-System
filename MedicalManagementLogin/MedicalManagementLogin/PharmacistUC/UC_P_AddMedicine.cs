using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementLogin.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
            disableFields();
        }
        void disableFields()
        {
            txtMediID.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtMediName.Text != "" && txtMediNumber.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic (mname,mnumber,mDate,eDate,quantity,perUnit) values ( '"+mname+"' , '"+mnumber+"' , '"+mdate+"' , '"+edate+"' , "+quantity+" , "+perunit+")";
                fn.setData(query, "Medicine Added to Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            

            txtMediName.Clear();
            txtMediNumber.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
