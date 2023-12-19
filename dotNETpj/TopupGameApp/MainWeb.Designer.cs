namespace TopupGameApp
{
    partial class MainWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWeb));
            this.NavigateBar = new System.Windows.Forms.Panel();
            this.lbUserInfo = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WebName = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet1 = new TopupGameApp.StoreDBDataSet1();
            this.storeDBDataSet = new TopupGameApp.StoreDBDataSet();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new TopupGameApp.StoreDBDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new TopupGameApp.StoreDBDataSetTableAdapters.TableAdapterManager();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQtt = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbYourCart = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalCart = new System.Windows.Forms.Label();
            this.picGems = new System.Windows.Forms.PictureBox();
            this.picCredits = new System.Windows.Forms.PictureBox();
            this.lbCartGems = new System.Windows.Forms.Label();
            this.lbCartCredits = new System.Windows.Forms.Label();
            this.pRODUCTTableAdapter1 = new TopupGameApp.StoreDBDataSet1TableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager1 = new TopupGameApp.StoreDBDataSet1TableAdapters.TableAdapterManager();
            this.pRODUCTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lbUserCredits = new System.Windows.Forms.Label();
            this.lbUserGems = new System.Windows.Forms.Label();
            this.picUserCredits = new System.Windows.Forms.PictureBox();
            this.picUserGems = new System.Windows.Forms.PictureBox();
            this.lbvnd = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.NavigateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserGems)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigateBar
            // 
            this.NavigateBar.BackColor = System.Drawing.Color.SpringGreen;
            this.NavigateBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigateBar.BackgroundImage")));
            this.NavigateBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NavigateBar.Controls.Add(this.lbUserInfo);
            this.NavigateBar.Controls.Add(this.btnSignOut);
            this.NavigateBar.Controls.Add(this.pictureBox1);
            this.NavigateBar.Controls.Add(this.WebName);
            this.NavigateBar.Controls.Add(this.btnCart);
            this.NavigateBar.Controls.Add(this.btnSignup);
            this.NavigateBar.Controls.Add(this.btnLogin);
            this.NavigateBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigateBar.Location = new System.Drawing.Point(0, 0);
            this.NavigateBar.Margin = new System.Windows.Forms.Padding(2);
            this.NavigateBar.Name = "NavigateBar";
            this.NavigateBar.Size = new System.Drawing.Size(924, 93);
            this.NavigateBar.TabIndex = 0;
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserInfo.AutoSize = true;
            this.lbUserInfo.BackColor = System.Drawing.Color.Honeydew;
            this.lbUserInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserInfo.Location = new System.Drawing.Point(743, 5);
            this.lbUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lbUserInfo.Size = new System.Drawing.Size(173, 33);
            this.lbUserInfo.TabIndex = 5;
            this.lbUserInfo.Text = "Welcome, <username>";
            this.lbUserInfo.Visible = false;
            this.lbUserInfo.Click += new System.EventHandler(this.lbUserInfo_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.Location = new System.Drawing.Point(734, 43);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 36);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Visible = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            this.WebName.Location = new System.Drawing.Point(321, 20);
            this.WebName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebName.Name = "WebName";
            this.WebName.Size = new System.Drawing.Size(278, 40);
            this.WebName.TabIndex = 6;
            this.WebName.Text = "TOP-UP CENTER";
            this.WebName.Click += new System.EventHandler(this.WebName_Click);
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.Location = new System.Drawing.Point(828, 43);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(90, 36);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "My Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Visible = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignup.Location = new System.Drawing.Point(734, 2);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(90, 36);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(828, 2);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSearch.Controls.Add(this.SearchBox);
            this.pnSearch.Location = new System.Drawing.Point(0, 3);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnSearch.MaximumSize = new System.Drawing.Size(333, 36);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(331, 36);
            this.pnSearch.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(8, 10);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(311, 16);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(337, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 48);
            this.panel1.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodNameDataGridViewTextBoxColumn,
            this.prodDescDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProduct.DataSource = this.pRODUCTBindingSource1;
            this.dgvProduct.Location = new System.Drawing.Point(10, 195);
            this.dgvProduct.MaximumSize = new System.Drawing.Size(429, 800);
            this.dgvProduct.MinimumSize = new System.Drawing.Size(319, 268);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 30;
            this.dgvProduct.Size = new System.Drawing.Size(429, 269);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEnter);
            this.dgvProduct.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellLeave);
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodDescDataGridViewTextBoxColumn
            // 
            this.prodDescDataGridViewTextBoxColumn.DataPropertyName = "ProdDesc";
            this.prodDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.prodDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescDataGridViewTextBoxColumn.Name = "prodDescDataGridViewTextBoxColumn";
            this.prodDescDataGridViewTextBoxColumn.Width = 170;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.storeDBDataSet1;
            // 
            // storeDBDataSet1
            // 
            this.storeDBDataSet1.DataSetName = "StoreDBDataSet1";
            this.storeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.storeDBDataSet;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLTableAdapter = null;
            this.tableAdapterManager.CARTTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_ITEMSTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
            this.tableAdapterManager.UpdateOrder = TopupGameApp.StoreDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(452, 195);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.Size = new System.Drawing.Size(460, 225);
            this.dgvCart.TabIndex = 5;
            this.dgvCart.Visible = false;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(600, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(710, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(504, 466);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(78, 29);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Visible = false;
            // 
            // lbQtt
            // 
            this.lbQtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQtt.AutoSize = true;
            this.lbQtt.Location = new System.Drawing.Point(449, 477);
            this.lbQtt.Name = "lbQtt";
            this.lbQtt.Size = new System.Drawing.Size(49, 13);
            this.lbQtt.TabIndex = 9;
            this.lbQtt.Text = "Quantity:";
            this.lbQtt.Visible = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchase.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(819, 434);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(93, 61);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "BUY";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Visible = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.pnSearch);
            this.panel2.Location = new System.Drawing.Point(10, 142);
            this.panel2.MaximumSize = new System.Drawing.Size(431, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 47);
            this.panel2.TabIndex = 11;
            // 
            // lbYourCart
            // 
            this.lbYourCart.AutoSize = true;
            this.lbYourCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourCart.Location = new System.Drawing.Point(640, 153);
            this.lbYourCart.Name = "lbYourCart";
            this.lbYourCart.Size = new System.Drawing.Size(86, 20);
            this.lbYourCart.TabIndex = 12;
            this.lbYourCart.Text = "Your Cart";
            this.lbYourCart.Visible = false;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(657, 438);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(48, 20);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Total:";
            this.lbTotal.Visible = false;
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // lbTotalCart
            // 
            this.lbTotalCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalCart.AutoSize = true;
            this.lbTotalCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCart.Location = new System.Drawing.Point(704, 438);
            this.lbTotalCart.Name = "lbTotalCart";
            this.lbTotalCart.Size = new System.Drawing.Size(19, 20);
            this.lbTotalCart.TabIndex = 14;
            this.lbTotalCart.Text = "0";
            this.lbTotalCart.Visible = false;
            // 
            // picGems
            // 
            this.picGems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picGems.Image = ((System.Drawing.Image)(resources.GetObject("picGems.Image")));
            this.picGems.Location = new System.Drawing.Point(449, 434);
            this.picGems.Name = "picGems";
            this.picGems.Size = new System.Drawing.Size(27, 27);
            this.picGems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGems.TabIndex = 15;
            this.picGems.TabStop = false;
            this.picGems.Visible = false;
            // 
            // picCredits
            // 
            this.picCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCredits.Image = ((System.Drawing.Image)(resources.GetObject("picCredits.Image")));
            this.picCredits.Location = new System.Drawing.Point(534, 433);
            this.picCredits.Name = "picCredits";
            this.picCredits.Size = new System.Drawing.Size(27, 27);
            this.picCredits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCredits.TabIndex = 16;
            this.picCredits.TabStop = false;
            this.picCredits.Visible = false;
            // 
            // lbCartGems
            // 
            this.lbCartGems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCartGems.AutoSize = true;
            this.lbCartGems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartGems.Location = new System.Drawing.Point(478, 441);
            this.lbCartGems.Name = "lbCartGems";
            this.lbCartGems.Size = new System.Drawing.Size(16, 16);
            this.lbCartGems.TabIndex = 17;
            this.lbCartGems.Text = "0";
            this.lbCartGems.Visible = false;
            // 
            // lbCartCredits
            // 
            this.lbCartCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCartCredits.AutoSize = true;
            this.lbCartCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartCredits.Location = new System.Drawing.Point(563, 441);
            this.lbCartCredits.Name = "lbCartCredits";
            this.lbCartCredits.Size = new System.Drawing.Size(16, 16);
            this.lbCartCredits.TabIndex = 18;
            this.lbCartCredits.Text = "0";
            this.lbCartCredits.Visible = false;
            // 
            // pRODUCTTableAdapter1
            // 
            this.pRODUCTTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ACCOUNTTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CART_ITEMSTableAdapter = null;
            this.tableAdapterManager1.CARTTableAdapter = null;
            this.tableAdapterManager1.MYORDERTableAdapter = null;
            this.tableAdapterManager1.ORDER_ITEMSTableAdapter = null;
            this.tableAdapterManager1.PRODUCTTableAdapter = this.pRODUCTTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = TopupGameApp.StoreDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pRODUCTBindingSource2
            // 
            this.pRODUCTBindingSource2.DataMember = "PRODUCT";
            this.pRODUCTBindingSource2.DataSource = this.storeDBDataSet1;
            // 
            // pRODUCTBindingSource3
            // 
            this.pRODUCTBindingSource3.DataMember = "PRODUCT";
            this.pRODUCTBindingSource3.DataSource = this.storeDBDataSet1;
            // 
            // lbUserCredits
            // 
            this.lbUserCredits.AutoSize = true;
            this.lbUserCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserCredits.Location = new System.Drawing.Point(125, 110);
            this.lbUserCredits.Name = "lbUserCredits";
            this.lbUserCredits.Size = new System.Drawing.Size(16, 16);
            this.lbUserCredits.TabIndex = 22;
            this.lbUserCredits.Text = "0";
            this.lbUserCredits.Visible = false;
            // 
            // lbUserGems
            // 
            this.lbUserGems.AutoSize = true;
            this.lbUserGems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserGems.Location = new System.Drawing.Point(40, 110);
            this.lbUserGems.Name = "lbUserGems";
            this.lbUserGems.Size = new System.Drawing.Size(16, 16);
            this.lbUserGems.TabIndex = 21;
            this.lbUserGems.Text = "0";
            this.lbUserGems.Visible = false;
            // 
            // picUserCredits
            // 
            this.picUserCredits.Image = ((System.Drawing.Image)(resources.GetObject("picUserCredits.Image")));
            this.picUserCredits.Location = new System.Drawing.Point(96, 102);
            this.picUserCredits.Name = "picUserCredits";
            this.picUserCredits.Size = new System.Drawing.Size(27, 27);
            this.picUserCredits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCredits.TabIndex = 20;
            this.picUserCredits.TabStop = false;
            this.picUserCredits.Visible = false;
            // 
            // picUserGems
            // 
            this.picUserGems.Image = ((System.Drawing.Image)(resources.GetObject("picUserGems.Image")));
            this.picUserGems.Location = new System.Drawing.Point(11, 103);
            this.picUserGems.Name = "picUserGems";
            this.picUserGems.Size = new System.Drawing.Size(27, 27);
            this.picUserGems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserGems.TabIndex = 19;
            this.picUserGems.TabStop = false;
            this.picUserGems.Visible = false;
            // 
            // lbvnd
            // 
            this.lbvnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbvnd.AutoSize = true;
            this.lbvnd.Location = new System.Drawing.Point(802, 438);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(14, 13);
            this.lbvnd.TabIndex = 23;
            this.lbvnd.Text = "đ";
            this.lbvnd.Visible = false;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(819, 157);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(93, 30);
            this.btnHistory.TabIndex = 24;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Visible = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // MainWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(924, 548);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lbvnd);
            this.Controls.Add(this.lbUserCredits);
            this.Controls.Add(this.lbUserGems);
            this.Controls.Add(this.picUserCredits);
            this.Controls.Add(this.picUserGems);
            this.Controls.Add(this.lbCartCredits);
            this.Controls.Add(this.lbCartGems);
            this.Controls.Add(this.picCredits);
            this.Controls.Add(this.picGems);
            this.Controls.Add(this.lbTotalCart);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbYourCart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lbQtt);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavigateBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(829, 587);
            this.Name = "MainWeb";
            this.Load += new System.EventHandler(this.MainWeb_Load);
            this.NavigateBar.ResumeLayout(false);
            this.NavigateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserGems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavigateBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label WebName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private StoreDBDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private StoreDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StoreDBDataSet1 storeDBDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private StoreDBDataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter1;
        private StoreDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource3;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource2;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lbUserInfo;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQtt;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbYourCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalCart;
        private System.Windows.Forms.PictureBox picGems;
        private System.Windows.Forms.PictureBox picCredits;
        private System.Windows.Forms.Label lbCartGems;
        private System.Windows.Forms.Label lbCartCredits;
        private System.Windows.Forms.Label lbUserCredits;
        private System.Windows.Forms.Label lbUserGems;
        private System.Windows.Forms.PictureBox picUserCredits;
        private System.Windows.Forms.PictureBox picUserGems;
        private System.Windows.Forms.Label lbvnd;
        private System.Windows.Forms.Button btnHistory;
    }
}

