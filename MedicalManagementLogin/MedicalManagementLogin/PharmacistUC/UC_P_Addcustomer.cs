using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MedicalManagementLogin.PharmacistUC
{
    public partial class UC_P_Addcustomer : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_Addcustomer()
        {
            InitializeComponent();
            disableFields();
        }

        void disableFields()
        {
            txtcustID.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text != "" && txtCustMob.Text != "" && txtRole.Text !="" && txtCustEmail.Text != "" && txtCustDOB.Text != "" && txtReferenceBy.Text !="")
            {

                String cname = txtCustName.Text;
                Int64 cmobile = Int64.Parse(txtCustMob.Text);
                String role = txtRole.Text;
                String cemail = txtCustEmail.Text;
                String cdob = txtCustDOB.Text;
                String ReferenceBy = txtReferenceBy.Text;

                query = "insert into cust (cname,cmobile,role,cemail,edob,referenceby) values ( '" + cname + "' , " + cmobile + " ,'" + role + "' ,'" + cemail + "' , '" + cdob + "' ,' " + ReferenceBy + "' )";
                fn.setData(query, "Customer Added.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /* String cname = txtCustName.Text;
             Int64 cmobile = Int64.Parse(txtCustMob.Text);
             String cemail = txtCustEmail.Text;
             String cdob = txtCustDOB.Text;
             String ReferenceBy = txtReferenceBy.Text;

             try
             {
                 query = "insert into cust (cname,cmobile,cemail,edob,referenceby) values ('" + cname + "','" + cmobile + "','" + cemail + "'," + cdob + ",'" + ReferenceBy + "' )";
                 fn.setData(query, "Customer Added.");
             }
             catch (Exception)
             {
                 MessageBox.Show("Customer Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {


            txtCustName.Clear();
            txtCustMob.Clear();
            txtCustEmail.Clear();
            txtCustDOB.ResetText();
            txtReferenceBy.Clear();
        }

        private void UC_P_Addcustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
