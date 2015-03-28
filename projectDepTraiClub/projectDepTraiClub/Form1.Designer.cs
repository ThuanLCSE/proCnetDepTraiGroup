namespace Project
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tCustomer = new System.Windows.Forms.TabPage();
            this.cbCusCountry = new System.Windows.Forms.ComboBox();
            this.btnLoadCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.clCusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusComName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusPosCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCusFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCusPosCode = new System.Windows.Forms.TextBox();
            this.lblPosCode = new System.Windows.Forms.Label();
            this.txtCusRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtCusCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCusTitle = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusComName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCusTitle = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.tOrder = new System.Windows.Forms.TabPage();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrderShiperID = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbOrderShipCountry = new System.Windows.Forms.ComboBox();
            this.mtbOrderFreight = new System.Windows.Forms.MaskedTextBox();
            this.dtpRequireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.clOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderCusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderShipperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipPosCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.txtOrderShipPosCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderShipRegion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderShipCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderShipAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderShipName = new System.Windows.Forms.TextBox();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblRequireDate = new System.Windows.Forms.Label();
            this.txtOrderEmpID = new System.Windows.Forms.TextBox();
            this.txtOrderCusID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderEmpID = new System.Windows.Forms.Label();
            this.lblOrderCusID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.tProduct = new System.Windows.Forms.TabPage();
            this.cbCaterogyID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.btnLoadProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.clProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProDiscontinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProUnitPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProSupplierID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tEmployee = new System.Windows.Forms.TabPage();
            this.cbEmpCountry = new System.Windows.Forms.ComboBox();
            this.mtbEmpPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpEmpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.clEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpTitleofCourtesy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpPosCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.txtEmpManagerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmpPosCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpRegion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmpTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEmpTitle = new System.Windows.Forms.TextBox();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.txtEmployID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tSuppliers = new System.Windows.Forms.TabPage();
            this.cbSupCountry = new System.Windows.Forms.ComboBox();
            this.btnLoadSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.clSupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSupFax = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSupPhone = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSupPosCode = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSupRegion = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSupCity = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSupAdd = new System.Windows.Forms.TextBox();
            this.txtSupContactName = new System.Windows.Forms.TextBox();
            this.txtSupCompanyName = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tCategories = new System.Windows.Forms.TabPage();
            this.btnLoadCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.clCateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCateDescription = new System.Windows.Forms.TextBox();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tShippers = new System.Windows.Forms.TabPage();
            this.btnLoadShipper = new System.Windows.Forms.Button();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.btnDeleteShipper = new System.Windows.Forms.Button();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.dgvShipper = new System.Windows.Forms.DataGridView();
            this.clShipperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipperCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clShipperPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtShipperPhone = new System.Windows.Forms.TextBox();
            this.txtShipperCompany = new System.Windows.Forms.TextBox();
            this.txtShipperID = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.tSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tShippers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tCustomer);
            this.tabControl.Controls.Add(this.tOrder);
            this.tabControl.Controls.Add(this.tProduct);
            this.tabControl.Controls.Add(this.tEmployee);
            this.tabControl.Controls.Add(this.tSuppliers);
            this.tabControl.Controls.Add(this.tCategories);
            this.tabControl.Controls.Add(this.tShippers);
            this.tabControl.Location = new System.Drawing.Point(4, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1043, 511);
            this.tabControl.TabIndex = 0;
            // 
            // tCustomer
            // 
            this.tCustomer.Controls.Add(this.textBox1);
            this.tCustomer.Controls.Add(this.btnSearchCustomer);
            this.tCustomer.Controls.Add(this.cbCusCountry);
            this.tCustomer.Controls.Add(this.btnLoadCustomer);
            this.tCustomer.Controls.Add(this.btnUpdateCustomer);
            this.tCustomer.Controls.Add(this.btnDeleteCustomer);
            this.tCustomer.Controls.Add(this.btnAddCustomer);
            this.tCustomer.Controls.Add(this.dgvCustomer);
            this.tCustomer.Controls.Add(this.txtCusFax);
            this.tCustomer.Controls.Add(this.lblFax);
            this.tCustomer.Controls.Add(this.txtCusPhone);
            this.tCustomer.Controls.Add(this.lblPhone);
            this.tCustomer.Controls.Add(this.lblCountry);
            this.tCustomer.Controls.Add(this.txtCusPosCode);
            this.tCustomer.Controls.Add(this.lblPosCode);
            this.tCustomer.Controls.Add(this.txtCusRegion);
            this.tCustomer.Controls.Add(this.lblRegion);
            this.tCustomer.Controls.Add(this.txtCusCity);
            this.tCustomer.Controls.Add(this.lblCity);
            this.tCustomer.Controls.Add(this.txtCusAddress);
            this.tCustomer.Controls.Add(this.lblAddress);
            this.tCustomer.Controls.Add(this.txtCusTitle);
            this.tCustomer.Controls.Add(this.txtCusName);
            this.tCustomer.Controls.Add(this.txtCusComName);
            this.tCustomer.Controls.Add(this.txtCustomerID);
            this.tCustomer.Controls.Add(this.lblCusTitle);
            this.tCustomer.Controls.Add(this.lblCusName);
            this.tCustomer.Controls.Add(this.lblComName);
            this.tCustomer.Controls.Add(this.lblCusID);
            this.tCustomer.Location = new System.Drawing.Point(4, 22);
            this.tCustomer.Name = "tCustomer";
            this.tCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tCustomer.Size = new System.Drawing.Size(1035, 485);
            this.tCustomer.TabIndex = 0;
            this.tCustomer.Text = "Customer";
            this.tCustomer.UseVisualStyleBackColor = true;
            // 
            // cbCusCountry
            // 
            this.cbCusCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCusCountry.FormattingEnabled = true;
            this.cbCusCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "Lao",
            "Indonesia",
            "Thai Lan",
            "Malaysia",
            "Singapore",
            "Japan",
            "Korea",
            "USA",
            "China"});
            this.cbCusCountry.Location = new System.Drawing.Point(98, 285);
            this.cbCusCountry.Name = "cbCusCountry";
            this.cbCusCountry.Size = new System.Drawing.Size(181, 21);
            this.cbCusCountry.TabIndex = 86;
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.Location = new System.Drawing.Point(710, 215);
            this.btnLoadCustomer.Name = "btnLoadCustomer";
            this.btnLoadCustomer.Size = new System.Drawing.Size(119, 23);
            this.btnLoadCustomer.TabIndex = 27;
            this.btnLoadCustomer.Text = "Load Customer";
            this.btnLoadCustomer.UseVisualStyleBackColor = true;
            this.btnLoadCustomer.Click += new System.EventHandler(this.btnLoadCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateCustomer.TabIndex = 26;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteCustomer.TabIndex = 25;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(565, 185);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(115, 23);
            this.btnAddCustomer.TabIndex = 24;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCusID,
            this.clCusComName,
            this.clCusName,
            this.clCusContactTitle,
            this.clCusAddress,
            this.clCusCity,
            this.clCusRegion,
            this.clCusPosCode,
            this.clCusCountry,
            this.clCusPhone,
            this.clCusFax});
            this.dgvCustomer.Location = new System.Drawing.Point(295, 40);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(620, 137);
            this.dgvCustomer.TabIndex = 23;
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            // 
            // clCusID
            // 
            this.clCusID.HeaderText = "ID";
            this.clCusID.Name = "clCusID";
            this.clCusID.ReadOnly = true;
            // 
            // clCusComName
            // 
            this.clCusComName.HeaderText = "Company Name";
            this.clCusComName.Name = "clCusComName";
            this.clCusComName.ReadOnly = true;
            // 
            // clCusName
            // 
            this.clCusName.HeaderText = "Customer Name";
            this.clCusName.Name = "clCusName";
            this.clCusName.ReadOnly = true;
            // 
            // clCusContactTitle
            // 
            this.clCusContactTitle.HeaderText = "Contact Title";
            this.clCusContactTitle.Name = "clCusContactTitle";
            this.clCusContactTitle.ReadOnly = true;
            // 
            // clCusAddress
            // 
            this.clCusAddress.HeaderText = "Address";
            this.clCusAddress.Name = "clCusAddress";
            this.clCusAddress.ReadOnly = true;
            // 
            // clCusCity
            // 
            this.clCusCity.HeaderText = "City";
            this.clCusCity.Name = "clCusCity";
            this.clCusCity.ReadOnly = true;
            // 
            // clCusRegion
            // 
            this.clCusRegion.HeaderText = "Region";
            this.clCusRegion.Name = "clCusRegion";
            this.clCusRegion.ReadOnly = true;
            // 
            // clCusPosCode
            // 
            this.clCusPosCode.HeaderText = "Postal Code";
            this.clCusPosCode.Name = "clCusPosCode";
            this.clCusPosCode.ReadOnly = true;
            // 
            // clCusCountry
            // 
            this.clCusCountry.HeaderText = "Country";
            this.clCusCountry.Name = "clCusCountry";
            this.clCusCountry.ReadOnly = true;
            // 
            // clCusPhone
            // 
            this.clCusPhone.HeaderText = "Phone";
            this.clCusPhone.Name = "clCusPhone";
            this.clCusPhone.ReadOnly = true;
            // 
            // clCusFax
            // 
            this.clCusFax.HeaderText = "Fax";
            this.clCusFax.Name = "clCusFax";
            this.clCusFax.ReadOnly = true;
            // 
            // txtCusFax
            // 
            this.txtCusFax.Location = new System.Drawing.Point(94, 376);
            this.txtCusFax.Name = "txtCusFax";
            this.txtCusFax.Size = new System.Drawing.Size(181, 20);
            this.txtCusFax.TabIndex = 22;
            this.txtCusFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusFax_KeyDown);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(6, 379);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 21;
            this.lblFax.Text = "Fax";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(98, 320);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(181, 20);
            this.txtCusPhone.TabIndex = 20;
            this.txtCusPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusPhone_KeyDown);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 325);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(10, 290);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 17;
            this.lblCountry.Text = "Country";
            // 
            // txtCusPosCode
            // 
            this.txtCusPosCode.Location = new System.Drawing.Point(98, 250);
            this.txtCusPosCode.Name = "txtCusPosCode";
            this.txtCusPosCode.Size = new System.Drawing.Size(181, 20);
            this.txtCusPosCode.TabIndex = 16;
            this.txtCusPosCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusPosCode_KeyDown);
            // 
            // lblPosCode
            // 
            this.lblPosCode.AutoSize = true;
            this.lblPosCode.Location = new System.Drawing.Point(10, 255);
            this.lblPosCode.Name = "lblPosCode";
            this.lblPosCode.Size = new System.Drawing.Size(64, 13);
            this.lblPosCode.TabIndex = 15;
            this.lblPosCode.Text = "Postal Code";
            // 
            // txtCusRegion
            // 
            this.txtCusRegion.Location = new System.Drawing.Point(98, 215);
            this.txtCusRegion.Name = "txtCusRegion";
            this.txtCusRegion.Size = new System.Drawing.Size(181, 20);
            this.txtCusRegion.TabIndex = 14;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(10, 220);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 13;
            this.lblRegion.Text = "Region";
            // 
            // txtCusCity
            // 
            this.txtCusCity.Location = new System.Drawing.Point(98, 180);
            this.txtCusCity.Name = "txtCusCity";
            this.txtCusCity.Size = new System.Drawing.Size(181, 20);
            this.txtCusCity.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 185);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(98, 145);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(181, 20);
            this.txtCusAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // txtCusTitle
            // 
            this.txtCusTitle.Location = new System.Drawing.Point(98, 110);
            this.txtCusTitle.Name = "txtCusTitle";
            this.txtCusTitle.Size = new System.Drawing.Size(181, 20);
            this.txtCusTitle.TabIndex = 8;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(98, 75);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(181, 20);
            this.txtCusName.TabIndex = 7;
            // 
            // txtCusComName
            // 
            this.txtCusComName.Location = new System.Drawing.Point(98, 40);
            this.txtCusComName.Name = "txtCusComName";
            this.txtCusComName.Size = new System.Drawing.Size(181, 20);
            this.txtCusComName.TabIndex = 6;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(98, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerID.TabIndex = 5;
            // 
            // lblCusTitle
            // 
            this.lblCusTitle.AutoSize = true;
            this.lblCusTitle.Location = new System.Drawing.Point(10, 115);
            this.lblCusTitle.Name = "lblCusTitle";
            this.lblCusTitle.Size = new System.Drawing.Size(67, 13);
            this.lblCusTitle.TabIndex = 4;
            this.lblCusTitle.Text = "Contact Title";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(10, 80);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(82, 13);
            this.lblCusName.TabIndex = 3;
            this.lblCusName.Text = "Customer Name";
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Location = new System.Drawing.Point(10, 45);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(82, 13);
            this.lblComName.TabIndex = 2;
            this.lblComName.Text = "Company Name";
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(10, 10);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(18, 13);
            this.lblCusID.TabIndex = 1;
            this.lblCusID.Text = "ID";
            // 
            // tOrder
            // 
            this.tOrder.Controls.Add(this.btnUpdateDetail);
            this.tOrder.Controls.Add(this.btnDeleteDetail);
            this.tOrder.Controls.Add(this.btnAddDetail);
            this.tOrder.Controls.Add(this.panel1);
            this.tOrder.Controls.Add(this.dataGridView1);
            this.tOrder.Controls.Add(this.txtOrderShiperID);
            this.tOrder.Controls.Add(this.label35);
            this.tOrder.Controls.Add(this.cbOrderShipCountry);
            this.tOrder.Controls.Add(this.mtbOrderFreight);
            this.tOrder.Controls.Add(this.dtpRequireDate);
            this.tOrder.Controls.Add(this.dtpShippedDate);
            this.tOrder.Controls.Add(this.dtpOrderDate);
            this.tOrder.Controls.Add(this.btnLoadOrder);
            this.tOrder.Controls.Add(this.btnUpdateOrder);
            this.tOrder.Controls.Add(this.btnDeleteOrder);
            this.tOrder.Controls.Add(this.btnAddOrder);
            this.tOrder.Controls.Add(this.dgvOrder);
            this.tOrder.Controls.Add(this.label5);
            this.tOrder.Controls.Add(this.lblShippedDate);
            this.tOrder.Controls.Add(this.txtOrderShipPosCode);
            this.tOrder.Controls.Add(this.label1);
            this.tOrder.Controls.Add(this.txtOrderShipRegion);
            this.tOrder.Controls.Add(this.label2);
            this.tOrder.Controls.Add(this.txtOrderShipCity);
            this.tOrder.Controls.Add(this.label3);
            this.tOrder.Controls.Add(this.txtOrderShipAddress);
            this.tOrder.Controls.Add(this.label4);
            this.tOrder.Controls.Add(this.txtOrderShipName);
            this.tOrder.Controls.Add(this.lblShipName);
            this.tOrder.Controls.Add(this.lblFreight);
            this.tOrder.Controls.Add(this.lblRequireDate);
            this.tOrder.Controls.Add(this.txtOrderEmpID);
            this.tOrder.Controls.Add(this.txtOrderCusID);
            this.tOrder.Controls.Add(this.txtOrderID);
            this.tOrder.Controls.Add(this.lblOrderDate);
            this.tOrder.Controls.Add(this.lblOrderEmpID);
            this.tOrder.Controls.Add(this.lblOrderCusID);
            this.tOrder.Controls.Add(this.lblOrderID);
            this.tOrder.Location = new System.Drawing.Point(4, 22);
            this.tOrder.Name = "tOrder";
            this.tOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tOrder.Size = new System.Drawing.Size(1035, 485);
            this.tOrder.TabIndex = 1;
            this.tOrder.Text = "Order";
            this.tOrder.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Location = new System.Drawing.Point(885, 430);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateDetail.TabIndex = 93;
            this.btnUpdateDetail.Text = "Update Detail";
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(885, 460);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteDetail.TabIndex = 92;
            this.btnDeleteDetail.Text = "Delete Detail";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(885, 400);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(115, 23);
            this.btnAddDetail.TabIndex = 91;
            this.btnAddDetail.Text = "Add Detail";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Location = new System.Drawing.Point(296, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 60);
            this.panel1.TabIndex = 90;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(370, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 20);
            this.textBox5.TabIndex = 100;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(282, 35);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(49, 13);
            this.label44.TabIndex = 99;
            this.label44.Text = "Discount";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(370, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 20);
            this.textBox4.TabIndex = 98;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(282, 9);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(46, 13);
            this.label43.TabIndex = 97;
            this.label43.Text = "Quantity";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 96;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 13);
            this.label42.TabIndex = 95;
            this.label42.Text = "Unit Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 94;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 9);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(58, 13);
            this.label41.TabIndex = 93;
            this.label41.Text = "Product ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView1.Location = new System.Drawing.Point(295, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(702, 137);
            this.dataGridView1.TabIndex = 89;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Order ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Require Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Shipped Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Shipper ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Freight";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Ship Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Ship Address";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Ship City";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Ship Region";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Ship Postal Code";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Ship Country";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // txtOrderShiperID
            // 
            this.txtOrderShiperID.Location = new System.Drawing.Point(98, 215);
            this.txtOrderShiperID.Name = "txtOrderShiperID";
            this.txtOrderShiperID.Size = new System.Drawing.Size(181, 20);
            this.txtOrderShiperID.TabIndex = 88;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(10, 220);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 13);
            this.label35.TabIndex = 87;
            this.label35.Text = "Shipper ID";
            // 
            // cbOrderShipCountry
            // 
            this.cbOrderShipCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderShipCountry.FormattingEnabled = true;
            this.cbOrderShipCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "Lao",
            "Indonesia",
            "Thai Lan",
            "Malaysia",
            "Singapore",
            "Japan",
            "Korea",
            "USA",
            "China"});
            this.cbOrderShipCountry.Location = new System.Drawing.Point(98, 460);
            this.cbOrderShipCountry.Name = "cbOrderShipCountry";
            this.cbOrderShipCountry.Size = new System.Drawing.Size(181, 21);
            this.cbOrderShipCountry.TabIndex = 86;
            // 
            // mtbOrderFreight
            // 
            this.mtbOrderFreight.Location = new System.Drawing.Point(98, 250);
            this.mtbOrderFreight.Mask = "999999";
            this.mtbOrderFreight.Name = "mtbOrderFreight";
            this.mtbOrderFreight.Size = new System.Drawing.Size(181, 20);
            this.mtbOrderFreight.TabIndex = 57;
            // 
            // dtpRequireDate
            // 
            this.dtpRequireDate.Location = new System.Drawing.Point(98, 145);
            this.dtpRequireDate.Name = "dtpRequireDate";
            this.dtpRequireDate.Size = new System.Drawing.Size(181, 20);
            this.dtpRequireDate.TabIndex = 56;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(98, 180);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(181, 20);
            this.dtpShippedDate.TabIndex = 55;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(98, 110);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(181, 20);
            this.dtpOrderDate.TabIndex = 54;
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Location = new System.Drawing.Point(710, 215);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(119, 23);
            this.btnLoadOrder.TabIndex = 53;
            this.btnLoadOrder.Text = "Load Order";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateOrder.TabIndex = 52;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteOrder.TabIndex = 51;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(565, 185);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(115, 23);
            this.btnAddOrder.TabIndex = 50;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrderID,
            this.clOrderCusID,
            this.clOrderEmpID,
            this.clOrderDate,
            this.clReqDate,
            this.clShippedDate,
            this.clOrderShipperID,
            this.clFreight,
            this.clShipName,
            this.clShipAddress,
            this.clShipCity,
            this.clShipRegion,
            this.clShipPosCode,
            this.clShipCountry});
            this.dgvOrder.Location = new System.Drawing.Point(295, 40);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(702, 137);
            this.dgvOrder.TabIndex = 49;
            this.dgvOrder.SelectionChanged += new System.EventHandler(this.dgvOrder_SelectionChanged);
            // 
            // clOrderID
            // 
            this.clOrderID.HeaderText = "Order ID";
            this.clOrderID.Name = "clOrderID";
            this.clOrderID.ReadOnly = true;
            // 
            // clOrderCusID
            // 
            this.clOrderCusID.HeaderText = "Customer ID";
            this.clOrderCusID.Name = "clOrderCusID";
            this.clOrderCusID.ReadOnly = true;
            // 
            // clOrderEmpID
            // 
            this.clOrderEmpID.HeaderText = "Employee ID";
            this.clOrderEmpID.Name = "clOrderEmpID";
            this.clOrderEmpID.ReadOnly = true;
            // 
            // clOrderDate
            // 
            this.clOrderDate.HeaderText = "Order Date";
            this.clOrderDate.Name = "clOrderDate";
            this.clOrderDate.ReadOnly = true;
            // 
            // clReqDate
            // 
            this.clReqDate.HeaderText = "Require Date";
            this.clReqDate.Name = "clReqDate";
            this.clReqDate.ReadOnly = true;
            // 
            // clShippedDate
            // 
            this.clShippedDate.HeaderText = "Shipped Date";
            this.clShippedDate.Name = "clShippedDate";
            this.clShippedDate.ReadOnly = true;
            // 
            // clOrderShipperID
            // 
            this.clOrderShipperID.HeaderText = "Shipper ID";
            this.clOrderShipperID.Name = "clOrderShipperID";
            this.clOrderShipperID.ReadOnly = true;
            // 
            // clFreight
            // 
            this.clFreight.HeaderText = "Freight";
            this.clFreight.Name = "clFreight";
            this.clFreight.ReadOnly = true;
            // 
            // clShipName
            // 
            this.clShipName.HeaderText = "Ship Name";
            this.clShipName.Name = "clShipName";
            this.clShipName.ReadOnly = true;
            // 
            // clShipAddress
            // 
            this.clShipAddress.HeaderText = "Ship Address";
            this.clShipAddress.Name = "clShipAddress";
            this.clShipAddress.ReadOnly = true;
            // 
            // clShipCity
            // 
            this.clShipCity.HeaderText = "Ship City";
            this.clShipCity.Name = "clShipCity";
            this.clShipCity.ReadOnly = true;
            // 
            // clShipRegion
            // 
            this.clShipRegion.HeaderText = "Ship Region";
            this.clShipRegion.Name = "clShipRegion";
            this.clShipRegion.ReadOnly = true;
            // 
            // clShipPosCode
            // 
            this.clShipPosCode.HeaderText = "Ship Postal Code";
            this.clShipPosCode.Name = "clShipPosCode";
            this.clShipPosCode.ReadOnly = true;
            // 
            // clShipCountry
            // 
            this.clShipCountry.HeaderText = "Ship Country";
            this.clShipCountry.Name = "clShipCountry";
            this.clShipCountry.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ship Country";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(10, 185);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(72, 13);
            this.lblShippedDate.TabIndex = 45;
            this.lblShippedDate.Text = "Shipped Date";
            // 
            // txtOrderShipPosCode
            // 
            this.txtOrderShipPosCode.Location = new System.Drawing.Point(98, 425);
            this.txtOrderShipPosCode.Name = "txtOrderShipPosCode";
            this.txtOrderShipPosCode.Size = new System.Drawing.Size(181, 20);
            this.txtOrderShipPosCode.TabIndex = 44;
            this.txtOrderShipPosCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShipPosCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ship Postal Code";
            // 
            // txtOrderShipRegion
            // 
            this.txtOrderShipRegion.Location = new System.Drawing.Point(98, 390);
            this.txtOrderShipRegion.Name = "txtOrderShipRegion";
            this.txtOrderShipRegion.Size = new System.Drawing.Size(181, 20);
            this.txtOrderShipRegion.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ship Region";
            // 
            // txtOrderShipCity
            // 
            this.txtOrderShipCity.Location = new System.Drawing.Point(98, 355);
            this.txtOrderShipCity.Name = "txtOrderShipCity";
            this.txtOrderShipCity.Size = new System.Drawing.Size(181, 20);
            this.txtOrderShipCity.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ship City";
            // 
            // txtOrderShipAddress
            // 
            this.txtOrderShipAddress.Location = new System.Drawing.Point(98, 320);
            this.txtOrderShipAddress.Name = "txtOrderShipAddress";
            this.txtOrderShipAddress.Size = new System.Drawing.Size(181, 20);
            this.txtOrderShipAddress.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ship Address";
            // 
            // txtOrderShipName
            // 
            this.txtOrderShipName.Location = new System.Drawing.Point(98, 285);
            this.txtOrderShipName.Name = "txtOrderShipName";
            this.txtOrderShipName.Size = new System.Drawing.Size(181, 20);
            this.txtOrderShipName.TabIndex = 36;
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(10, 290);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(59, 13);
            this.lblShipName.TabIndex = 35;
            this.lblShipName.Text = "Ship Name";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(10, 255);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(39, 13);
            this.lblFreight.TabIndex = 33;
            this.lblFreight.Text = "Freight";
            // 
            // lblRequireDate
            // 
            this.lblRequireDate.AutoSize = true;
            this.lblRequireDate.Location = new System.Drawing.Point(10, 150);
            this.lblRequireDate.Name = "lblRequireDate";
            this.lblRequireDate.Size = new System.Drawing.Size(70, 13);
            this.lblRequireDate.TabIndex = 31;
            this.lblRequireDate.Text = "Require Date";
            // 
            // txtOrderEmpID
            // 
            this.txtOrderEmpID.Location = new System.Drawing.Point(98, 75);
            this.txtOrderEmpID.Name = "txtOrderEmpID";
            this.txtOrderEmpID.Size = new System.Drawing.Size(181, 20);
            this.txtOrderEmpID.TabIndex = 29;
            this.txtOrderEmpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderEmpID_KeyDown);
            // 
            // txtOrderCusID
            // 
            this.txtOrderCusID.Location = new System.Drawing.Point(98, 40);
            this.txtOrderCusID.Name = "txtOrderCusID";
            this.txtOrderCusID.Size = new System.Drawing.Size(181, 20);
            this.txtOrderCusID.TabIndex = 28;
            this.txtOrderCusID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderCusID_KeyDown);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(98, 5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(181, 20);
            this.txtOrderID.TabIndex = 27;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(10, 110);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 26;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderEmpID
            // 
            this.lblOrderEmpID.AutoSize = true;
            this.lblOrderEmpID.Location = new System.Drawing.Point(10, 80);
            this.lblOrderEmpID.Name = "lblOrderEmpID";
            this.lblOrderEmpID.Size = new System.Drawing.Size(67, 13);
            this.lblOrderEmpID.TabIndex = 25;
            this.lblOrderEmpID.Text = "Employee ID";
            // 
            // lblOrderCusID
            // 
            this.lblOrderCusID.AutoSize = true;
            this.lblOrderCusID.Location = new System.Drawing.Point(10, 45);
            this.lblOrderCusID.Name = "lblOrderCusID";
            this.lblOrderCusID.Size = new System.Drawing.Size(65, 13);
            this.lblOrderCusID.TabIndex = 24;
            this.lblOrderCusID.Text = "Customer ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(10, 10);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(18, 13);
            this.lblOrderID.TabIndex = 23;
            this.lblOrderID.Text = "ID";
            // 
            // tProduct
            // 
            this.tProduct.Controls.Add(this.cbCaterogyID);
            this.tProduct.Controls.Add(this.groupBox1);
            this.tProduct.Controls.Add(this.btnLoadProduct);
            this.tProduct.Controls.Add(this.btnUpdateProduct);
            this.tProduct.Controls.Add(this.btnDeleteProduct);
            this.tProduct.Controls.Add(this.btnAddProduct);
            this.tProduct.Controls.Add(this.dgvProduct);
            this.tProduct.Controls.Add(this.label11);
            this.tProduct.Controls.Add(this.txtProUnitPrice);
            this.tProduct.Controls.Add(this.label12);
            this.tProduct.Controls.Add(this.txtProSupplierID);
            this.tProduct.Controls.Add(this.txtProductName);
            this.tProduct.Controls.Add(this.txtProductID);
            this.tProduct.Controls.Add(this.label13);
            this.tProduct.Controls.Add(this.label14);
            this.tProduct.Controls.Add(this.label15);
            this.tProduct.Controls.Add(this.label16);
            this.tProduct.Location = new System.Drawing.Point(4, 22);
            this.tProduct.Name = "tProduct";
            this.tProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tProduct.Size = new System.Drawing.Size(1035, 485);
            this.tProduct.TabIndex = 2;
            this.tProduct.Text = "Product";
            this.tProduct.UseVisualStyleBackColor = true;
            // 
            // cbCaterogyID
            // 
            this.cbCaterogyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaterogyID.FormattingEnabled = true;
            this.cbCaterogyID.Location = new System.Drawing.Point(98, 110);
            this.cbCaterogyID.Name = "cbCaterogyID";
            this.cbCaterogyID.Size = new System.Drawing.Size(181, 21);
            this.cbCaterogyID.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNo);
            this.groupBox1.Controls.Add(this.radYes);
            this.groupBox1.Location = new System.Drawing.Point(98, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 30);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(110, 9);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 35;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(39, 9);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 34;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // btnLoadProduct
            // 
            this.btnLoadProduct.Location = new System.Drawing.Point(710, 215);
            this.btnLoadProduct.Name = "btnLoadProduct";
            this.btnLoadProduct.Size = new System.Drawing.Size(119, 23);
            this.btnLoadProduct.TabIndex = 40;
            this.btnLoadProduct.Text = "Load Product";
            this.btnLoadProduct.UseVisualStyleBackColor = true;
            this.btnLoadProduct.Click += new System.EventHandler(this.btnLoadProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateProduct.TabIndex = 39;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteProduct.TabIndex = 38;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(565, 185);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 23);
            this.btnAddProduct.TabIndex = 37;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProductID,
            this.clProName,
            this.clProSupplierID,
            this.clProCategoryID,
            this.clProUnitPrice,
            this.clProDiscontinued});
            this.dgvProduct.Location = new System.Drawing.Point(295, 40);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(620, 137);
            this.dgvProduct.TabIndex = 36;
            // 
            // clProductID
            // 
            this.clProductID.HeaderText = "Product ID";
            this.clProductID.Name = "clProductID";
            this.clProductID.ReadOnly = true;
            // 
            // clProName
            // 
            this.clProName.HeaderText = "Product Name";
            this.clProName.Name = "clProName";
            this.clProName.ReadOnly = true;
            // 
            // clProSupplierID
            // 
            this.clProSupplierID.HeaderText = "Supplier ID";
            this.clProSupplierID.Name = "clProSupplierID";
            this.clProSupplierID.ReadOnly = true;
            // 
            // clProCategoryID
            // 
            this.clProCategoryID.HeaderText = "Category ID";
            this.clProCategoryID.Name = "clProCategoryID";
            this.clProCategoryID.ReadOnly = true;
            // 
            // clProUnitPrice
            // 
            this.clProUnitPrice.HeaderText = "Unit Price";
            this.clProUnitPrice.Name = "clProUnitPrice";
            this.clProUnitPrice.ReadOnly = true;
            // 
            // clProDiscontinued
            // 
            this.clProDiscontinued.HeaderText = "Discontinued";
            this.clProDiscontinued.Name = "clProDiscontinued";
            this.clProDiscontinued.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Discontinued";
            // 
            // txtProUnitPrice
            // 
            this.txtProUnitPrice.Location = new System.Drawing.Point(98, 145);
            this.txtProUnitPrice.Name = "txtProUnitPrice";
            this.txtProUnitPrice.Size = new System.Drawing.Size(181, 20);
            this.txtProUnitPrice.TabIndex = 32;
            this.txtProUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitPrice_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Unit Price";
            // 
            // txtProSupplierID
            // 
            this.txtProSupplierID.Location = new System.Drawing.Point(98, 75);
            this.txtProSupplierID.Name = "txtProSupplierID";
            this.txtProSupplierID.Size = new System.Drawing.Size(181, 20);
            this.txtProSupplierID.TabIndex = 29;
            this.txtProSupplierID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProSupplierID_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(98, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(181, 20);
            this.txtProductName.TabIndex = 28;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(98, 5);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(181, 20);
            this.txtProductID.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Category ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Supplier ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Product Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Product ID";
            // 
            // tEmployee
            // 
            this.tEmployee.Controls.Add(this.cbEmpCountry);
            this.tEmployee.Controls.Add(this.mtbEmpPhone);
            this.tEmployee.Controls.Add(this.dtpEmpHireDate);
            this.tEmployee.Controls.Add(this.dtpEmpBirthdate);
            this.tEmployee.Controls.Add(this.btnLoadEmp);
            this.tEmployee.Controls.Add(this.btnUpdateEmp);
            this.tEmployee.Controls.Add(this.btnDeleteEmp);
            this.tEmployee.Controls.Add(this.btnAddEmp);
            this.tEmployee.Controls.Add(this.dgvEmp);
            this.tEmployee.Controls.Add(this.label25);
            this.tEmployee.Controls.Add(this.txtEmpManagerID);
            this.tEmployee.Controls.Add(this.label6);
            this.tEmployee.Controls.Add(this.label7);
            this.tEmployee.Controls.Add(this.label8);
            this.tEmployee.Controls.Add(this.label9);
            this.tEmployee.Controls.Add(this.txtEmpPosCode);
            this.tEmployee.Controls.Add(this.label10);
            this.tEmployee.Controls.Add(this.txtEmpRegion);
            this.tEmployee.Controls.Add(this.label17);
            this.tEmployee.Controls.Add(this.txtEmpCity);
            this.tEmployee.Controls.Add(this.label18);
            this.tEmployee.Controls.Add(this.txtEmpAddress);
            this.tEmployee.Controls.Add(this.label19);
            this.tEmployee.Controls.Add(this.txtEmpTitleOfCourtesy);
            this.tEmployee.Controls.Add(this.label20);
            this.tEmployee.Controls.Add(this.txtEmpTitle);
            this.tEmployee.Controls.Add(this.txtEmpFirstName);
            this.tEmployee.Controls.Add(this.txtEmpLastName);
            this.tEmployee.Controls.Add(this.txtEmployID);
            this.tEmployee.Controls.Add(this.label21);
            this.tEmployee.Controls.Add(this.label22);
            this.tEmployee.Controls.Add(this.label23);
            this.tEmployee.Controls.Add(this.label24);
            this.tEmployee.Location = new System.Drawing.Point(4, 22);
            this.tEmployee.Name = "tEmployee";
            this.tEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tEmployee.Size = new System.Drawing.Size(1035, 485);
            this.tEmployee.TabIndex = 3;
            this.tEmployee.Text = "Employee";
            this.tEmployee.UseVisualStyleBackColor = true;
            // 
            // cbEmpCountry
            // 
            this.cbEmpCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpCountry.FormattingEnabled = true;
            this.cbEmpCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "Lao",
            "Indonesia",
            "Thai Lan",
            "Malaysia",
            "Singapore",
            "Japan",
            "Korea",
            "USA",
            "China"});
            this.cbEmpCountry.Location = new System.Drawing.Point(98, 390);
            this.cbEmpCountry.Name = "cbEmpCountry";
            this.cbEmpCountry.Size = new System.Drawing.Size(181, 21);
            this.cbEmpCountry.TabIndex = 85;
            // 
            // mtbEmpPhone
            // 
            this.mtbEmpPhone.Location = new System.Drawing.Point(98, 425);
            this.mtbEmpPhone.Mask = "(9000) 000-0000";
            this.mtbEmpPhone.Name = "mtbEmpPhone";
            this.mtbEmpPhone.Size = new System.Drawing.Size(181, 20);
            this.mtbEmpPhone.TabIndex = 84;
            // 
            // dtpEmpHireDate
            // 
            this.dtpEmpHireDate.Location = new System.Drawing.Point(98, 215);
            this.dtpEmpHireDate.Name = "dtpEmpHireDate";
            this.dtpEmpHireDate.Size = new System.Drawing.Size(181, 20);
            this.dtpEmpHireDate.TabIndex = 83;
            // 
            // dtpEmpBirthdate
            // 
            this.dtpEmpBirthdate.Location = new System.Drawing.Point(98, 180);
            this.dtpEmpBirthdate.Name = "dtpEmpBirthdate";
            this.dtpEmpBirthdate.Size = new System.Drawing.Size(181, 20);
            this.dtpEmpBirthdate.TabIndex = 82;
            // 
            // btnLoadEmp
            // 
            this.btnLoadEmp.Location = new System.Drawing.Point(710, 215);
            this.btnLoadEmp.Name = "btnLoadEmp";
            this.btnLoadEmp.Size = new System.Drawing.Size(119, 23);
            this.btnLoadEmp.TabIndex = 81;
            this.btnLoadEmp.Text = "Load Employee";
            this.btnLoadEmp.UseVisualStyleBackColor = true;
            this.btnLoadEmp.Click += new System.EventHandler(this.btnLoadEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateEmp.TabIndex = 80;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteEmp.TabIndex = 79;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(565, 185);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(115, 23);
            this.btnAddEmp.TabIndex = 78;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clEmployeeID,
            this.clEmpLastName,
            this.clEmpFirstName,
            this.clEmpTitle,
            this.clEmpTitleofCourtesy,
            this.clEmpBirthdate,
            this.clEmpHireDate,
            this.clEmpAddress,
            this.clEmpCity,
            this.clEmpRegion,
            this.clEmpPosCode,
            this.clEmpCountry,
            this.clEmpPhone,
            this.clEmpManagerID});
            this.dgvEmp.Location = new System.Drawing.Point(295, 40);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.Size = new System.Drawing.Size(620, 137);
            this.dgvEmp.TabIndex = 77;
            // 
            // clEmployeeID
            // 
            this.clEmployeeID.HeaderText = "Employee ID";
            this.clEmployeeID.Name = "clEmployeeID";
            this.clEmployeeID.ReadOnly = true;
            // 
            // clEmpLastName
            // 
            this.clEmpLastName.HeaderText = "Employee Last Name";
            this.clEmpLastName.Name = "clEmpLastName";
            this.clEmpLastName.ReadOnly = true;
            // 
            // clEmpFirstName
            // 
            this.clEmpFirstName.HeaderText = "Employee Last Name";
            this.clEmpFirstName.Name = "clEmpFirstName";
            this.clEmpFirstName.ReadOnly = true;
            // 
            // clEmpTitle
            // 
            this.clEmpTitle.HeaderText = "Employee Title";
            this.clEmpTitle.Name = "clEmpTitle";
            this.clEmpTitle.ReadOnly = true;
            // 
            // clEmpTitleofCourtesy
            // 
            this.clEmpTitleofCourtesy.HeaderText = "Employee Title of Courtesy";
            this.clEmpTitleofCourtesy.Name = "clEmpTitleofCourtesy";
            this.clEmpTitleofCourtesy.ReadOnly = true;
            // 
            // clEmpBirthdate
            // 
            this.clEmpBirthdate.HeaderText = "Employee Birthdate";
            this.clEmpBirthdate.Name = "clEmpBirthdate";
            this.clEmpBirthdate.ReadOnly = true;
            // 
            // clEmpHireDate
            // 
            this.clEmpHireDate.HeaderText = "Employee Hire Date";
            this.clEmpHireDate.Name = "clEmpHireDate";
            this.clEmpHireDate.ReadOnly = true;
            // 
            // clEmpAddress
            // 
            this.clEmpAddress.HeaderText = "Employee Address";
            this.clEmpAddress.Name = "clEmpAddress";
            this.clEmpAddress.ReadOnly = true;
            // 
            // clEmpCity
            // 
            this.clEmpCity.HeaderText = "Employee City";
            this.clEmpCity.Name = "clEmpCity";
            this.clEmpCity.ReadOnly = true;
            // 
            // clEmpRegion
            // 
            this.clEmpRegion.HeaderText = "Employee Region";
            this.clEmpRegion.Name = "clEmpRegion";
            this.clEmpRegion.ReadOnly = true;
            // 
            // clEmpPosCode
            // 
            this.clEmpPosCode.HeaderText = "Employee Postal Code";
            this.clEmpPosCode.Name = "clEmpPosCode";
            this.clEmpPosCode.ReadOnly = true;
            // 
            // clEmpCountry
            // 
            this.clEmpCountry.HeaderText = "Employee Country";
            this.clEmpCountry.Name = "clEmpCountry";
            this.clEmpCountry.ReadOnly = true;
            // 
            // clEmpPhone
            // 
            this.clEmpPhone.HeaderText = "Employee Phone";
            this.clEmpPhone.Name = "clEmpPhone";
            this.clEmpPhone.ReadOnly = true;
            // 
            // clEmpManagerID
            // 
            this.clEmpManagerID.HeaderText = "Employee Managaer ID";
            this.clEmpManagerID.Name = "clEmpManagerID";
            this.clEmpManagerID.ReadOnly = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 220);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 75;
            this.label25.Text = "Hire date";
            // 
            // txtEmpManagerID
            // 
            this.txtEmpManagerID.Location = new System.Drawing.Point(98, 460);
            this.txtEmpManagerID.Name = "txtEmpManagerID";
            this.txtEmpManagerID.Size = new System.Drawing.Size(181, 20);
            this.txtEmpManagerID.TabIndex = 74;
            this.txtEmpManagerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMgrid_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Manager ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Country";
            // 
            // txtEmpPosCode
            // 
            this.txtEmpPosCode.Location = new System.Drawing.Point(98, 355);
            this.txtEmpPosCode.Name = "txtEmpPosCode";
            this.txtEmpPosCode.Size = new System.Drawing.Size(181, 20);
            this.txtEmpPosCode.TabIndex = 66;
            this.txtEmpPosCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpPosCode_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Postal Code";
            // 
            // txtEmpRegion
            // 
            this.txtEmpRegion.Location = new System.Drawing.Point(98, 320);
            this.txtEmpRegion.Name = "txtEmpRegion";
            this.txtEmpRegion.Size = new System.Drawing.Size(181, 20);
            this.txtEmpRegion.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Region";
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(98, 285);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(181, 20);
            this.txtEmpCity.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "City";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(98, 250);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(181, 20);
            this.txtEmpAddress.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 255);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Address";
            // 
            // txtEmpTitleOfCourtesy
            // 
            this.txtEmpTitleOfCourtesy.Location = new System.Drawing.Point(98, 145);
            this.txtEmpTitleOfCourtesy.Name = "txtEmpTitleOfCourtesy";
            this.txtEmpTitleOfCourtesy.Size = new System.Drawing.Size(181, 20);
            this.txtEmpTitleOfCourtesy.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Title Of Courtesy";
            // 
            // txtEmpTitle
            // 
            this.txtEmpTitle.Location = new System.Drawing.Point(98, 110);
            this.txtEmpTitle.Name = "txtEmpTitle";
            this.txtEmpTitle.Size = new System.Drawing.Size(181, 20);
            this.txtEmpTitle.TabIndex = 56;
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.Location = new System.Drawing.Point(98, 75);
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtEmpFirstName.TabIndex = 55;
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.Location = new System.Drawing.Point(98, 40);
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(181, 20);
            this.txtEmpLastName.TabIndex = 54;
            // 
            // txtEmployID
            // 
            this.txtEmployID.Location = new System.Drawing.Point(98, 5);
            this.txtEmployID.Name = "txtEmployID";
            this.txtEmployID.Size = new System.Drawing.Size(181, 20);
            this.txtEmployID.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Title";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "First Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "Last Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Employee ID";
            // 
            // tSuppliers
            // 
            this.tSuppliers.Controls.Add(this.cbSupCountry);
            this.tSuppliers.Controls.Add(this.btnLoadSupplier);
            this.tSuppliers.Controls.Add(this.btnUpdateSupplier);
            this.tSuppliers.Controls.Add(this.btnDeleteSupplier);
            this.tSuppliers.Controls.Add(this.btnAddSupplier);
            this.tSuppliers.Controls.Add(this.dgvSupplier);
            this.tSuppliers.Controls.Add(this.txtSupFax);
            this.tSuppliers.Controls.Add(this.label27);
            this.tSuppliers.Controls.Add(this.txtSupPhone);
            this.tSuppliers.Controls.Add(this.label29);
            this.tSuppliers.Controls.Add(this.label30);
            this.tSuppliers.Controls.Add(this.txtSupPosCode);
            this.tSuppliers.Controls.Add(this.label31);
            this.tSuppliers.Controls.Add(this.txtSupRegion);
            this.tSuppliers.Controls.Add(this.label32);
            this.tSuppliers.Controls.Add(this.txtSupCity);
            this.tSuppliers.Controls.Add(this.label33);
            this.tSuppliers.Controls.Add(this.txtSupAdd);
            this.tSuppliers.Controls.Add(this.txtSupContactName);
            this.tSuppliers.Controls.Add(this.txtSupCompanyName);
            this.tSuppliers.Controls.Add(this.txtSupID);
            this.tSuppliers.Controls.Add(this.label36);
            this.tSuppliers.Controls.Add(this.label37);
            this.tSuppliers.Controls.Add(this.label38);
            this.tSuppliers.Controls.Add(this.label39);
            this.tSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tSuppliers.Name = "tSuppliers";
            this.tSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tSuppliers.Size = new System.Drawing.Size(1035, 485);
            this.tSuppliers.TabIndex = 4;
            this.tSuppliers.Text = "Suppliers";
            this.tSuppliers.UseVisualStyleBackColor = true;
            // 
            // cbSupCountry
            // 
            this.cbSupCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupCountry.FormattingEnabled = true;
            this.cbSupCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "Lao",
            "Indonesia",
            "Thai Lan",
            "Malaysia",
            "Singapore",
            "Japan",
            "Korea",
            "USA",
            "China"});
            this.cbSupCountry.Location = new System.Drawing.Point(98, 250);
            this.cbSupCountry.Name = "cbSupCountry";
            this.cbSupCountry.Size = new System.Drawing.Size(181, 21);
            this.cbSupCountry.TabIndex = 108;
            // 
            // btnLoadSupplier
            // 
            this.btnLoadSupplier.Location = new System.Drawing.Point(710, 215);
            this.btnLoadSupplier.Name = "btnLoadSupplier";
            this.btnLoadSupplier.Size = new System.Drawing.Size(119, 23);
            this.btnLoadSupplier.TabIndex = 107;
            this.btnLoadSupplier.Text = "Load Supplier";
            this.btnLoadSupplier.UseVisualStyleBackColor = true;
            this.btnLoadSupplier.Click += new System.EventHandler(this.btnLoadSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateSupplier.TabIndex = 106;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteSupplier.TabIndex = 105;
            this.btnDeleteSupplier.Text = "Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(565, 185);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(115, 23);
            this.btnAddSupplier.TabIndex = 104;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSupID,
            this.clSupCompanyName,
            this.clSupContactName,
            this.clSupAddress,
            this.clSupCity,
            this.clSupRegion,
            this.clSupPostalCode,
            this.clSupCountry,
            this.clSupPhone,
            this.clSupFax});
            this.dgvSupplier.Location = new System.Drawing.Point(295, 40);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.Size = new System.Drawing.Size(620, 137);
            this.dgvSupplier.TabIndex = 103;
            // 
            // clSupID
            // 
            this.clSupID.HeaderText = "Supplier ID";
            this.clSupID.Name = "clSupID";
            this.clSupID.ReadOnly = true;
            // 
            // clSupCompanyName
            // 
            this.clSupCompanyName.HeaderText = "Company Name";
            this.clSupCompanyName.Name = "clSupCompanyName";
            this.clSupCompanyName.ReadOnly = true;
            // 
            // clSupContactName
            // 
            this.clSupContactName.HeaderText = "Contact Name";
            this.clSupContactName.Name = "clSupContactName";
            this.clSupContactName.ReadOnly = true;
            // 
            // clSupAddress
            // 
            this.clSupAddress.HeaderText = "Address";
            this.clSupAddress.Name = "clSupAddress";
            this.clSupAddress.ReadOnly = true;
            // 
            // clSupCity
            // 
            this.clSupCity.HeaderText = "City";
            this.clSupCity.Name = "clSupCity";
            this.clSupCity.ReadOnly = true;
            // 
            // clSupRegion
            // 
            this.clSupRegion.HeaderText = "Region";
            this.clSupRegion.Name = "clSupRegion";
            this.clSupRegion.ReadOnly = true;
            // 
            // clSupPostalCode
            // 
            this.clSupPostalCode.HeaderText = "Postal Code";
            this.clSupPostalCode.Name = "clSupPostalCode";
            this.clSupPostalCode.ReadOnly = true;
            // 
            // clSupCountry
            // 
            this.clSupCountry.HeaderText = "Country";
            this.clSupCountry.Name = "clSupCountry";
            this.clSupCountry.ReadOnly = true;
            // 
            // clSupPhone
            // 
            this.clSupPhone.HeaderText = "Phone";
            this.clSupPhone.Name = "clSupPhone";
            this.clSupPhone.ReadOnly = true;
            // 
            // clSupFax
            // 
            this.clSupFax.HeaderText = "Fax";
            this.clSupFax.Name = "clSupFax";
            this.clSupFax.ReadOnly = true;
            // 
            // txtSupFax
            // 
            this.txtSupFax.Location = new System.Drawing.Point(98, 320);
            this.txtSupFax.Name = "txtSupFax";
            this.txtSupFax.Size = new System.Drawing.Size(181, 20);
            this.txtSupFax.TabIndex = 102;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 325);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 13);
            this.label27.TabIndex = 101;
            this.label27.Text = "Fax";
            // 
            // txtSupPhone
            // 
            this.txtSupPhone.Location = new System.Drawing.Point(98, 285);
            this.txtSupPhone.Name = "txtSupPhone";
            this.txtSupPhone.Size = new System.Drawing.Size(181, 20);
            this.txtSupPhone.TabIndex = 98;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 290);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 97;
            this.label29.Text = "Phone";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 255);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 95;
            this.label30.Text = "Country";
            // 
            // txtSupPosCode
            // 
            this.txtSupPosCode.Location = new System.Drawing.Point(98, 215);
            this.txtSupPosCode.Name = "txtSupPosCode";
            this.txtSupPosCode.Size = new System.Drawing.Size(181, 20);
            this.txtSupPosCode.TabIndex = 94;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 220);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 93;
            this.label31.Text = "Postal Code";
            // 
            // txtSupRegion
            // 
            this.txtSupRegion.Location = new System.Drawing.Point(98, 180);
            this.txtSupRegion.Name = "txtSupRegion";
            this.txtSupRegion.Size = new System.Drawing.Size(181, 20);
            this.txtSupRegion.TabIndex = 92;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 185);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 13);
            this.label32.TabIndex = 91;
            this.label32.Text = "Region";
            // 
            // txtSupCity
            // 
            this.txtSupCity.Location = new System.Drawing.Point(98, 145);
            this.txtSupCity.Name = "txtSupCity";
            this.txtSupCity.Size = new System.Drawing.Size(181, 20);
            this.txtSupCity.TabIndex = 90;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 150);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 13);
            this.label33.TabIndex = 89;
            this.label33.Text = "City";
            // 
            // txtSupAdd
            // 
            this.txtSupAdd.Location = new System.Drawing.Point(98, 110);
            this.txtSupAdd.Name = "txtSupAdd";
            this.txtSupAdd.Size = new System.Drawing.Size(181, 20);
            this.txtSupAdd.TabIndex = 84;
            // 
            // txtSupContactName
            // 
            this.txtSupContactName.Location = new System.Drawing.Point(98, 75);
            this.txtSupContactName.Name = "txtSupContactName";
            this.txtSupContactName.Size = new System.Drawing.Size(181, 20);
            this.txtSupContactName.TabIndex = 83;
            // 
            // txtSupCompanyName
            // 
            this.txtSupCompanyName.Location = new System.Drawing.Point(98, 40);
            this.txtSupCompanyName.Name = "txtSupCompanyName";
            this.txtSupCompanyName.Size = new System.Drawing.Size(181, 20);
            this.txtSupCompanyName.TabIndex = 82;
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(98, 5);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(181, 20);
            this.txtSupID.TabIndex = 81;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(10, 115);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 13);
            this.label36.TabIndex = 80;
            this.label36.Text = "Address";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(10, 80);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(75, 13);
            this.label37.TabIndex = 79;
            this.label37.Text = "Contact Name";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(10, 45);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 13);
            this.label38.TabIndex = 78;
            this.label38.Text = "Company Name";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(10, 10);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 13);
            this.label39.TabIndex = 77;
            this.label39.Text = "Supplier ID";
            // 
            // tCategories
            // 
            this.tCategories.Controls.Add(this.btnLoadCategory);
            this.tCategories.Controls.Add(this.btnUpdateCategory);
            this.tCategories.Controls.Add(this.btnDeleteCategory);
            this.tCategories.Controls.Add(this.btnAddCategory);
            this.tCategories.Controls.Add(this.dgvCategory);
            this.tCategories.Controls.Add(this.txtCateDescription);
            this.tCategories.Controls.Add(this.txtCateName);
            this.tCategories.Controls.Add(this.txtCateID);
            this.tCategories.Controls.Add(this.label52);
            this.tCategories.Controls.Add(this.label53);
            this.tCategories.Controls.Add(this.label54);
            this.tCategories.Location = new System.Drawing.Point(4, 22);
            this.tCategories.Name = "tCategories";
            this.tCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tCategories.Size = new System.Drawing.Size(1035, 485);
            this.tCategories.TabIndex = 6;
            this.tCategories.Text = "Categories";
            this.tCategories.UseVisualStyleBackColor = true;
            // 
            // btnLoadCategory
            // 
            this.btnLoadCategory.Location = new System.Drawing.Point(710, 215);
            this.btnLoadCategory.Name = "btnLoadCategory";
            this.btnLoadCategory.Size = new System.Drawing.Size(119, 23);
            this.btnLoadCategory.TabIndex = 88;
            this.btnLoadCategory.Text = "Load Category";
            this.btnLoadCategory.UseVisualStyleBackColor = true;
            this.btnLoadCategory.Click += new System.EventHandler(this.btnLoadCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateCategory.TabIndex = 87;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteCategory.TabIndex = 86;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(565, 185);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(115, 23);
            this.btnAddCategory.TabIndex = 85;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCateID,
            this.clCateName,
            this.clCateDescription});
            this.dgvCategory.Location = new System.Drawing.Point(295, 40);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(620, 137);
            this.dgvCategory.TabIndex = 84;
            // 
            // clCateID
            // 
            this.clCateID.HeaderText = "Category ID";
            this.clCateID.Name = "clCateID";
            this.clCateID.ReadOnly = true;
            // 
            // clCateName
            // 
            this.clCateName.HeaderText = "Caterogy Name";
            this.clCateName.Name = "clCateName";
            this.clCateName.ReadOnly = true;
            // 
            // clCateDescription
            // 
            this.clCateDescription.HeaderText = "Description";
            this.clCateDescription.Name = "clCateDescription";
            this.clCateDescription.ReadOnly = true;
            // 
            // txtCateDescription
            // 
            this.txtCateDescription.Location = new System.Drawing.Point(98, 75);
            this.txtCateDescription.Name = "txtCateDescription";
            this.txtCateDescription.Size = new System.Drawing.Size(181, 20);
            this.txtCateDescription.TabIndex = 83;
            // 
            // txtCateName
            // 
            this.txtCateName.Location = new System.Drawing.Point(98, 40);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(181, 20);
            this.txtCateName.TabIndex = 82;
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(98, 5);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(181, 20);
            this.txtCateID.TabIndex = 81;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(10, 80);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 13);
            this.label52.TabIndex = 79;
            this.label52.Text = "Description";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(10, 45);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(80, 13);
            this.label53.TabIndex = 78;
            this.label53.Text = "Caterogy Name";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(10, 10);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(63, 13);
            this.label54.TabIndex = 77;
            this.label54.Text = "Category ID";
            // 
            // tShippers
            // 
            this.tShippers.Controls.Add(this.btnLoadShipper);
            this.tShippers.Controls.Add(this.btnUpdateShipper);
            this.tShippers.Controls.Add(this.btnDeleteShipper);
            this.tShippers.Controls.Add(this.btnAddShipper);
            this.tShippers.Controls.Add(this.dgvShipper);
            this.tShippers.Controls.Add(this.txtShipperPhone);
            this.tShippers.Controls.Add(this.txtShipperCompany);
            this.tShippers.Controls.Add(this.txtShipperID);
            this.tShippers.Controls.Add(this.label26);
            this.tShippers.Controls.Add(this.label28);
            this.tShippers.Controls.Add(this.label34);
            this.tShippers.Location = new System.Drawing.Point(4, 22);
            this.tShippers.Name = "tShippers";
            this.tShippers.Padding = new System.Windows.Forms.Padding(3);
            this.tShippers.Size = new System.Drawing.Size(1035, 485);
            this.tShippers.TabIndex = 7;
            this.tShippers.Text = "Shippers";
            this.tShippers.UseVisualStyleBackColor = true;
            // 
            // btnLoadShipper
            // 
            this.btnLoadShipper.Location = new System.Drawing.Point(710, 215);
            this.btnLoadShipper.Name = "btnLoadShipper";
            this.btnLoadShipper.Size = new System.Drawing.Size(119, 23);
            this.btnLoadShipper.TabIndex = 94;
            this.btnLoadShipper.Text = "Load Shipper";
            this.btnLoadShipper.UseVisualStyleBackColor = true;
            this.btnLoadShipper.Click += new System.EventHandler(this.btnLoadShipper_Click);
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.Location = new System.Drawing.Point(565, 215);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateShipper.TabIndex = 93;
            this.btnUpdateShipper.Text = "Update Shipper";
            this.btnUpdateShipper.UseVisualStyleBackColor = true;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // btnDeleteShipper
            // 
            this.btnDeleteShipper.Location = new System.Drawing.Point(710, 185);
            this.btnDeleteShipper.Name = "btnDeleteShipper";
            this.btnDeleteShipper.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteShipper.TabIndex = 92;
            this.btnDeleteShipper.Text = "Delete Shipper";
            this.btnDeleteShipper.UseVisualStyleBackColor = true;
            this.btnDeleteShipper.Click += new System.EventHandler(this.btnDeleteShipper_Click);
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.Location = new System.Drawing.Point(565, 185);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(115, 23);
            this.btnAddShipper.TabIndex = 91;
            this.btnAddShipper.Text = "Add Shipper";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // dgvShipper
            // 
            this.dgvShipper.AllowUserToAddRows = false;
            this.dgvShipper.AllowUserToDeleteRows = false;
            this.dgvShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clShipperID,
            this.clShipperCompany,
            this.clShipperPhone});
            this.dgvShipper.Location = new System.Drawing.Point(295, 40);
            this.dgvShipper.Name = "dgvShipper";
            this.dgvShipper.ReadOnly = true;
            this.dgvShipper.Size = new System.Drawing.Size(620, 137);
            this.dgvShipper.TabIndex = 90;
            // 
            // clShipperID
            // 
            this.clShipperID.HeaderText = "Shipper ID";
            this.clShipperID.Name = "clShipperID";
            this.clShipperID.ReadOnly = true;
            // 
            // clShipperCompany
            // 
            this.clShipperCompany.HeaderText = "Company Name";
            this.clShipperCompany.Name = "clShipperCompany";
            this.clShipperCompany.ReadOnly = true;
            // 
            // clShipperPhone
            // 
            this.clShipperPhone.HeaderText = "Phone";
            this.clShipperPhone.Name = "clShipperPhone";
            this.clShipperPhone.ReadOnly = true;
            // 
            // txtShipperPhone
            // 
            this.txtShipperPhone.Location = new System.Drawing.Point(98, 75);
            this.txtShipperPhone.Name = "txtShipperPhone";
            this.txtShipperPhone.Size = new System.Drawing.Size(181, 20);
            this.txtShipperPhone.TabIndex = 89;
            // 
            // txtShipperCompany
            // 
            this.txtShipperCompany.Location = new System.Drawing.Point(98, 40);
            this.txtShipperCompany.Name = "txtShipperCompany";
            this.txtShipperCompany.Size = new System.Drawing.Size(181, 20);
            this.txtShipperCompany.TabIndex = 88;
            // 
            // txtShipperID
            // 
            this.txtShipperID.Location = new System.Drawing.Point(98, 5);
            this.txtShipperID.Name = "txtShipperID";
            this.txtShipperID.Size = new System.Drawing.Size(181, 20);
            this.txtShipperID.TabIndex = 87;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 86;
            this.label26.Text = "Phone";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 85;
            this.label28.Text = "Company Name";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(10, 10);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 13);
            this.label34.TabIndex = 84;
            this.label34.Text = "Shipper ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(710, 5);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomer.TabIndex = 87;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(295, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 88;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1054, 528);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tCustomer.ResumeLayout(false);
            this.tCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tOrder.ResumeLayout(false);
            this.tOrder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tProduct.ResumeLayout(false);
            this.tProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tEmployee.ResumeLayout(false);
            this.tEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.tSuppliers.ResumeLayout(false);
            this.tSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tCategories.ResumeLayout(false);
            this.tCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tShippers.ResumeLayout(false);
            this.tShippers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tCustomer;
        private System.Windows.Forms.TabPage tOrder;
        private System.Windows.Forms.TabPage tProduct;
        private System.Windows.Forms.TextBox txtCusTitle;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusComName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCusTitle;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtCusPosCode;
        private System.Windows.Forms.Label lblPosCode;
        private System.Windows.Forms.TextBox txtCusRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtCusCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCusFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtOrderShipPosCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderShipRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderShipCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderShipAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderShipName;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblRequireDate;
        private System.Windows.Forms.TextBox txtOrderEmpID;
        private System.Windows.Forms.TextBox txtOrderCusID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderEmpID;
        private System.Windows.Forms.Label lblOrderCusID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblShippedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProSupplierID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtEmpManagerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmpPosCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpRegion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmpTitleOfCourtesy;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtEmpTitle;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.TextBox txtEmployID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tSuppliers;
        private System.Windows.Forms.TabPage tCategories;
        private System.Windows.Forms.TabPage tShippers;
        private System.Windows.Forms.TextBox txtSupFax;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSupPhone;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSupPosCode;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtSupRegion;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSupCity;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtSupAdd;
        private System.Windows.Forms.TextBox txtSupContactName;
        private System.Windows.Forms.TextBox txtSupCompanyName;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtCateDescription;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtShipperPhone;
        private System.Windows.Forms.TextBox txtShipperCompany;
        private System.Windows.Forms.TextBox txtShipperID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnLoadCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnLoadOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnLoadProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnLoadEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnLoadSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnLoadCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnLoadShipper;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.Button btnDeleteShipper;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.DataGridView dgvShipper;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpRequireDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.MaskedTextBox mtbOrderFreight;
        private System.Windows.Forms.DateTimePicker dtpEmpHireDate;
        private System.Windows.Forms.DateTimePicker dtpEmpBirthdate;
        private System.Windows.Forms.MaskedTextBox mtbEmpPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpTitleofCourtesy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpPosCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProDiscontinued;
        private System.Windows.Forms.ComboBox cbCaterogyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusComName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusPosCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusFax;
        private System.Windows.Forms.ComboBox cbCusCountry;
        private System.Windows.Forms.ComboBox cbOrderShipCountry;
        private System.Windows.Forms.ComboBox cbEmpCountry;
        private System.Windows.Forms.ComboBox cbSupCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCateDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipperID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipperCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipperPhone;
        private System.Windows.Forms.TextBox txtOrderShiperID;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderCusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReqDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderShipperID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipPosCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clShipCountry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearchCustomer;
    }
}

