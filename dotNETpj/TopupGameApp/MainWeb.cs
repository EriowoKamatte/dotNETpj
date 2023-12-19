using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TopupGameApp
{
    public partial class MainWeb : Form
    {
        public bool State = false;
      
        public MainWeb(bool state)
        {
            this.State = state;
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(false);
            signupForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strSearch = "'%" + this.SearchBox.Text + "%'";
                string strCommand = "Select * from PRODUCT where ProdName like " + strSearch;
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();


                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataSet ds = new DataSet();
                da.Fill(ds, "Product");

                this.dgvProduct.DataSource = ds;
                this.dgvProduct.DataMember = "Product";

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WebName_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(true);
            signupForm.ShowDialog();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MainWeb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.storeDBDataSet1.PRODUCT);
            txtQuantity.Text = "1";
            
            if (State)
            {

                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                string UserGems = "GetUserGems";
                SqlCommand myGetUserGemsCommand = new SqlCommand(UserGems, myConnection);
                myGetUserGemsCommand.CommandType = CommandType.StoredProcedure;
                myGetUserGemsCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                myGetUserGemsCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
                myGetUserGemsCommand.Parameters["@Amount"].Direction = ParameterDirection.Output;
                myGetUserGemsCommand.ExecuteNonQuery();
                lbUserGems.Text = myGetUserGemsCommand.Parameters["@Amount"].Value.ToString();

                string UserCredits = "GetUserCredits";
                SqlCommand myGetUserCreditsCommand = new SqlCommand(UserCredits, myConnection);
                myGetUserCreditsCommand.CommandType = CommandType.StoredProcedure;
                myGetUserCreditsCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                myGetUserCreditsCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Float));
                myGetUserCreditsCommand.Parameters["@Amount"].Direction = ParameterDirection.Output;
                myGetUserCreditsCommand.ExecuteNonQuery();
                lbUserCredits.Text = myGetUserCreditsCommand.Parameters["@Amount"].Value.ToString();

                myConnection.Close();

                btnSignOut.Visible = true;
                btnCart.Visible = true;
                btnLogin.Visible = false;
                btnSignup.Visible = false;
                lbUserInfo.Visible = true;
                picUserCredits.Visible = true;
                picUserGems.Visible = true;
                lbUserCredits.Visible = true;
                lbUserGems.Visible = true;
                lbUserInfo.Text = "Welcome, " + UserAccount.CurrentUsername;
            }

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

        private void lbUserInfo_Click(object sender, EventArgs e)
        {
            AccInfo accInfo = new AccInfo();
            accInfo.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();
                string str2ndCommand = "AddProduct";

                string strCommand = "select PRODUCT.ProdName as Name, PRODUCT.gems as Gems, PRODUCT.credits as Credits," +
                                    " PRODUCT.ProdPrice as Price, CART_ITEMS.quantity as Quantity, CART_ITEMS.quantity * PRODUCT.ProdPrice as subTotal from CART" +
                                    " inner join ACCOUNT on ACCOUNT.UserID = CART.UserID inner join CART_ITEMS on CART.CartID = CART_ITEMS.CartID" +
                                    " inner join PRODUCT on PRODUCT.ProdID = CART_ITEMS.ProdID" +
                                    " where ACCOUNT.UserID = " + UserAccount.CurrentID;

                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                SqlCommand my2ndCommand = new SqlCommand(str2ndCommand, myConnection);
                my2ndCommand.CommandType = CommandType.StoredProcedure;
                my2ndCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                my2ndCommand.Parameters.AddWithValue("@ProdID", Product.CurrentProdID);
                my2ndCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                my2ndCommand.ExecuteNonQuery();

                string SumCart = "SumCartTotal";
                SqlCommand mySumCartCommand = new SqlCommand(SumCart, myConnection);
                mySumCartCommand.CommandType = CommandType.StoredProcedure;
                mySumCartCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartCommand.ExecuteNonQuery();
                lbTotalCart.Text = mySumCartCommand.Parameters["@Sum"].Value.ToString();

                string SumCartGems = "SumCartGems";
                SqlCommand mySumCartGemsCommand = new SqlCommand(SumCartGems, myConnection);
                mySumCartGemsCommand.CommandType = CommandType.StoredProcedure;
                mySumCartGemsCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartGemsCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartGemsCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartGemsCommand.ExecuteNonQuery();
                lbCartGems.Text = mySumCartGemsCommand.Parameters["@Sum"].Value.ToString();

                string SumCartCredits = "SumCartCredits";
                SqlCommand mySumCartCreditsCommand = new SqlCommand(SumCartCredits, myConnection);
                mySumCartCreditsCommand.CommandType = CommandType.StoredProcedure;
                mySumCartCreditsCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartCreditsCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartCreditsCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartCreditsCommand.ExecuteNonQuery();
                lbCartCredits.Text = mySumCartCreditsCommand.Parameters["@Sum"].Value.ToString();

                DataSet ds = new DataSet();
                da.Fill(ds, "MyCart");

                this.dgvCart.DataSource = ds;
                this.dgvCart.DataMember = "MyCart";

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "select PRODUCT.ProdName as Name, PRODUCT.gems as Gems, PRODUCT.credits as Credits," +
                                    " PRODUCT.ProdPrice as Price, CART_ITEMS.quantity as Quantity, CART_ITEMS.quantity * PRODUCT.ProdPrice as subTotal from CART" +
                                    " inner join ACCOUNT on ACCOUNT.UserID = CART.UserID inner join CART_ITEMS on CART.CartID = CART_ITEMS.CartID" +
                                    " inner join PRODUCT on PRODUCT.ProdID = CART_ITEMS.ProdID" +
                                    " where ACCOUNT.UserID = " + UserAccount.CurrentID;
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                string SumCart = "SumCartTotal";
                SqlCommand mySumCartCommand = new SqlCommand(SumCart, myConnection);
                mySumCartCommand.CommandType = CommandType.StoredProcedure;
                mySumCartCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartCommand.ExecuteNonQuery();
                lbTotalCart.Text = mySumCartCommand.Parameters["@Sum"].Value.ToString();

                string SumCartGems = "SumCartGems";
                SqlCommand mySumCartGemsCommand = new SqlCommand(SumCartGems, myConnection);
                mySumCartGemsCommand.CommandType = CommandType.StoredProcedure;
                mySumCartGemsCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartGemsCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartGemsCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartGemsCommand.ExecuteNonQuery();
                lbCartGems.Text = mySumCartGemsCommand.Parameters["@Sum"].Value.ToString();

                string SumCartCredits = "SumCartCredits";
                SqlCommand mySumCartCreditsCommand = new SqlCommand(SumCartCredits, myConnection);
                mySumCartCreditsCommand.CommandType = CommandType.StoredProcedure;
                mySumCartCreditsCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartCreditsCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartCreditsCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartCreditsCommand.ExecuteNonQuery();
                lbCartCredits.Text = mySumCartCreditsCommand.Parameters["@Sum"].Value.ToString();

                DataSet ds = new DataSet();
                da.Fill(ds, "MyCart");

                this.dgvCart.DataSource = ds;
                this.dgvCart.DataMember = "MyCart";

                myConnection.Close();
                lbTotalCart.Visible = true;
                lbTotal.Visible = true;
                lbYourCart.Visible = true;
                dgvCart.Visible = true;
                lbQtt.Visible = true;
                txtQuantity.Visible = true;
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnPurchase.Visible = true;
                lbCartGems.Visible = true;
                lbCartCredits.Visible = true;
                picGems.Visible = true;
                picCredits.Visible = true;
                lbvnd.Visible = true;
                btnHistory.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvCart.Rows[e.RowIndex];
            GetCurrentRow(dr);
        }
        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr != null)
            {
                Product.setCurrentProdName(Convert.ToString(dr.Cells["Name"].Value));
                try
                {
                    string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                        .ToString();
                    string strCommand = "GetProdID";

                    
                    SqlConnection myConnection = new SqlConnection(strConnectString);
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@ProdName", Product.CurrentProdName);
                    myCommand.Parameters.Add(new SqlParameter("@ProdID", SqlDbType.Int));
                    myCommand.Parameters["@ProdID"].Direction = ParameterDirection.Output;
                    myCommand.ExecuteNonQuery();
                    Product.setCurrentProdID(Convert.ToInt32(myCommand.Parameters["@ProdID"].Value));

                    myConnection.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
        }
        private void GetCurrentRow2(DataGridViewRow dr)
        {
            if (dr != null)
            {
                Product.setCurrentProdName(Convert.ToString(dr.Cells["prodNameDataGridViewTextBoxColumn"].Value));
                try
                {
                    string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                        .ToString();
                    string strCommand = "GetProdID";


                    SqlConnection myConnection = new SqlConnection(strConnectString);
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@ProdName", Product.CurrentProdName);
                    myCommand.Parameters.Add(new SqlParameter("@ProdID", SqlDbType.Int));
                    myCommand.Parameters["@ProdID"].Direction = ParameterDirection.Output;
                    myCommand.ExecuteNonQuery();
                    Product.setCurrentProdID(Convert.ToInt32(myCommand.Parameters["@ProdID"].Value));

                    myConnection.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvProduct.Rows[e.RowIndex];
            GetCurrentRow2(dr);
        }

        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();
                string str2ndCommand = "DeleteProduct";
                string str3rdCommand = "SumCartTotal";

                string strCommand = "select PRODUCT.ProdName as Name, PRODUCT.gems as Gems, PRODUCT.credits as Credits," +
                                    " PRODUCT.ProdPrice as Price, CART_ITEMS.quantity as Quantity, CART_ITEMS.quantity * PRODUCT.ProdPrice as subTotal from CART" +
                                    " inner join ACCOUNT on ACCOUNT.UserID = CART.UserID inner join CART_ITEMS on CART.CartID = CART_ITEMS.CartID" +
                                    " inner join PRODUCT on PRODUCT.ProdID = CART_ITEMS.ProdID" +
                                    " where ACCOUNT.UserID = " + UserAccount.CurrentID;

                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                SqlCommand my2ndCommand = new SqlCommand(str2ndCommand, myConnection);
                my2ndCommand.CommandType = CommandType.StoredProcedure;
                my2ndCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                my2ndCommand.Parameters.AddWithValue("@ProdID", Product.CurrentProdID);
                my2ndCommand.ExecuteNonQuery();

                SqlCommand my3rdCommand = new SqlCommand(str3rdCommand, myConnection);
                my3rdCommand.CommandType = CommandType.StoredProcedure;
                my3rdCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                my3rdCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                my3rdCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                my3rdCommand.ExecuteNonQuery();
                lbTotalCart.Text = my3rdCommand.Parameters["@Sum"].Value.ToString();

                string SumCartGems = "SumCartGems";
                SqlCommand mySumCartGemsCommand = new SqlCommand(SumCartGems, myConnection);
                mySumCartGemsCommand.CommandType = CommandType.StoredProcedure;
                mySumCartGemsCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartGemsCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartGemsCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartGemsCommand.ExecuteNonQuery();
                lbCartGems.Text = mySumCartGemsCommand.Parameters["@Sum"].Value.ToString();

                string SumCartCredits = "SumCartCredits";
                SqlCommand mySumCartCreditsCommand = new SqlCommand(SumCartCredits, myConnection);
                mySumCartCreditsCommand.CommandType = CommandType.StoredProcedure;
                mySumCartCreditsCommand.Parameters.AddWithValue("@CartID", UserAccount.CurrentCartID);
                mySumCartCreditsCommand.Parameters.Add(new SqlParameter("@Sum", SqlDbType.Float));
                mySumCartCreditsCommand.Parameters["@Sum"].Direction = ParameterDirection.Output;
                mySumCartCreditsCommand.ExecuteNonQuery();
                lbCartCredits.Text = mySumCartCreditsCommand.Parameters["@Sum"].Value.ToString();


                DataSet ds = new DataSet();
                da.Fill(ds, "MyCart");

                this.dgvCart.DataSource = ds;
                this.dgvCart.DataMember = "MyCart";

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64("0" + lbTotalCart.Text) > 0) {
                DialogResult dr = MessageBox.Show("Xác nhận thanh toán",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Thanh toán thành công");

                    try
                    {
                        string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                            .ToString();
                        string strCommand = "SetUserCurrency";


                        SqlConnection myConnection = new SqlConnection(strConnectString);
                        myConnection.Open();

                        SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                        myCommand.Parameters.AddWithValue("@Gems", Convert.ToInt32(lbCartGems.Text));
                        myCommand.Parameters.AddWithValue("@Credits", Convert.ToInt64(lbCartCredits.Text));
                        myCommand.ExecuteNonQuery();

                        string UserGems = "GetUserGems";
                        SqlCommand myGetUserGemsCommand = new SqlCommand(UserGems, myConnection);
                        myGetUserGemsCommand.CommandType = CommandType.StoredProcedure;
                        myGetUserGemsCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                        myGetUserGemsCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
                        myGetUserGemsCommand.Parameters["@Amount"].Direction = ParameterDirection.Output;
                        myGetUserGemsCommand.ExecuteNonQuery();
                        lbUserGems.Text = myGetUserGemsCommand.Parameters["@Amount"].Value.ToString();

                        string UserCredits = "GetUserCredits";
                        SqlCommand myGetUserCreditsCommand = new SqlCommand(UserCredits, myConnection);
                        myGetUserCreditsCommand.CommandType = CommandType.StoredProcedure;
                        myGetUserCreditsCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                        myGetUserCreditsCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Float));
                        myGetUserCreditsCommand.Parameters["@Amount"].Direction = ParameterDirection.Output;
                        myGetUserCreditsCommand.ExecuteNonQuery();
                        lbUserCredits.Text = myGetUserCreditsCommand.Parameters["@Amount"].Value.ToString();

                        string CreateUserBill = "createBill";
                        SqlCommand myCreateUserBillCommand = new SqlCommand(CreateUserBill, myConnection);
                        myCreateUserBillCommand.CommandType = CommandType.StoredProcedure;
                        myCreateUserBillCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                        myCreateUserBillCommand.Parameters.AddWithValue("@Total", Convert.ToInt32(lbTotalCart.Text));
                        myCreateUserBillCommand.ExecuteNonQuery();

                        string GetOrderID = "GetOrderID";
                        SqlCommand myGetOrderIDCommand = new SqlCommand(GetOrderID, myConnection);
                        myGetOrderIDCommand.CommandType = CommandType.StoredProcedure;
                        myGetOrderIDCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                        myGetOrderIDCommand.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                        myGetOrderIDCommand.Parameters["@OrderID"].Direction = ParameterDirection.Output;
                        myGetOrderIDCommand.ExecuteNonQuery();
                        int OrderID = Convert.ToInt32(myGetOrderIDCommand.Parameters["@OrderID"].Value);

                        string CreateUserBillDetail = "createBillDetail";
                        SqlCommand myCreateUserBillDetailCommand = new SqlCommand(CreateUserBillDetail, myConnection);
                        myCreateUserBillDetailCommand.CommandType = CommandType.StoredProcedure;
                        myCreateUserBillDetailCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                        myCreateUserBillDetailCommand.Parameters.AddWithValue("@OrderID", OrderID);

                        myCreateUserBillDetailCommand.ExecuteNonQuery();

                        myConnection.Close();

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

                } else
                {
                    MessageBox.Show("Thanh toán tạm dừng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng cung cấp giỏ hàng thích hợp trước khi thanh toán");
            }

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            UserOrderForm userOrderForm = new UserOrderForm();
            userOrderForm.ShowDialog();
        }
    }
}
