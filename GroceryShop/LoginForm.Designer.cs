namespace GroceryShop
{
    partial class LoginForm
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
            this.PanelHeaderLoginForm = new System.Windows.Forms.Panel();
            this.lblLoginFormHeader = new System.Windows.Forms.Label();
            this.PanelMainContentLoginForm = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.PanelHeaderLoginForm.SuspendLayout();
            this.PanelMainContentLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeaderLoginForm
            // 
            this.PanelHeaderLoginForm.Controls.Add(this.lblLoginFormHeader);
            this.PanelHeaderLoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderLoginForm.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderLoginForm.Name = "PanelHeaderLoginForm";
            this.PanelHeaderLoginForm.Size = new System.Drawing.Size(884, 182);
            this.PanelHeaderLoginForm.TabIndex = 0;
            // 
            // lblLoginFormHeader
            // 
            this.lblLoginFormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginFormHeader.AutoSize = true;
            this.lblLoginFormHeader.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginFormHeader.Location = new System.Drawing.Point(196, 69);
            this.lblLoginFormHeader.Name = "lblLoginFormHeader";
            this.lblLoginFormHeader.Size = new System.Drawing.Size(492, 44);
            this.lblLoginFormHeader.TabIndex = 0;
            this.lblLoginFormHeader.Text = "Welcome To Grocery Shop";
            // 
            // PanelMainContentLoginForm
            // 
            this.PanelMainContentLoginForm.Controls.Add(this.lblUserRole);
            this.PanelMainContentLoginForm.Controls.Add(this.btnLogin);
            this.PanelMainContentLoginForm.Controls.Add(this.btnCreateAccount);
            this.PanelMainContentLoginForm.Controls.Add(this.txtUserPassword);
            this.PanelMainContentLoginForm.Controls.Add(this.txtUserName);
            this.PanelMainContentLoginForm.Controls.Add(this.lblUserPassword);
            this.PanelMainContentLoginForm.Controls.Add(this.lblUserName);
            this.PanelMainContentLoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainContentLoginForm.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelMainContentLoginForm.Location = new System.Drawing.Point(0, 182);
            this.PanelMainContentLoginForm.Name = "PanelMainContentLoginForm";
            this.PanelMainContentLoginForm.Size = new System.Drawing.Size(884, 379);
            this.PanelMainContentLoginForm.TabIndex = 1;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(65, 229);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(58, 15);
            this.lblUserRole.TabIndex = 11;
            this.lblUserRole.Text = "User Role";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(376, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 47);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAccount.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(333, 279);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(219, 39);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserPassword.Location = new System.Drawing.Point(408, 137);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(250, 21);
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(408, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(226, 135);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(148, 23);
            this.lblUserPassword.TabIndex = 1;
            this.lblUserPassword.Text = "User Password";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(226, 90);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.PanelMainContentLoginForm);
            this.Controls.Add(this.PanelHeaderLoginForm);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.PanelHeaderLoginForm.ResumeLayout(false);
            this.PanelHeaderLoginForm.PerformLayout();
            this.PanelMainContentLoginForm.ResumeLayout(false);
            this.PanelMainContentLoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeaderLoginForm;
        private System.Windows.Forms.Label lblLoginFormHeader;
        private System.Windows.Forms.Panel PanelMainContentLoginForm;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblUserRole;
    }
}

