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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            panelMainContentAdmin.Controls.Clear();
            FormHome formHome = new FormHome();
            formHome.TopLevel = false;
            formHome.Dock = DockStyle.Fill;
            panelMainContentAdmin.Controls.Add(formHome);
            formHome.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMainContentAdmin.Controls.Clear();
            FormHome formHome = new FormHome();
            formHome.TopLevel = false;
            formHome.Dock = DockStyle.Fill;
            panelMainContentAdmin.Controls.Add(formHome);
            formHome.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            panelMainContentAdmin.Controls.Clear();
            FormAddProduct formAdd = new FormAddProduct();
            formAdd.TopLevel = false;
            formAdd.Dock = DockStyle.Fill;
            panelMainContentAdmin.Controls.Add(formAdd);
            formAdd.Show();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            panelMainContentAdmin.Controls.Clear();
            FormSearchProduct formSearch = new FormSearchProduct();
            formSearch.TopLevel = false;
            formSearch.Dock = DockStyle.Fill;
            panelMainContentAdmin.Controls.Add(formSearch);
            formSearch.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
