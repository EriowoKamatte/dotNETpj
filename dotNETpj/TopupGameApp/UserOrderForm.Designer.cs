namespace TopupGameApp
{
    partial class UserOrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrderForm));
            this.dgvBillItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavigateBar = new System.Windows.Forms.Panel();
            this.lbUserInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WebName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.storeDBDataSet1 = new TopupGameApp.StoreDBDataSet1();
            this.storeDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchItemsBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.dash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillItems)).BeginInit();
            this.NavigateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBillItems
            // 
            this.dgvBillItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBillItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillItems.Location = new System.Drawing.Point(342, 142);
            this.dgvBillItems.Name = "dgvBillItems";
            this.dgvBillItems.Size = new System.Drawing.Size(527, 255);
            this.dgvBillItems.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 48);
            this.panel1.TabIndex = 5;
            // 
            // NavigateBar
            // 
            this.NavigateBar.BackColor = System.Drawing.Color.SpringGreen;
            this.NavigateBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigateBar.BackgroundImage")));
            this.NavigateBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NavigateBar.Controls.Add(this.lbUserInfo);
            this.NavigateBar.Controls.Add(this.btnReturn);
            this.NavigateBar.Controls.Add(this.pictureBox1);
            this.NavigateBar.Controls.Add(this.WebName);
            this.NavigateBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigateBar.Location = new System.Drawing.Point(0, 0);
            this.NavigateBar.Margin = new System.Windows.Forms.Padding(2);
            this.NavigateBar.Name = "NavigateBar";
            this.NavigateBar.Size = new System.Drawing.Size(881, 93);
            this.NavigateBar.TabIndex = 4;
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserInfo.AutoSize = true;
            this.lbUserInfo.BackColor = System.Drawing.Color.Honeydew;
            this.lbUserInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserInfo.Location = new System.Drawing.Point(694, 6);
            this.lbUserInfo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lbUserInfo.Size = new System.Drawing.Size(173, 33);
            this.lbUserInfo.TabIndex = 5;
            this.lbUserInfo.Text = "Welcome, <username>";
            this.lbUserInfo.Visible = false;
            this.lbUserInfo.Click += new System.EventHandler(this.lbUserInfo_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(777, 45);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 36);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(39, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 102);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // WebName
            // 
            this.WebName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WebName.AutoSize = true;
            this.WebName.BackColor = System.Drawing.Color.Transparent;
            this.WebName.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebName.ForeColor = System.Drawing.Color.White;
            this.WebName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WebName.Location = new System.Drawing.Point(299, 20);
            this.WebName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebName.Name = "WebName";
            this.WebName.Size = new System.Drawing.Size(278, 40);
            this.WebName.TabIndex = 6;
            this.WebName.Text = "TOP-UP CENTER";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.dash);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnSearchBill);
            this.panel2.Controls.Add(this.pnSearch);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.MaximumSize = new System.Drawing.Size(431, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 43);
            this.panel2.TabIndex = 12;
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBill.Location = new System.Drawing.Point(228, 3);
            this.btnSearchBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(90, 36);
            this.btnSearchBill.TabIndex = 3;
            this.btnSearchBill.Text = "Search by Date";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSearch.Controls.Add(this.txtStartDate);
            this.pnSearch.Location = new System.Drawing.Point(0, 3);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnSearch.MaximumSize = new System.Drawing.Size(333, 36);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(105, 36);
            this.pnSearch.TabIndex = 4;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtStartDate.Location = new System.Drawing.Point(8, 10);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(85, 16);
            this.txtStartDate.TabIndex = 0;
            this.txtStartDate.Text = "2003/12/29";
            this.txtStartDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtStartDate_MouseClick);
            // 
            // storeDBDataSet1
            // 
            this.storeDBDataSet1.DataSetName = "StoreDBDataSet1";
            this.storeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeDBDataSet1BindingSource
            // 
            this.storeDBDataSet1BindingSource.DataSource = this.storeDBDataSet1;
            this.storeDBDataSet1BindingSource.Position = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(12, 142);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(318, 255);
            this.dgvBill.TabIndex = 13;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.btnSearchItems);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(342, 93);
            this.panel3.MaximumSize = new System.Drawing.Size(431, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 43);
            this.panel3.TabIndex = 13;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItems.Location = new System.Drawing.Point(341, 3);
            this.btnSearchItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(90, 36);
            this.btnSearchItems.TabIndex = 3;
            this.btnSearchItems.Text = "Search by Name";
            this.btnSearchItems.UseVisualStyleBackColor = true;
            this.btnSearchItems.Click += new System.EventHandler(this.btnSearchItems_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtSearchItemsBox);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.MaximumSize = new System.Drawing.Size(333, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 36);
            this.panel4.TabIndex = 4;
            // 
            // txtSearchItemsBox
            // 
            this.txtSearchItemsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItemsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchItemsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItemsBox.Location = new System.Drawing.Point(8, 10);
            this.txtSearchItemsBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchItemsBox.Name = "txtSearchItemsBox";
            this.txtSearchItemsBox.Size = new System.Drawing.Size(313, 16);
            this.txtSearchItemsBox.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtEndDate);
            this.panel5.Location = new System.Drawing.Point(114, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.MaximumSize = new System.Drawing.Size(333, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(105, 36);
            this.panel5.TabIndex = 5;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEndDate.Location = new System.Drawing.Point(8, 10);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(85, 16);
            this.txtEndDate.TabIndex = 0;
            this.txtEndDate.Text = "2023/12/29";
            this.txtEndDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEndDate_MouseClick);
            // 
            // dash
            // 
            this.dash.AutoSize = true;
            this.dash.Location = new System.Drawing.Point(104, 15);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(10, 13);
            this.dash.TabIndex = 6;
            this.dash.Text = "-";
            // 
            // UserOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBillItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavigateBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 490);
            this.Name = "UserOrderForm";
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.UserOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillItems)).EndInit();
            this.NavigateBar.ResumeLayout(false);
            this.NavigateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel NavigateBar;
        private System.Windows.Forms.Label lbUserInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WebName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchBill;
        private StoreDBDataSet1 storeDBDataSet1;
        private System.Windows.Forms.BindingSource storeDBDataSet1BindingSource;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchItemsBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label dash;
    }
}