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

namespace GroceryShop
{
    public partial class FormManager : Form
    {
        private DataAccessLayer dataAccessLayer;
        internal DataAccessLayer DataAccessLayer { set; get; }

        public FormManager()
        {
            InitializeComponent();
            try
            {
                DataAccessLayer = new DataAccessLayer();
                PopulateDataGridView();
            }
            catch
            {

            }
        }
        private void FormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void PopulateDataGridView()
        {
            string sql = "select * from ProductsTable as p inner join ProductsCategory as pc on p.catId = pc.catId;";
            var data=DataAccessLayer.ExecuteQuery(sql);

            if(data!=null && data.Tables[0].Rows.Count>0)
            {
                dgvShowData.AutoGenerateColumns = false;
                dgvShowData.DataSource = data.Tables[0];
                dgvShowData.Refresh();
            }
        }

        int tempIdSelect;
        private void dgvShowData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProductName.Text = dgvShowData.CurrentRow.Cells["ProductName"].Value.ToString();
            txtProductPrice.Text = dgvShowData.CurrentRow.Cells["ProductPrice"].Value.ToString();
            txtProductQuantity.Text = dgvShowData.CurrentRow.Cells["ProductQuantity"].Value.ToString();
            tempIdSelect = Convert.ToInt32(dgvShowData.CurrentRow.Cells["ProductId"].Value.ToString());
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProductById.Text))
            {
                try
                {
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in dgvShowData.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == txtSearchProductById.Text)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    if (rowIndex >= 0)
                    {
                        dgvShowData.Rows[rowIndex].Selected = true;
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
        private double totalPriceOfAllProduct = 0;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtProductQuantity.Text);
                double price = Convert.ToDouble(txtProductPrice.Text);
                double totalPrice = quantity * price;
                totalPriceOfAllProduct += totalPrice;
                string[] row = { lblProductName.Text, txtProductQuantity.Text, txtProductPrice.Text, totalPrice.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewProductCart.Items.Add(listViewItem);
                listViewProductCart.Visible = true;
            }
            catch(Exception exe)
            {
                MessageBox.Show("Text Empty!!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewProductCart.Items)
            {
                if(item.Selected)
                {
                    listViewProductCart.Items.Remove(item);
                    totalPriceOfAllProduct -= Convert.ToDouble(item.SubItems[3].Text);
                }
            }
        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (listViewProductCart.Items.Count>0)
            {
                this.Hide();
                CheckOut checkOut = new CheckOut(this.listViewProductCart, totalPriceOfAllProduct);
                checkOut.Show();
            }
            else
            {
                MessageBox.Show("No Product In Cart");
            }
        }
    }
    
}
