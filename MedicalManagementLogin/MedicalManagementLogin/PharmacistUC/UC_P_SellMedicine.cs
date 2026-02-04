using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementLogin.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_SellMedicine()
        {
            InitializeComponent();
           
        }

      
        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0;i< ds.Tables[0].Rows.Count;i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync1_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
            
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearchBox.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0;i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoofUnits.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMediName.Text = name;
            query = "select mid,eDate,perUnit from medic where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMediID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoofUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoofUnits.Text !="")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoofUnits.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text!="")
            {
                query = "select quantity from medic where mid = '" + txtMediID.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoofUnits.Text);

                if(newQuantity >= 0)
                {
                    

                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = txtMediID.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    dataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    dataGridView1.Rows[n].Cells[4].Value = txtNoofUnits.Text;
                    dataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "Rs. " + totalAmount.ToString();

                    query = "update medic set quantity ='" + newQuantity + "'where mid = '" + txtMediID.Text + "'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only " + quantity + " Left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.","Information !!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId != null)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid ='"+valueId+"'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update medic set quantity = '"+newQuantity+"' where mid ='"+valueId+"'";
                    fn.setData(query, "Medicine Removed from Cart.");
                    totalAmount = totalAmount - valueAmount;
                    totalLabel.Text = "Rs. " + totalAmount.ToString();
                }
                UC_P_SellMedicine_Load(this,null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);

            totalAmount = 0;
            totalLabel.Text = "Rs. 00";
            dataGridView1.DataSource = 0;
        }

        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoofUnits.Clear();
        }
    }
}
