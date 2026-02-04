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
    public partial class ViewCustomer : UserControl
    {
        function fn = new function();
        String query;
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            query = "select * from cust";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cust where cname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String CustID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CustID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSync1_Click(object sender, EventArgs e)
        {
            ViewCustomer_Load(this, null);
        }
    }
}
