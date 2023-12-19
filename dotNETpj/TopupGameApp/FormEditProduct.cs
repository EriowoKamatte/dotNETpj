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
    public partial class FormEditProduct : Form
    {
        public FormEditProduct()
        {
            InitializeComponent();
        }

        private void FormEditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "select * from PRODUCT";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strCommand = "select * from PRODUCT";
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                string Add = "AddNewProduct";
                SqlCommand my1Command = new SqlCommand(Add, myConnection);
                my1Command.CommandType = CommandType.StoredProcedure;
                my1Command.Parameters.AddWithValue("@Name", txtName.Text);
                my1Command.Parameters.AddWithValue("@Gems", Convert.ToInt32(txtGems.Text));
                my1Command.Parameters.AddWithValue("@Credits", Convert.ToInt32(txtCredits.Text));
                my1Command.Parameters.AddWithValue("@Desc", txtDesc.Text);
                my1Command.Parameters.AddWithValue("@Price", Convert.ToInt32(txtPrice.Text));
                my1Command.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit));
                my1Command.Parameters["@Available"].Direction = ParameterDirection.Output;
                my1Command.ExecuteNonQuery();

                DataSet ds = new DataSet();
                da.Fill(ds, "Product");

                this.dgvProduct.DataSource = ds;
                this.dgvProduct.DataMember = "Product";

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
