namespace GroceryShop
{
    partial class FormHome
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
            this.lblCatergoryName = new System.Windows.Forms.Label();
            this.txtCategoreyName = new System.Windows.Forms.TextBox();
            this.btnAddCatergorey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCatergoryName
            // 
            this.lblCatergoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCatergoryName.AutoSize = true;
            this.lblCatergoryName.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatergoryName.Location = new System.Drawing.Point(63, 226);
            this.lblCatergoryName.Name = "lblCatergoryName";
            this.lblCatergoryName.Size = new System.Drawing.Size(228, 33);
            this.lblCatergoryName.TabIndex = 0;
            this.lblCatergoryName.Text = "Categorey Name";
            // 
            // txtCategoreyName
            // 
            this.txtCategoreyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoreyName.Location = new System.Drawing.Point(306, 227);
            this.txtCategoreyName.Multiline = true;
            this.txtCategoreyName.Name = "txtCategoreyName";
            this.txtCategoreyName.Size = new System.Drawing.Size(329, 32);
            this.txtCategoreyName.TabIndex = 0;
            // 
            // btnAddCatergorey
            // 
            this.btnAddCatergorey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCatergorey.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCatergorey.Location = new System.Drawing.Point(277, 311);
            this.btnAddCatergorey.Name = "btnAddCatergorey";
            this.btnAddCatergorey.Size = new System.Drawing.Size(152, 46);
            this.btnAddCatergorey.TabIndex = 1;
            this.btnAddCatergorey.Text = "Add";
            this.btnAddCatergorey.UseVisualStyleBackColor = true;
            this.btnAddCatergorey.Click += new System.EventHandler(this.btnAddCatergorey_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(706, 561);
            this.Controls.Add(this.btnAddCatergorey);
            this.Controls.Add(this.txtCategoreyName);
            this.Controls.Add(this.lblCatergoryName);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatergoryName;
        private System.Windows.Forms.TextBox txtCategoreyName;
        private System.Windows.Forms.Button btnAddCatergorey;
    }
}