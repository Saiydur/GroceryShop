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
    public partial class FormHome : Form
    {
        private DataAccessLayer dataAccessLayer;
        internal DataAccessLayer DataAccessLayer { set; get; }
        public FormHome()
        {
            InitializeComponent();
            DataAccessLayer = new DataAccessLayer();
            this.ActiveControl = txtCategoreyName;
        }

        private int takeCatergoreyId()
        {
            try
            {
                string sqlString = $"select catId from ProductsCategory order by catId desc";
                var user = DataAccessLayer.ExecuteQuery(sqlString);
                int catIdCount;
                if (user.Tables[0].Rows.Count <= 0)
                {
                    return catIdCount = 1;
                }
                else
                {
                    catIdCount = Convert.ToInt32(user.Tables[0].Rows[0][0].ToString());
                    return ++catIdCount;
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message.ToString());
                throw;
            }
        }

        private void btnAddCatergorey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoreyName.Text))
            {
                string tempCategoreyName = txtCategoreyName.Text;
                int catIdSet = takeCatergoreyId();
                try
                {
                    string sqlString = $"insert into ProductsCategory(catId,catName) values('{catIdSet}','{tempCategoreyName}')";
                    int row = DataAccessLayer.ExecuteUpdateQuery(sqlString);
                    if (row == 1)
                    {
                        MessageBox.Show(tempCategoreyName + " is successfully inserted");
                        txtCategoreyName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Insertation Failed");
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString() + " Occured\n Try Again");
                }
            }
            else
            {
                MessageBox.Show("Text Box Empty");
            }

        }
    }
}
