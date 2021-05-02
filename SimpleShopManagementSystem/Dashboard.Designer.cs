namespace SimpleShopManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSalesman = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGV)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(9, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 180);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.btnSalesman);
            this.panel2.Controls.Add(this.btnProducts);
            this.panel2.Location = new System.Drawing.Point(9, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 577);
            this.panel2.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(5, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(277, 63);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Teal;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(4, 222);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(277, 63);
            this.btnDashboard.TabIndex = 29;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnSalesman
            // 
            this.btnSalesman.BackColor = System.Drawing.Color.Orange;
            this.btnSalesman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesman.FlatAppearance.BorderSize = 0;
            this.btnSalesman.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSalesman.ForeColor = System.Drawing.Color.White;
            this.btnSalesman.Location = new System.Drawing.Point(4, 297);
            this.btnSalesman.Name = "btnSalesman";
            this.btnSalesman.Size = new System.Drawing.Size(277, 63);
            this.btnSalesman.TabIndex = 28;
            this.btnSalesman.Text = "Salesman";
            this.btnSalesman.UseVisualStyleBackColor = false;
            this.btnSalesman.Click += new System.EventHandler(this.btnSalesman_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.ForestGreen;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(4, 145);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(277, 63);
            this.btnProducts.TabIndex = 27;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.txtboxSearch);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.orderGV);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(302, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 763);
            this.panel1.TabIndex = 6;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.SystemColors.Menu;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Maroon;
            this.lblMinimize.Location = new System.Drawing.Point(1108, 12);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(24, 28);
            this.lblMinimize.TabIndex = 32;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(575, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Order Details";
            // 
            // orderGV
            // 
            this.orderGV.AllowUserToAddRows = false;
            this.orderGV.AllowUserToDeleteRows = false;
            this.orderGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.orderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.orderGV.Location = new System.Drawing.Point(480, 279);
            this.orderGV.Name = "orderGV";
            this.orderGV.ReadOnly = true;
            this.orderGV.RowTemplate.Height = 24;
            this.orderGV.RowTemplate.ReadOnly = true;
            this.orderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGV.Size = new System.Drawing.Size(694, 481);
            this.orderGV.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "orderid";
            this.Column1.HeaderText = "Order No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "uname";
            this.Column2.HeaderText = "Salesman Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "customername";
            this.Column3.HeaderText = "Customer Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "amount";
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblNumber);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(67, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1034, 89);
            this.panel6.TabIndex = 23;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(883, 26);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(145, 40);
            this.lblNumber.TabIndex = 21;
            this.lblNumber.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total Salesman in Shop:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblAmount);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 481);
            this.panel5.TabIndex = 22;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Red;
            this.lblAmount.Location = new System.Drawing.Point(109, 188);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(258, 70);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(153, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 40);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Sale";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.SystemColors.Menu;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Maroon;
            this.lblExit.Location = new System.Drawing.Point(1138, 12);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 28);
            this.lblExit.TabIndex = 18;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Simple Shop Management System";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxSearch.Location = new System.Drawing.Point(823, 232);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(324, 44);
            this.txtboxSearch.TabIndex = 33;
            this.txtboxSearch.Text = "Search by salesman";
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            this.txtboxSearch.Enter += new System.EventHandler(this.txtboxSearch_Enter);
            this.txtboxSearch.Leave += new System.EventHandler(this.txtboxSearch_Leave);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 787);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSalesman;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView orderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.TextBox txtboxSearch;
    }
}