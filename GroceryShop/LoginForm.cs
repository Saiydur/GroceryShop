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
    public partial class LoginForm : Form
    {
        private string userRole;

        private DataAccessLayer dataAccessLayer;
        internal DataAccessLayer DataAccessLayer { set; get; }
        public string UserRole { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            DataAccessLayer = new DataAccessLayer();
        }

        public LoginForm(string userRole)
        {
            InitializeComponent();
            UserRole = userRole;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount formCreateAccount = new FormCreateAccount();
            formCreateAccount.Visible = true;
        }
        private bool Validatings()
        {
            bool status = false;
            if (string.IsNullOrEmpty(txtUserName.Text))
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
            return status;
        }

        private void ClearText()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Validatings())
            {
                string tempUserName = txtUserName.Text;
                string tempUserPass = txtUserPassword.Text;

                try
                {
                    string sqlString = $"select * from UsersInfo where userName='{txtUserName.Text}' and userPassword='{tempUserPass} and userRole={UserRole}'";

                    var data = DataAccessLayer.ExecuteQuery(sqlString);
                    if (data.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (data.Tables[0].Rows[0][2].ToString().Equals("Admin"))
                        {
                            this.Hide();
                            FormAdmin formAdmin = new FormAdmin();
                            formAdmin.Show();
                        }
                        if (data.Tables[0].Rows[0][2].Equals("Manager"))
                        {
                            this.Hide();
                            FormManager formManager = new FormManager();
                            formManager.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check User Name/Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearText();
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString(), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
