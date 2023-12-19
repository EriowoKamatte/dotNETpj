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

namespace TopupGameApp
{
    public partial class UserOrderForm : Form
    {
        public int CurrentOrderID = 0;

        public UserOrderForm()
        {
            InitializeComponent();
        }

        private void lbUserInfo_Click(object sender, EventArgs e)
        {
            AccInfo accInfo = new AccInfo();
            accInfo.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "select OrderID, Total, DateCreated from MYORDER" +
                                    " where UserID = " + UserAccount.CurrentID;
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand); 

                DataSet ds = new DataSet();
                da.Fill(ds, "MyBill");

                this.dgvBill.DataSource = ds;
                this.dgvBill.DataMember = "MyBill";

                myConnection.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvBill.Rows[e.RowIndex];
            GetCurrentRow(dr);
        }
        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr != null)
            {
                CurrentOrderID = Convert.ToInt32(dr.Cells["OrderID"].Value);

                try
                {
                    string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                        .ToString();

                    string strCommand = "select  PRODUCT.ProdName as Name, PRODUCT.gems as Gems, PRODUCT.credits as Credits," +
                        " ORDER_ITEMS.ProdPrice as Price, ORDER_ITEMS.Quantity as Quantity from MYORDER" +
                        " inner join ACCOUNT on ACCOUNT.UserID = MYORDER.UserID inner join ORDER_ITEMS on MYORDER.OrderID = ORDER_ITEMS.OrderID" +
                        " inner join PRODUCT on PRODUCT.ProdID = ORDER_ITEMS.ProdID" +
                        " where MYORDER.OrderID = " + CurrentOrderID;
                    SqlConnection myConnection = new SqlConnection(strConnectString);
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "MyBillItems");

                    this.dgvBillItems.DataSource = ds;
                    this.dgvBillItems.DataMember = "MyBillItems";

                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

            }
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "select OrderID, Total, DateCreated from MYORDER" +
                                    " where UserID = " + UserAccount.CurrentID + " and" +
                                    " DateCreated between " + "'" + txtStartDate.Text + "'" + 
                                    " and " + "'" + txtEndDate.Text + "'";
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataSet ds = new DataSet();
                da.Fill(ds, "MyBill");

                this.dgvBill.DataSource = ds;
                this.dgvBill.DataMember = "MyBill";

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void txtEndDate_MouseClick(object sender, MouseEventArgs e)
        {
            txtEndDate.Text = "";
            txtEndDate.ForeColor = Color.Black;
        }

        private void txtStartDate_MouseClick(object sender, MouseEventArgs e)
        {
            txtStartDate.Text = "";
            txtStartDate.ForeColor = Color.Black;
        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "select  PRODUCT.ProdName as Name, PRODUCT.gems as Gems, PRODUCT.credits as Credits," +
                    " ORDER_ITEMS.ProdPrice as Price, ORDER_ITEMS.Quantity as Quantity from MYORDER" +
                    " inner join ACCOUNT on ACCOUNT.UserID = MYORDER.UserID inner join ORDER_ITEMS on MYORDER.OrderID = ORDER_ITEMS.OrderID" +
                    " inner join PRODUCT on PRODUCT.ProdID = ORDER_ITEMS.ProdID" +
                    " where MYORDER.OrderID = " + CurrentOrderID +
                    " and PRODUCT.ProdName like " + "'%" + txtSearchItemsBox.Text + "%'";
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataSet ds = new DataSet();
                da.Fill(ds, "MyBillItems");

                this.dgvBillItems.DataSource = ds;
                this.dgvBillItems.DataMember = "MyBillItems";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
