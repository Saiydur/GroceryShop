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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        
        private double TotalPrice { set; get; }
        public CheckOut(ListView list,double totalPrice)
        {
            InitializeComponent();
            foreach(ListViewItem item in list.Items)
            {
                listViewCheckOut.Items.Add((ListViewItem)item.Clone());
            }
            TotalPrice = totalPrice;
            lblTotalPrice.Text += totalPrice.ToString() + "BDT";
            
        }

        private void CheckOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
