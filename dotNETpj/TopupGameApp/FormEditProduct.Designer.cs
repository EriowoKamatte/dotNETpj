namespace TopupGameApp
{
    partial class FormEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduct));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtGems = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.accountTableAdapter1 = new TopupGameApp.StoreDBDataSet1TableAdapters.ACCOUNTTableAdapter();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.NavigateBar = new System.Windows.Forms.Panel();
            this.lbUserInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WebName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchItemsBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.NavigateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(918, 184);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCredits
            // 
            this.txtCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCredits.Location = new System.Drawing.Point(1058, 226);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(90, 20);
            this.txtCredits.TabIndex = 1;
            this.txtCredits.Text = "0";
            // 
            // txtGems
            // 
            this.txtGems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGems.Location = new System.Drawing.Point(918, 226);
            this.txtGems.Name = "txtGems";
            this.txtGems.Size = new System.Drawing.Size(70, 20);
            this.txtGems.TabIndex = 2;
            this.txtGems.Text = "0";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(918, 278);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(230, 43);
            this.txtDesc.TabIndex = 3;
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(918, 347);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(230, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(834, 187);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 13);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gems:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1010, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Credits:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(915, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Description:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Price:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 116);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(777, 303);
            this.dgvProduct.TabIndex = 10;
            // 
            // NavigateBar
            // 
            this.NavigateBar.BackColor = System.Drawing.Color.SpringGreen;
            this.NavigateBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigateBar.BackgroundImage")));
            this.NavigateBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NavigateBar.Controls.Add(this.btnReturn);
            this.NavigateBar.Controls.Add(this.lbUserInfo);
            this.NavigateBar.Controls.Add(this.pictureBox1);
            this.NavigateBar.Controls.Add(this.WebName);
            this.NavigateBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigateBar.Location = new System.Drawing.Point(0, 0);
            this.NavigateBar.Margin = new System.Windows.Forms.Padding(2);
            this.NavigateBar.Name = "NavigateBar";
            this.NavigateBar.Size = new System.Drawing.Size(1188, 93);
            this.NavigateBar.TabIndex = 11;
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserInfo.AutoSize = true;
            this.lbUserInfo.BackColor = System.Drawing.Color.Honeydew;
            this.lbUserInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserInfo.Location = new System.Drawing.Point(1001, 6);
            this.lbUserInfo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lbUserInfo.Size = new System.Drawing.Size(173, 33);
            this.lbUserInfo.TabIndex = 5;
            this.lbUserInfo.Text = "Welcome, <username>";
            this.lbUserInfo.Visible = false;
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
            this.WebName.Location = new System.Drawing.Point(453, 20);
            this.WebName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebName.Name = "WebName";
            this.WebName.Size = new System.Drawing.Size(278, 40);
            this.WebName.TabIndex = 6;
            this.WebName.Text = "TOP-UP CENTER";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(1085, 46);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 36);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.btnSearchItems);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(833, 116);
            this.panel3.MaximumSize = new System.Drawing.Size(431, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 43);
            this.panel3.TabIndex = 14;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItems.Location = new System.Drawing.Point(225, 3);
            this.btnSearchItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(90, 36);
            this.btnSearchItems.TabIndex = 3;
            this.btnSearchItems.Text = "Search by Name";
            this.btnSearchItems.UseVisualStyleBackColor = true;
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
            this.panel4.Size = new System.Drawing.Size(217, 36);
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
            this.txtSearchItemsBox.Size = new System.Drawing.Size(197, 16);
            this.txtSearchItemsBox.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1058, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 430);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NavigateBar);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtGems);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtName);
            this.Name = "FormEditProduct";
            this.Text = "FormEditProduct";
            this.Load += new System.EventHandler(this.FormEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.NavigateBar.ResumeLayout(false);
            this.NavigateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtGems;
        private System.Windows.Forms.TextBox txtDesc;
        private StoreDBDataSet1TableAdapters.ACCOUNTTableAdapter accountTableAdapter1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel NavigateBar;
        private System.Windows.Forms.Label lbUserInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WebName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchItemsBox;
        private System.Windows.Forms.Button btnAdd;
    }
}