namespace GroceryShop
{
    partial class FormManager
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.panelDataListView = new System.Windows.Forms.Panel();
            this.listViewProductCart = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteFromCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtSearchProductById = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityOfProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceOfProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceOfParticularProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelButtons.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            this.panelDataListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnCheckOut);
            this.panelButtons.Controls.Add(this.btnSearch);
            this.panelButtons.Controls.Add(this.btnDeleteFromCart);
            this.panelButtons.Controls.Add(this.btnAddToCart);
            this.panelButtons.Controls.Add(this.txtSearchProductById);
            this.panelButtons.Controls.Add(this.txtProductQuantity);
            this.panelButtons.Controls.Add(this.txtProductPrice);
            this.panelButtons.Controls.Add(this.lblSearchProduct);
            this.panelButtons.Controls.Add(this.lblProductQuantity);
            this.panelButtons.Controls.Add(this.lblProductPrice);
            this.panelButtons.Controls.Add(this.lblProductName);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1084, 163);
            this.panelButtons.TabIndex = 0;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dgvShowData);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 163);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1084, 398);
            this.panelDataGridView.TabIndex = 1;
            // 
            // panelDataListView
            // 
            this.panelDataListView.Controls.Add(this.listViewProductCart);
            this.panelDataListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDataListView.Location = new System.Drawing.Point(650, 163);
            this.panelDataListView.Name = "panelDataListView";
            this.panelDataListView.Size = new System.Drawing.Size(434, 398);
            this.panelDataListView.TabIndex = 2;
            // 
            // listViewProductCart
            // 
            this.listViewProductCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameOfProduct,
            this.QuantityOfProduct,
            this.PriceOfProduct,
            this.TotalPriceOfParticularProduct});
            this.listViewProductCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProductCart.FullRowSelect = true;
            this.listViewProductCart.GridLines = true;
            this.listViewProductCart.HideSelection = false;
            this.listViewProductCart.Location = new System.Drawing.Point(0, 0);
            this.listViewProductCart.MultiSelect = false;
            this.listViewProductCart.Name = "listViewProductCart";
            this.listViewProductCart.Size = new System.Drawing.Size(434, 398);
            this.listViewProductCart.TabIndex = 0;
            this.listViewProductCart.UseCompatibleStateImageBehavior = false;
            this.listViewProductCart.View = System.Windows.Forms.View.Details;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(337, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteFromCart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFromCart.Location = new System.Drawing.Point(625, 52);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(132, 50);
            this.btnDeleteFromCart.TabIndex = 24;
            this.btnDeleteFromCart.Text = "Remove";
            this.btnDeleteFromCart.UseVisualStyleBackColor = true;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(457, 52);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(132, 50);
            this.btnAddToCart.TabIndex = 23;
            this.btnAddToCart.Text = "ADD";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtSearchProductById
            // 
            this.txtSearchProductById.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchProductById.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductById.Location = new System.Drawing.Point(185, 130);
            this.txtSearchProductById.Name = "txtSearchProductById";
            this.txtSearchProductById.Size = new System.Drawing.Size(128, 21);
            this.txtSearchProductById.TabIndex = 22;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductQuantity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(185, 89);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(128, 21);
            this.txtProductQuantity.TabIndex = 21;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(185, 52);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(128, 21);
            this.txtProductPrice.TabIndex = 20;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(78, 122);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(92, 32);
            this.lblSearchProduct.TabIndex = 19;
            this.lblSearchProduct.Text = "Search Product\r\nBy Id\r\n";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(78, 92);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(102, 16);
            this.lblProductQuantity.TabIndex = 18;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(78, 55);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(80, 16);
            this.lblProductPrice.TabIndex = 17;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(76, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(179, 28);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "Product Name";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(795, 52);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(207, 50);
            this.btnCheckOut.TabIndex = 26;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgvShowData
            // 
            this.dgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.Location = new System.Drawing.Point(0, 0);
            this.dgvShowData.MultiSelect = false;
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(1084, 398);
            this.dgvShowData.TabIndex = 0;
            this.dgvShowData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellDoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "productId";
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "productName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "productPrice";
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "productQuantity";
            this.ProductQuantity.HeaderText = "Product Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.Text = "Product Name";
            this.NameOfProduct.Width = 80;
            // 
            // QuantityOfProduct
            // 
            this.QuantityOfProduct.Text = "Product Quantity";
            this.QuantityOfProduct.Width = 94;
            // 
            // PriceOfProduct
            // 
            this.PriceOfProduct.Text = "Product Price";
            this.PriceOfProduct.Width = 120;
            // 
            // TotalPriceOfParticularProduct
            // 
            this.TotalPriceOfParticularProduct.Text = "Total Price";
            this.TotalPriceOfParticularProduct.Width = 120;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelDataListView);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManager_FormClosed);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            this.panelDataListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Panel panelDataListView;
        private System.Windows.Forms.ListView listViewProductCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteFromCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtSearchProductById;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.ColumnHeader NameOfProduct;
        private System.Windows.Forms.ColumnHeader QuantityOfProduct;
        private System.Windows.Forms.ColumnHeader PriceOfProduct;
        private System.Windows.Forms.ColumnHeader TotalPriceOfParticularProduct;
    }
}