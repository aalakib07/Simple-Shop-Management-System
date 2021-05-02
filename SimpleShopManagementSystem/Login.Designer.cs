namespace SimpleShopManagementSystem
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Shop Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(247, 149);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(313, 44);
            this.txtboxUsername.TabIndex = 0;
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(437, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(293, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.ForeColor = System.Drawing.Color.Brown;
            this.lblAdminLogin.Location = new System.Drawing.Point(53, 314);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(158, 28);
            this.lblAdminLogin.TabIndex = 4;
            this.lblAdminLogin.Text = "Admin Login";
            this.lblAdminLogin.Click += new System.EventHandler(this.lblAdminLogin_Click);
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
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(247, 224);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '#';
            this.txtboxPassword.Size = new System.Drawing.Size(313, 44);
            this.txtboxPassword.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(632, 393);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAdminLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TextBox txtboxPassword;
    }
}