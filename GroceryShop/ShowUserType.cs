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
    public partial class ShowUserType : Form
    {
        public ShowUserType()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm("owner");
            loginForm.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm("employee");
            loginForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm("customer");
            loginForm.Show();
        }
    }
}
