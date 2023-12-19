using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace TopupGameApp
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void lbUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet1.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.storeDBDataSet1.ACCOUNT);
            btnSignOut.Visible = true;
            lbUserInfo.Visible = true;
            lbUserInfo.Text = "Welcome, " + UserAccount.CurrentUsername;

            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "Select * from Data_Transaction";
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataSet ds = new DataSet();
                da.Fill(ds, "Product");
                ds.WriteXml("Report.xml");

                this.dgvReport.DataSource = ds;
                this.dgvReport.DataMember = "Product";

                rptOrders rptOrders = new rptOrders();
                rptOrders.SetDataSource(ds);
                this.crvView.ReportSource = rptOrders;

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvAdminView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FormEditProduct formEditProduct = new FormEditProduct();
            formEditProduct.ShowDialog();
        }

        private void crvView_Load(object sender, EventArgs e)
        {

        }
    }
}
