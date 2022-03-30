namespace GroceryShop
{
    partial class FormSearchProduct
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
            this.panelSearchEqpment = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.txtSearchProductById = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panelDataShowToSrchPrdct = new System.Windows.Forms.Panel();
            this.dgvProductShow = new System.Windows.Forms.DataGridView();
            this.ColProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCatagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearchEqpment.SuspendLayout();
            this.panelDataShowToSrchPrdct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchEqpment
            // 
            this.panelSearchEqpment.Controls.Add(this.btnSearch);
            this.panelSearchEqpment.Controls.Add(this.btnDeleteProduct);
            this.panelSearchEqpment.Controls.Add(this.btnUpdateProduct);
            this.panelSearchEqpment.Controls.Add(this.txtSearchProductById);
            this.panelSearchEqpment.Controls.Add(this.txtProductQuantity);
            this.panelSearchEqpment.Controls.Add(this.txtProductPrice);
            this.panelSearchEqpment.Controls.Add(this.lblSearchProduct);
            this.panelSearchEqpment.Controls.Add(this.lblProductQuantity);
            this.panelSearchEqpment.Controls.Add(this.lblProductPrice);
            this.panelSearchEqpment.Controls.Add(this.lblProductName);
            this.panelSearchEqpment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchEqpment.Location = new System.Drawing.Point(0, 0);
            this.panelSearchEqpment.Name = "panelSearchEqpment";
            this.panelSearchEqpment.Size = new System.Drawing.Size(706, 193);
            this.panelSearchEqpment.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(254, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(343, 121);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(132, 50);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Remove";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(343, 43);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(132, 50);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtSearchProductById
            // 
            this.txtSearchProductById.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductById.Location = new System.Drawing.Point(120, 142);
            this.txtSearchProductById.Name = "txtSearchProductById";
            this.txtSearchProductById.Size = new System.Drawing.Size(128, 21);
            this.txtSearchProductById.TabIndex = 10;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(120, 101);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(128, 21);
            this.txtProductQuantity.TabIndex = 9;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(120, 61);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(128, 21);
            this.txtProductPrice.TabIndex = 8;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(10, 139);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(92, 32);
            this.lblSearchProduct.TabIndex = 7;
            this.lblSearchProduct.Text = "Search Product\r\nBy Id\r\n";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(10, 101);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(102, 16);
            this.lblProductQuantity.TabIndex = 3;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(10, 61);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(80, 16);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(12, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(179, 28);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // panelDataShowToSrchPrdct
            // 
            this.panelDataShowToSrchPrdct.Controls.Add(this.dgvProductShow);
            this.panelDataShowToSrchPrdct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataShowToSrchPrdct.Location = new System.Drawing.Point(0, 193);
            this.panelDataShowToSrchPrdct.Name = "panelDataShowToSrchPrdct";
            this.panelDataShowToSrchPrdct.Size = new System.Drawing.Size(706, 368);
            this.panelDataShowToSrchPrdct.TabIndex = 1;
            // 
            // dgvProductShow
            // 
            this.dgvProductShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductId,
            this.ColProductName,
            this.ColProductCatagory,
            this.ColProductQuantity,
            this.ColProductPrice});
            this.dgvProductShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductShow.Location = new System.Drawing.Point(0, 0);
            this.dgvProductShow.MultiSelect = false;
            this.dgvProductShow.Name = "dgvProductShow";
            this.dgvProductShow.ReadOnly = true;
            this.dgvProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductShow.Size = new System.Drawing.Size(706, 368);
            this.dgvProductShow.TabIndex = 0;
            this.dgvProductShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductShow_CellClick);
            // 
            // ColProductId
            // 
            this.ColProductId.DataPropertyName = "productId";
            this.ColProductId.HeaderText = "Product Id";
            this.ColProductId.Name = "ColProductId";
            this.ColProductId.ReadOnly = true;
            // 
            // ColProductName
            // 
            this.ColProductName.DataPropertyName = "productName";
            this.ColProductName.HeaderText = "Product Name";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColProductCatagory
            // 
            this.ColProductCatagory.DataPropertyName = "catName";
            this.ColProductCatagory.HeaderText = "Product Catagory";
            this.ColProductCatagory.Name = "ColProductCatagory";
            this.ColProductCatagory.ReadOnly = true;
            // 
            // ColProductQuantity
            // 
            this.ColProductQuantity.DataPropertyName = "productQuantity";
            this.ColProductQuantity.HeaderText = "Product Quantity";
            this.ColProductQuantity.Name = "ColProductQuantity";
            this.ColProductQuantity.ReadOnly = true;
            // 
            // ColProductPrice
            // 
            this.ColProductPrice.DataPropertyName = "productPrice";
            this.ColProductPrice.HeaderText = "Product Price";
            this.ColProductPrice.Name = "ColProductPrice";
            this.ColProductPrice.ReadOnly = true;
            // 
            // FormSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 561);
            this.Controls.Add(this.panelDataShowToSrchPrdct);
            this.Controls.Add(this.panelSearchEqpment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearchProduct";
            this.Text = "FormSearchProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSearchProduct_FormClosed);
            this.panelSearchEqpment.ResumeLayout(false);
            this.panelSearchEqpment.PerformLayout();
            this.panelDataShowToSrchPrdct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchEqpment;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox txtSearchProductById;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel panelDataShowToSrchPrdct;
        private System.Windows.Forms.DataGridView dgvProductShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductCatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductPrice;
    }
}