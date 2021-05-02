namespace SimpleShopManagementSystem
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSalesmanLogin = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simple Shop Management System";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(250, 195);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '#';
            this.txtboxPassword.Size = new System.Drawing.Size(313, 44);
            this.txtboxPassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.ForeColor = System.Drawing.Color.White;
            this.lblAdminLogin.Location = new System.Drawing.Point(242, 121);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(141, 44);
            this.lblAdminLogin.TabIndex = 13;
            this.lblAdminLogin.Text = "Admin";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(296, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 46);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(440, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 46);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSalesmanLogin
            // 
            this.lblSalesmanLogin.AutoSize = true;
            this.lblSalesmanLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblSalesmanLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalesmanLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanLogin.ForeColor = System.Drawing.Color.Brown;
            this.lblSalesmanLogin.Location = new System.Drawing.Point(54, 311);
            this.lblSalesmanLogin.Name = "lblSalesmanLogin";
            this.lblSalesmanLogin.Size = new System.Drawing.Size(194, 28);
            this.lblSalesmanLogin.TabIndex = 16;
            this.lblSalesmanLogin.Text = "Salesman Login";
            this.lblSalesmanLogin.Click += new System.EventHandler(this.lblSalesmanLogin_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.SystemColors.Menu;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Maroon;
            this.lblExit.Location = new System.Drawing.Point(592, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 28);
            this.lblExit.TabIndex = 17;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(632, 393);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblSalesmanLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblAdminLogin);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSalesmanLogin;
        private System.Windows.Forms.Label lblExit;
    }
}