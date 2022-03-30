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
    public partial class FormCreateAccount : Form
    {
        private DataAccessLayer dataAccessLayer;
        internal DataAccessLayer DataAccessLayer { set; get; }
        public FormCreateAccount()
        {
            InitializeComponent();
            DataAccessLayer = new DataAccessLayer();
            this.ActiveControl = txtUserName;
        }

        private bool Validatings()
        {
            bool status = false;
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                status = false;
            }
            else
            {
                status = true;
            }
            if (string.IsNullOrEmpty(txtUserPassword.Text))
            {
                status = false;
            }
            else
            {
                status = true;
            }
            if (string.IsNullOrEmpty(txtUserPhonenumber.Text))
            {
                status = false;
            }
            else
            {
                status = true;
            }
            if (string.IsNullOrEmpty(cmbUserType.Text))
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }

        private void ClearText()
        {
            txtUserName.Text = "";
            txtUserPhonenumber.Text = "";
            txtUserPassword.Text = "";
            cmbUserType.Text = null;
        }
        private int countUsers()
        {
            string sqlString = $"select userId from UsersInfo order by userId desc;";
            var user = DataAccessLayer.ExecuteQuery(sqlString);
            int count = 0;
            if(user.Tables[0].Rows.Count>0)
            {
                count = Convert.ToInt32(user.Tables[0].Rows[0][0].ToString());
                return ++count;
            }
            else
            {
                return ++count;
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Validatings())
            {
                var tempName = txtUserName.Text;
                var tempPhoneNumber = txtUserPhonenumber.Text;
                var tempPassword = txtUserPassword.Text;
                var tempUserType = cmbUserType.Text;
                int tempUserId = countUsers();


                string sqlString = $"insert into UsersInfo(userId,userName,userPhoneNumber,userPassword,userType) " +
                    $"values('{tempUserId}','{tempName}','{tempPhoneNumber}','{tempPassword}','{tempUserType}')";

                try
                {
                    int row = DataAccessLayer.ExecuteUpdateQuery(sqlString);
                    if (row == 1)
                    {
                        MessageBox.Show("Signed Up Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Signed Up Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearText();
                }
                catch(Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString(), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Informations Missing", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
