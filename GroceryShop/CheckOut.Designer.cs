namespace GroceryShop
{
    partial class CheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panelListView = new System.Windows.Forms.Panel();
            this.listViewCheckOut = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceOfParticularProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panelListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 33);
            this.panel1.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(156, 3);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(124, 23);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Net Amount:";
            // 
            // panelListView
            // 
            this.panelListView.Controls.Add(this.listViewCheckOut);
            this.panelListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListView.Location = new System.Drawing.Point(0, 0);
            this.panelListView.Name = "panelListView";
            this.panelListView.Size = new System.Drawing.Size(374, 563);
            this.panelListView.TabIndex = 2;
            // 
            // listViewCheckOut
            // 
            this.listViewCheckOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice,
            this.TotalPriceOfParticularProduct});
            this.listViewCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCheckOut.GridLines = true;
            this.listViewCheckOut.HideSelection = false;
            this.listViewCheckOut.Location = new System.Drawing.Point(0, 0);
            this.listViewCheckOut.MultiSelect = false;
            this.listViewCheckOut.Name = "listViewCheckOut";
            this.listViewCheckOut.Size = new System.Drawing.Size(374, 563);
            this.listViewCheckOut.TabIndex = 0;
            this.listViewCheckOut.UseCompatibleStateImageBehavior = false;
            this.listViewCheckOut.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 102;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Text = "Product Quantity";
            this.ProductQuantity.Width = 104;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Product Price";
            this.ProductPrice.Width = 87;
            // 
            // TotalPriceOfParticularProduct
            // 
            this.TotalPriceOfParticularProduct.Text = "Total Price";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 596);
            this.Controls.Add(this.panelListView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 635);
            this.MinimumSize = new System.Drawing.Size(390, 635);
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckOut_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelListView;
        private System.Windows.Forms.ListView listViewCheckOut;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductQuantity;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ColumnHeader TotalPriceOfParticularProduct;
    }
}