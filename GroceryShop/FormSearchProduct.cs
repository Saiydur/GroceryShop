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
    public partial class FormSearchProduct : Form
    {
        private DataAccessLayer dataAccessLayer;
        internal DataAccessLayer DataAccessLayer { set; get; }
        public FormSearchProduct()
        {
            InitializeComponent();
            DataAccessLayer = new DataAccessLayer();
            SetDataToDgv();
        }
        private void SetDataToDgv()
        {
            string sql = @"select * from ProductsTable as p inner join ProductsCategory as pc 
                            on p.catId = pc.catId; ";
            DataSet data = DataAccessLayer.ExecuteQuery(sql);

            if(data.Tables[0].Rows.Count>0)
            {
                dgvProductShow.AutoGenerateColumns = false;
                dgvProductShow.DataSource = data.Tables[0];
                dgvProductShow.Refresh();
            }
        }
        private void FormSearchProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int tempIdSelect;
        private void dgvProductShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProductName.Text=dgvProductShow.CurrentRow.Cells["ColProductName"].Value.ToString();
            txtProductPrice.Text=dgvProductShow.CurrentRow.Cells["ColProductPrice"].Value.ToString();
            txtProductQuantity.Text=dgvProductShow.CurrentRow.Cells["ColProductQuantity"].Value.ToString();
            tempIdSelect= Convert.ToInt32(dgvProductShow.CurrentRow.Cells["ColProductId"].Value.ToString());
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblProductName.Text) && !string.IsNullOrEmpty(txtProductPrice.Text) && !string.IsNullOrEmpty(txtProductQuantity.Text))
            {
                string sql = $"update ProductsTable set " +
                            $"productName = '{lblProductName.Text}'," +
                            $"productPrice = '{txtProductPrice.Text}'," +
                            $"productQuantity = '{txtProductQuantity.Text}' " +
                            $"where productId = '{tempIdSelect}'";
                try
                {
                    int row = DataAccessLayer.ExecuteUpdateQuery(sql);
                    if (row == 1)
                    {
                        MessageBox.Show("Updated");
                        SetDataToDgv();
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Text Box Empty");
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string sql = $"delete ProductsTable where productId='{tempIdSelect}'";

            try
            {
                int row = DataAccessLayer.ExecuteUpdateQuery(sql);
                if (row == 1)
                {
                    MessageBox.Show("Deleted");
                    SetDataToDgv();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProductById.Text))
            {
                try
                {
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in dgvProductShow.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == txtSearchProductById.Text)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    if (rowIndex >= 0)
                    {
                        dgvProductShow.Rows[rowIndex].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                }
                catch
                {
                    MessageBox.Show("Data Not Found");
                }
            }
            else
            {
                MessageBox.Show("Text Box Empty");
            }
        }
    }
}
