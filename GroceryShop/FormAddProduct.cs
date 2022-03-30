using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryShop
{
    public partial class FormAddProduct : Form
    {
        private DataAccessLayer dataAccessLayer;
        internal DataAccessLayer DataAccessLayer { set; get; }
        public FormAddProduct()
        {
            InitializeComponent();
            DataAccessLayer = new DataAccessLayer();
            this.ActiveControl = txtProductName;
            refreshdata();
        }

        public void refreshdata()
        {
            DataRow dR;
            string sqlString = "select * from ProductsCategory";
            DataSet data = DataAccessLayer.ExecuteQuery(sqlString);
            dR = data.Tables[0].NewRow();

            dR.ItemArray = new object[] { 0, "--Select Category--" };
            data.Tables[0].Rows.InsertAt(dR, 0);

            cmbProductCategorey.ValueMember = "catId";
            cmbProductCategorey.DisplayMember = "catName";
            cmbProductCategorey.DataSource = data.Tables[0];
        }

        private void FormAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private int takeProductId()
        {
            try
            {
                string sqlString = $"select productId from ProductsTable order by productId desc";
                var user = DataAccessLayer.ExecuteQuery(sqlString);
                int productId;
                if (user.Tables[0].Rows.Count < 0)
                {
                    return productId = 1;
                }
                else
                {
                    productId = Convert.ToInt32(user.Tables[0].Rows[0][0].ToString());
                    return ++productId;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message.ToString());
                throw;
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(cmbProductCategorey.Text) 
                && !string.IsNullOrEmpty(txtProductQuantity.Text) && !string.IsNullOrEmpty(txtProductPrice.Text))
            {
                string tempProductName = txtProductName.Text;
                int tempProductCategoreyId = Convert.ToInt32(cmbProductCategorey.SelectedValue);
                float tempProductQuantity = float.Parse(txtProductQuantity.Text);
                float tempProductPrice = float.Parse(txtProductPrice.Text);
                int productIdCount = takeProductId();

                try
                {
                    string sqlString = $"insert into ProductsTable(productId,productName,productQuantity,productPrice,catId) " +
                        $"values('{productIdCount}','{tempProductName}','{tempProductQuantity}','{tempProductPrice}','{tempProductCategoreyId}')";

                    int row = DataAccessLayer.ExecuteUpdateQuery(sqlString);
                    if (row == 1)
                    {
                        MessageBox.Show("Product Added");
                    }
                    else
                    {
                        MessageBox.Show("Product Not Added");
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString() + " Occured\nTry Again");
                }
            }
            else
            {
                MessageBox.Show("Text Box Empty!!");
            }
        }
    }
}
