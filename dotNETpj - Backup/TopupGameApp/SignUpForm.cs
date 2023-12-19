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
    public partial class SignupForm : Form
    {
        public bool isSignUp = false;
        public bool State = false;
        public static bool isAdmin = false;

        public void setAdmin(bool isadmin)
        {
            isAdmin = isadmin;
        }

        public SignupForm(bool isSignUp)
        {
            this.isSignUp = isSignUp;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng form không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (isSignUp == true)
            {
                SignUp();
            }
            else
            {
                LogIn();
            }
        }

        private void LogIn()
        {
            string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                                           .ToString();

            string strCommand = "dbLogin";
            string str2ndCommand = "getAccRole";

            SqlConnection myConnection = new SqlConnection(strConnectString);
            myConnection.Open();
            
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@Username", txtName.Text);
            myCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
            myCommand.Parameters.Add(new SqlParameter("@Check", SqlDbType.VarChar, 10));
            myCommand.Parameters["@Check"].Direction = ParameterDirection.Output;
            myCommand.ExecuteNonQuery();

            SqlCommand my2ndCommand = new SqlCommand(str2ndCommand, myConnection);
            my2ndCommand.CommandType = CommandType.StoredProcedure;
            my2ndCommand.Parameters.AddWithValue("@Username", txtName.Text);
            my2ndCommand.Parameters.Add(new SqlParameter("@role", SqlDbType.Bit));
            my2ndCommand.Parameters["@role"].Direction = ParameterDirection.Output;
            my2ndCommand.ExecuteNonQuery();
            if (Convert.ToBoolean(myCommand.Parameters["@Check"].Value.ToString()))
            {
                UserAccount.setCurrentUsername(txtName.Text);
                UserAccount.setCurrentPassword(txtPassword.Text);
                this.Hide();
                if (Convert.ToBoolean(my2ndCommand.Parameters["@role"].Value))
                {
                    setAdmin(true);
                    MessageBox.Show("Dang nhap thanh cong voi quyen admin");
                    AdminView adminView = new AdminView();
                } else
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    MainWeb mainWeb = new MainWeb(true);
                    mainWeb.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Dang nhap that bai, vui long kiem tra lai username va password");

            };
            myConnection.Close();
            this.Close();
        }

        private void SignUp()
        {
            string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                               .ToString();

            string strTest = "CheckUsnAvailable";
            string strGetID = "GetID";
            string strCreateCart = "createCart";

            string strCommand = "Insert into ACCOUNT (usn, pwd) values (" +
                " '" + txtName.Text + "'," +
                " '" + txtPassword.Text + "')";

            SqlConnection myConnection = new SqlConnection(strConnectString);
            myConnection.Open();

            SqlCommand my2ndCommand = new SqlCommand(strTest, myConnection);
            my2ndCommand.CommandType = CommandType.StoredProcedure;
            my2ndCommand.Parameters.AddWithValue("@Username", txtName.Text);
            my2ndCommand.Parameters.Add(new SqlParameter("@isAvailable", SqlDbType.Bit));
            my2ndCommand.Parameters["@isAvailable"].Direction = ParameterDirection.Output;
            my2ndCommand.ExecuteNonQuery();

            if (Convert.ToBoolean(my2ndCommand.Parameters["@isAvailable"].Value))
            {
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Dang ky tai khoan thanh cong");
                SqlCommand my3rdCommand = new SqlCommand(strGetID, myConnection);
                my3rdCommand.CommandType = CommandType.StoredProcedure;
                my3rdCommand.Parameters.AddWithValue("@Username", txtName.Text);
                my3rdCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
                my3rdCommand.Parameters["@ID"].Direction = ParameterDirection.Output;
                my3rdCommand.ExecuteNonQuery();

                UserAccount.setCurrentUserID(Convert.ToInt32(my3rdCommand.Parameters["@ID"].Value));
                MessageBox.Show(UserAccount.CurrentID.ToString());

                SqlCommand my4thCommand = new SqlCommand(strCreateCart, myConnection);
                my4thCommand.CommandType = CommandType.StoredProcedure;
                my4thCommand.Parameters.AddWithValue("@UserID", UserAccount.CurrentID);
                
                my4thCommand.ExecuteNonQuery();
            } else
            {
                MessageBox.Show("Dang ky tai khoan that bai. Username da ton tai.");
            }
            myConnection.Close();
            this.Close();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            if (isSignUp == false)
            {
                SignUplb.Text = "LOG IN";
                btnSignup.Text = "Log In";
                Text = "Log In";
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emaillb_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
