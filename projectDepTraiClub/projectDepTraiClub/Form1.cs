using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdatecbofProductByCategories();
            UpdatecbofDetailByProduct();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCusCountry.SelectedIndex = -1;
            cbEmpCountry.SelectedIndex = -1;
            cbOrderShipCountry.SelectedIndex = -1;
            cbSupCountry.SelectedIndex = -1;
            //dtpOrderDate.Text = DateTime.Now.ToShortDateString();
            //dtpRequireDate.Text = DateTime.Now.ToShortDateString();
            //dtpShippedDate.Text = DateTime.Now.ToShortDateString();
            //            
            btnAddDetail.Enabled = false;
            btnNewDetail.Enabled = false;
            btnDeleteDetail.Enabled = false;
            btnUpdateDetail.Enabled = false;
            btnSearchDetail.Enabled = false; 
            //
        }

        #region SectionChange
        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCustomer.SelectedRows[0];
                txtCustomerID.Text = r.Cells[0].Value.ToString();
                txtCusComName.Text = r.Cells[1].Value.ToString();
                txtCusName.Text = r.Cells[2].Value.ToString();
                txtCusTitle.Text = r.Cells[3].Value.ToString();
                txtCusAddress.Text = r.Cells[4].Value.ToString();
                txtCusCity.Text = r.Cells[5].Value.ToString();
                txtCusRegion.Text = r.Cells[6].Value.ToString();
                txtCusPosCode.Text = r.Cells[7].Value.ToString();
                cbCusCountry.Text = r.Cells[8].Value.ToString();
                mtbCusPhone.Text = r.Cells[9].Value.ToString();
                txtCusFax.Text = r.Cells[10].Value.ToString();
            }
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvOrder.SelectedRows[0];
                txtOrderID.Text = r.Cells[0].Value.ToString();
                txtOrderCusID.Text = r.Cells[1].Value.ToString();
                txtOrderEmpID.Text = r.Cells[2].Value.ToString();
                DateTime dt;
                DateTime.TryParse(r.Cells[3].Value.ToString(), out dt);
                dtpOrderDate.Value = dt;
                DateTime.TryParse(r.Cells[4].Value.ToString(), out dt);
                dtpRequireDate.Value = dt;
                DateTime.TryParse(r.Cells[5].Value.ToString(), out dt);
                dtpShippedDate.Value = dt;
                txtOrderShiperID.Text = r.Cells[6].Value.ToString();
                mtbOrderFreight.Text = r.Cells[7].Value.ToString();
                txtOrderShipName.Text = r.Cells[8].Value.ToString();
                txtOrderShipAddress.Text = r.Cells[9].Value.ToString();
                txtOrderShipCity.Text = r.Cells[10].Value.ToString();
                txtOrderShipRegion.Text = r.Cells[11].Value.ToString();
                txtOrderShipPosCode.Text = r.Cells[12].Value.ToString();
                cbOrderShipCountry.Text = r.Cells[13].Value.ToString();
            }
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvProduct.SelectedRows[0];
                txtProductID.Text = r.Cells[0].Value.ToString();
                txtProductName.Text = r.Cells[1].Value.ToString();
                txtProSupplierID.Text = r.Cells[2].Value.ToString();
                cbCaterogyID.DropDownStyle = ComboBoxStyle.DropDown;
                cbCaterogyID.Text = r.Cells[3].Value.ToString();
                cbCaterogyID.Text = cbCaterogyID.ValueMember;
                cbCaterogyID.DropDownStyle = ComboBoxStyle.DropDownList;
                txtProUnitPrice.Text = r.Cells[4].Value.ToString();
                if (r.Cells[5].Value.ToString().Equals("Y"))
                    radYes.Checked = true;
                else radNo.Checked = true; ;
            }
        }

        private void dgvEmp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmp.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvEmp.SelectedRows[0];
                txtEmployID.Text = r.Cells[0].Value.ToString();
                txtEmpLastName.Text = r.Cells[1].Value.ToString();
                txtEmpFirstName.Text = r.Cells[2].Value.ToString();
                txtEmpTitle.Text = r.Cells[3].Value.ToString();
                txtEmpTitleOfCourtesy.Text = r.Cells[4].Value.ToString();
                DateTime dt;
                DateTime.TryParse(r.Cells[5].Value.ToString(), out dt);
                dtpEmpBirthdate.Value = dt;
                DateTime.TryParse(r.Cells[6].Value.ToString(), out dt);
                dtpEmpHireDate.Value = dt;
                txtEmpAddress.Text = r.Cells[7].Value.ToString();
                txtEmpCity.Text = r.Cells[8].Value.ToString();
                txtEmpRegion.Text = r.Cells[9].Value.ToString();
                txtEmpPosCode.Text = r.Cells[10].Value.ToString();
                cbEmpCountry.Text = r.Cells[11].Value.ToString();
                mtbEmpPhone.Text = r.Cells[12].Value.ToString();
                txtEmpManagerID.Text = r.Cells[13].Value.ToString();
            }
        }

        private void dgvSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvSupplier.SelectedRows[0];
                txtSupID.Text = r.Cells[0].Value.ToString();
                txtSupCompanyName.Text = r.Cells[1].Value.ToString();
                txtSupContactName.Text = r.Cells[2].Value.ToString();
                txtSupContactTitle.Text = r.Cells[3].Value.ToString();
                txtSupAdd.Text = r.Cells[4].Value.ToString();
                txtSupCity.Text = r.Cells[5].Value.ToString();
                txtSupRegion.Text = r.Cells[6].Value.ToString();
                txtSupPosCode.Text = r.Cells[7].Value.ToString();
                cbSupCountry.DropDownStyle = ComboBoxStyle.DropDown;
                cbSupCountry.Text = r.Cells[8].Value.ToString();
                cbSupCountry.DropDownStyle = ComboBoxStyle.DropDownList;
                mtbSupPhone.Text = r.Cells[9].Value.ToString();
                txtSupFax.Text = r.Cells[10].Value.ToString();
            }
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCategory.SelectedRows[0];
                txtCateID.Text = r.Cells[0].Value.ToString();
                txtCateName.Text = r.Cells[1].Value.ToString();
                txtCateDescription.Text = r.Cells[2].Value.ToString();
            }
        }

        private void dgvShipper_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShipper.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvShipper.SelectedRows[0];
                txtShipperID.Text = r.Cells[0].Value.ToString();
                txtShipperCompany.Text = r.Cells[1].Value.ToString();
                mtbShipperPhone.Text = r.Cells[2].Value.ToString();
            }
        }

        #endregion


        #region validate input
        private bool validateCustomer()
        {
            bool error = true;
            if (txtCusComName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusComName, "Enter Customer's company!!!");
                error = false;
            }
            if (txtCusName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusName, "Enter Customer's name!!!");
                error = false;
            }
            if (txtCusTitle.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusTitle, "Enter Title!!!");
                error = false;
            }
            if (txtCusAddress.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusAddress, "Enter Customer's address!!!");
                error = false;
            }
            if (txtCusCity.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusCity, "Enter Customer's City!!!");
                error = false;
            }
            if (cbCusCountry.Text.Length == 0)
            {
                errorProvider1.SetError(cbCusCountry, "Select Country!!!");
                error = false;
            }
            if (mtbCusPhone.MaskCompleted == false)
            {
                errorProvider1.SetError(mtbCusPhone, "Enter Custumber's phone number!!!");
                error = false;
            }
            return error;
        }

        private bool validateOrder()
        {
            bool error = true;
            DateTime currDate = DateTime.Now;
            int currYear = currDate.Year;
            DateTime OrderDate = dtpOrderDate.Value;
            DateTime RequireDate = dtpRequireDate.Value;
            DateTime ShippedDate = dtpShippedDate.Value;
            if (currDate.CompareTo(OrderDate)<=0)
            {
                errorProvider1.SetError(dtpOrderDate, "Order date must before today");
                error = false;
            }
            if (RequireDate.CompareTo(OrderDate) < 0)
            {
                errorProvider1.SetError(dtpRequireDate, "Require date must after order date");
                error = false;
            }
            if (ShippedDate.CompareTo(RequireDate) > 0 || ShippedDate.CompareTo(OrderDate)<=0)
            {
                errorProvider1.SetError(dtpShippedDate, "Shipped date can't be after require date or before order date");
                error = false;
            }
            if (txtOrderEmpID.Text.Length == 0)
            {
                errorProvider1.SetError(txtProductName, "Enter Employee's ID!!!");
                error = false;
            }
            if (mtbOrderFreight.MaskCompleted==false)
            {
                errorProvider1.SetError(mtbOrderFreight, "Enter Order's Freight!!!");
                error = false;
            }
            if (txtOrderShipName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusAddress, "Enter Ship Name!!!");
                error = false;
            }
            if (txtOrderShipAddress.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipAddress, "Enter Ship Address!!!");
                error = false;
            }
            if (txtOrderShipCity.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipCity, "Enter Ship City!!!");
                error = false;
            }
            if (cbOrderShipCountry.Text.Length == 0)
            {
                errorProvider1.SetError(cbOrderShipCountry, "Enter Ship Address!!!");
                error = false;
            }
            return error;
        }

        private bool validateProduct()
        {
            bool error = true;
            if (txtProductName.Text.Length == 0)
            {
                errorProvider1.SetError(txtProductName, "Enter product name!!!");
                error = false;
            }
            if (txtProSupplierID.Text.Length == 0)
            {
                errorProvider1.SetError(txtProSupplierID, "Enter Supplier ID!!!");
                error = false;
            }
            if (cbCaterogyID.Text.Length == 0)
            {
                errorProvider1.SetError(cbCaterogyID, "Choose Category ID!!!");
                error = false;
            }
            if (txtProUnitPrice.Text.Length == 0)
            {
                errorProvider1.SetError(txtProUnitPrice, "Enter Unit Price!!!");
                error = false;
            }
            if (radYes.Checked == false && radNo.Checked == false)
            {
                errorProvider1.SetError(groupBox1, "Please select status!");
                error = false;
            }
            return error;
        }

        private bool validateEmp()
        {
            bool error = true;
            if (txtEmpLastName.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpLastName, "Enter Employee's Last Name!!!");
                error = false;
            }
            if (txtEmpFirstName.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpFirstName, "Enter Employee's First Name!!!");
                error = false;
            }
            if (txtEmpTitle.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpTitle, "Enter Ship Name!!!");
                error = false;
            }
            if (txtEmpTitleOfCourtesy.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipAddress, "Enter Title of Courtesy!!!");
                error = false;
            }

            DateTime currDate = DateTime.Now;
            int currYear = currDate.Year;
            DateTime DateofBirth = dtpEmpBirthdate.Value;
            int birthYear = DateofBirth.Year;
            DateTime HireDate = dtpEmpHireDate.Value;
            int hireYear = HireDate.Year;
            if (currYear - birthYear < 18)
            {
                errorProvider1.SetError(dtpEmpBirthdate, "Age must be greater than or equal to 18");
                error = false;
            }
            if (currYear - hireYear < 0)
            {
                errorProvider1.SetError(dtpEmpBirthdate, "Hire date must before today!!!");
                error = false;
            }

            if (txtEmpAddress.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpAddress, "Enter Employee Address!!!");
                error = false;
            }
            if (txtEmpCity.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpCity, "Enter Employee City!!!");
                error = false;
            }
            if (mtbEmpPhone.MaskCompleted == false)
            {
                errorProvider1.SetError(mtbEmpPhone, "Please enter require digit!!!");
                error = false;
            }
            return error;
        }

        private bool validateSupplier()
        {
            bool error = true;
            if (txtSupCompanyName.Text.Length == 0)
            {
                errorProvider1.SetError(txtSupCompanyName, "Enter Company Name!");
                error = false;
            }
            if (txtSupContactName.Text.Length == 0)
            {
                errorProvider1.SetError(txtSupContactName, "Enter Contact Name!");
                error = false;
            }
            if (txtSupAdd.Text.Length == 0)
            {
                errorProvider1.SetError(txtSupAdd, "Enter Address!");
                error = false;
            }
            if (txtSupCity.Text.Length == 0)
            {
                errorProvider1.SetError(txtSupCity, "Enter City!");
                error = false;
            }
            if (cbSupCountry.Text.Length == 0)
            {
                errorProvider1.SetError(cbCusCountry, "Select Country!");
                error = false;
            }
            if (mtbSupPhone.MaskCompleted==false)
            {
                errorProvider1.SetError(mtbSupPhone, "Enter Number!");
                error = false;
            }
            return error;

        }

        private bool validateCategory()
        {
            bool error = true;
            if (txtCateName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCateName, "Enter Category Name!");
                error = false;
            }
            if (txtCateDescription.Text.Length == 0)
            {
                errorProvider1.SetError(txtCateDescription, "Enter Description");
                error = false;
            }
            return error;
        }

        private bool validateShipper()
        {
            bool error = true;
            if (txtShipperCompany.Text.Length == 0)
            {
                errorProvider1.SetError(txtShipperCompany, "Enter Company!");
                error = false;
            }
            if (mtbShipperPhone.MaskCompleted == false)
            {
                errorProvider1.SetError(mtbShipperPhone, "Enter Phone Number!");
                error = false;
            }
            return error;
        }


        public bool validateOrderDetail()
        {
            bool error = true;


            //Hien thuc code



            return error;
        }
        #endregion



        #region validate enter number
        private void txtCusPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtCusFax_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtCusPosCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtShipPosCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtOrderCusID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtOrderEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtProSupplierID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtProCategoryID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtEmpPosCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtMgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtOrFreight_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        #endregion


        #region combo box
        private void UpdatecbofProductByCategories()
        {
            //Cần sử dùng phương thức App.conf
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"server=(local);database=TSQLFundamentals2008;uid=sa;pwd=123456";
            //SqlCommand cmd = new SqlCommand();
            //SqlConnection con = new SqlConnection();
            //cmd.Connection = (new DAO.getCon()).ConDB();

            SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryID,CategoryName FROM Production.Categories", con);
            DataTable dt = new DataTable("Production.Categories");
            da.Fill(dt);

            DataRow r = dt.NewRow();
            r["CategoryID"] = -1;
            r["CategoryName"] = "Select category";
            dt.Rows.InsertAt(r, 0);

            cbCaterogyID.DataSource = dt;
            cbCaterogyID.DisplayMember = "CategoryName";
            cbCaterogyID.ValueMember = "CategoryID";
        }

        private void UpdatecbofDetailByProduct()
        {
            //Cần sử dùng phương thức App.conf
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"server=(local);database=TSQLFundamentals2008;uid=sa;pwd=123456";

            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID,ProductName FROM Production.Products", con);
            DataTable dt = new DataTable("Production.Products");
            da.Fill(dt);

            DataRow r = dt.NewRow();
            r["ProductID"] = -1;
            r["ProductName"] = "Select Products";
            dt.Rows.InsertAt(r, 0);

            cbDetailProductID.DataSource = dt;
            cbDetailProductID.DisplayMember = "ProductName";
            cbDetailProductID.ValueMember = "ProductID";
        }
        #endregion


        #region load from db to dgv
        private void btnLoadEmp_Click(object sender, EventArgs e)
        {
            LoadEmp();
        }

        private void LoadEmp()
        {
            SqlDataReader dr = (new employee()).select();
            dgvEmp.Rows.Clear();
            while (dr.Read())
            {
                string mgrid="";
                if (dr[13] == DBNull.Value)
                    mgrid = "";
                else mgrid = dr[13].ToString();
                dgvEmp.Rows.Add(dr.GetInt32(0), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                    DateTime.Parse(dr[5].ToString()).ToShortDateString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(),
                    dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), mgrid);
            }
            dr.Close();
        }

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            SqlDataReader dr = (new products()).select();
            dgvProduct.Rows.Clear();
            while (dr.Read())
            {
                string s = "";
                if (dr.GetBoolean(5) == true)
                    s = "Y";
                else s = "N";
                dgvProduct.Rows.Add(dr.GetInt32(0), dr[1].ToString(), dr.GetInt32(2), dr.GetInt32(3), double.Parse(dr[4].ToString()), s);
            }
            dr.Close();
        }

        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            SqlDataReader dr = (new order()).select();
            dgvOrder.Rows.Clear();
            while (dr.Read())
            {
                int cusid;
                if (dr[1] == DBNull.Value)
                    cusid = 0;
                else cusid = dr.GetInt32(0);
                dgvOrder.Rows.Add(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), DateTime.Parse(dr[3].ToString()).ToShortDateString(),
                    DateTime.Parse(dr[4].ToString()).ToShortDateString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(),
                    dr.GetInt32(6), double.Parse(dr[7].ToString()), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
            }
            dr.Close();
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            SqlDataReader dr = (new customer()).select();
            dgvCustomer.Rows.Clear();
            while (dr.Read())
            {
                dgvCustomer.Rows.Add(dr.GetInt32(0), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
        }

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }
        private void LoadSupplier()
        {
            SqlDataReader dr = (new Supplier()).select();
            dgvSupplier.Rows.Clear();
            while (dr.Read())
            {
                dgvSupplier.Rows.Add(
                    dr.GetInt32(0),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString(),
                    dr[9].ToString(),
                    dr[10].ToString()
                    );
            }
            dr.Close();
        }

        private void btnLoadCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            SqlDataReader dr = (new Categori()).select();
            dgvCategory.Rows.Clear();
            while (dr.Read())
            {
                dgvCategory.Rows.Add(
                    dr.GetInt32(0),
                    dr[1].ToString(),
                    dr[2].ToString()
                    );
            }
            dr.Close();
        }
        private void btnLoadShipper_Click(object sender, EventArgs e)
        {
            LoadShipper();
        }
        private void LoadShipper()
        {
            SqlDataReader dr = (new Shipper()).select();
            dgvShipper.Rows.Clear();
            while (dr.Read())
            {
                dgvShipper.Rows.Add(
                    dr.GetInt32(0),
                    dr[1].ToString(),
                    dr[2].ToString()
                    );
            }
            dr.Close();
        }
        #endregion


        #region add
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (validateCustomer() == false)
                return;
            AddCustomer();
            LoadCustomer();
        }

        private void AddCustomer()
        {
            List<String> list = new List<string>();
            list.Add(txtCusComName.Text);
            list.Add(txtCusName.Text);
            list.Add(txtCusTitle.Text);
            list.Add(txtCusAddress.Text);
            list.Add(txtCusCity.Text);
            list.Add(txtCusRegion.Text);
            list.Add(txtCusPosCode.Text);
            list.Add(cbCusCountry.Text);
            list.Add(mtbCusPhone.Text);
            list.Add(txtCusFax.Text);
            new customer().insert(list);
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (validateOrder() == false)
                return;
            AddOrder();
            LoadOrder();
        }

        private void AddOrder()
        {
            List<String> list = new List<string>();
            list.Add(txtOrderCusID.Text);
            list.Add(txtOrderEmpID.Text);
            list.Add(dtpOrderDate.Value.ToShortDateString());
            list.Add(dtpRequireDate.Value.ToShortDateString());
            list.Add(dtpShippedDate.Value.ToShortDateString());
            list.Add(txtOrderShiperID.Text);
            list.Add(mtbOrderFreight.Text);
            list.Add(txtOrderShipName.Text);
            list.Add(txtOrderShipAddress.Text);
            list.Add(txtOrderShipCity.Text);
            list.Add(txtOrderShipRegion.Text);
            list.Add(txtOrderShipPosCode.Text);
            list.Add(cbOrderShipCountry.Text.ToString());
            new order().insert(list);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (validateProduct() == false)
                return;
            AddProduct();
            LoadProduct();
        }
        private void AddProduct()
        {
            List<String> list = new List<string>();
            list.Add(this.txtProductName.Text);
            list.Add(this.txtProSupplierID.Text);
            list.Add(this.cbCaterogyID.SelectedValue.ToString());
            list.Add(this.txtProUnitPrice.Text);
            if (this.radYes.Checked)
            {
                list.Add("True");
            }
            else
            {
                list.Add("False");
            }
            UpdatecbofDetailByProduct();
            new products().insert(list);
        }
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (validateEmp() == false)
                return;
            AddEmp();
            LoadEmp();
        }
        private void AddEmp()
        {
            List<String> list = new List<string>();
            list.Add(this.txtEmpLastName.Text);
            list.Add(this.txtEmpFirstName.Text);
            list.Add(this.txtEmpTitle.Text);
            list.Add(this.txtEmpTitleOfCourtesy.Text);
            //Date
            list.Add(this.dtpEmpBirthdate.Value.ToShortDateString());
            list.Add(this.dtpEmpHireDate.Value.ToShortDateString());
            //
            list.Add(this.txtEmpAddress.Text);
            list.Add(this.txtEmpCity.Text);
            list.Add(this.txtEmpRegion.Text);
            list.Add(this.txtEmpPosCode.Text);
            list.Add(this.cbEmpCountry.ValueMember);
            list.Add(this.mtbEmpPhone.Text);
            list.Add(this.txtEmpManagerID.Text);
            new employee().insert(list);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (validateSupplier() == false)
                return;
            AddSupplier();
            LoadSupplier();
        }
        private void AddSupplier()
        {
            List<String> list = new List<string>();
            list.Add(this.txtSupCompanyName.Text);
            list.Add(this.txtSupContactName.Text);
            list.Add(this.txtSupContactTitle.Text);
            list.Add(this.txtSupAdd.Text);
            list.Add(this.txtSupCity.Text);
            list.Add(this.txtSupRegion.Text);
            list.Add(this.txtSupPosCode.Text);
            list.Add(this.cbSupCountry.Text);
            list.Add(this.mtbSupPhone.Text);
            list.Add(this.txtSupFax.Text);
            new Supplier().insert(list);
        }
        private void addOrderDetail_Click(object sender, EventArgs e)
        {
            //List<String> list = new List<string>();
            //list.Add(this.txtOrderID.Text);
            //list.Add(this.txtOrderCusID.Text);
            //list.Add(this.txtoe.Text);
            //list.Add(this.txtOrDeQuantity.Text);
            //list.Add(this.txtOrDeDiscount.Text);
            //new orderDetail().insert(list);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (validateCategory() == false)
                return;
            AddCategory();
            LoadCategory();
        }
        private void AddCategory()
        {
            List<String> list = new List<string>();
            list.Add(this.txtCateName.Text);
            list.Add(this.txtCateDescription.Text);
            new Categori().insert(list);
            //Mỗi lần thêm vào 1 category mới update lại combox trong Product
            UpdatecbofProductByCategories();
        }
        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            if (validateShipper() == false)
                return;
            AddShipper();
            LoadShipper();
        }
        private void AddShipper()
        {
            List<String> list = new List<string>();
            list.Add(this.txtShipperCompany.Text);
            list.Add(this.mtbShipperPhone.Text);
            new Shipper().insert(list);
        }
        #endregion


        #region delete
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            LoadCustomer();
        }

        private void DeleteCustomer()
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCustomer.SelectedRows[0];
                new customer().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
            LoadOrder();
        }

        private void DeleteOrder()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvOrder.SelectedRows[0];
                new order().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
            LoadProduct();
        }

        private void DeleteProduct()
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvProduct.SelectedRows[0];
                new products().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            DeleteEmp();
            LoadEmp();
        }

        private void DeleteEmp()
        {
            if (dgvEmp.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvEmp.SelectedRows[0];
                new employee().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
            LoadSupplier();
        }

        private void DeleteSupplier()
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvSupplier.SelectedRows[0];
                new Supplier().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
            LoadCategory();
        }

        private void DeleteCategory()
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCategory.SelectedRows[0];
                new Categori().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            DeleteShipper();
            LoadShipper();
        }

        private void DeleteShipper()
        {
            if (dgvShipper.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvShipper.SelectedRows[0];
                new Shipper().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        #endregion



        #region update
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (validateCustomer() == false)
                return;
            UpdateCustomer();
            LoadCustomer();
        }

        private void UpdateCustomer()
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCustomer.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                List<String> list = new List<string>();
                list.Add(txtCusComName.Text);
                list.Add(txtCusName.Text);
                list.Add(txtCusTitle.Text);
                list.Add(txtCusAddress.Text);
                list.Add(txtCusCity.Text);
                list.Add(txtCusRegion.Text);
                list.Add(txtCusPosCode.Text);
                list.Add(cbCusCountry.Text);
                list.Add(mtbCusPhone.Text);
                list.Add(txtCusFax.Text);
                new customer().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (validateOrder() == false)
                return;
            UpdateOrder();
            LoadOrder();
        }

        private void UpdateOrder()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvOrder.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                List<String> list = new List<string>();
                list.Add(txtOrderCusID.Text);
                list.Add(txtOrderEmpID.Text);
                list.Add(dtpOrderDate.Value.ToShortDateString());
                list.Add(dtpRequireDate.Value.ToShortDateString());
                list.Add(dtpShippedDate.Value.ToShortDateString());
                list.Add(txtOrderShiperID.Text);
                list.Add(mtbOrderFreight.Text);
                list.Add(txtOrderShipName.Text);
                list.Add(txtOrderShipAddress.Text);
                list.Add(txtOrderShipCity.Text);
                list.Add(txtOrderShipRegion.Text);
                list.Add(txtOrderShipPosCode.Text);
                list.Add(cbOrderShipCountry.Text);
                new order().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (validateProduct() == false)
                return;
            UpdateProduct();
            LoadProduct();
        }

        private void UpdateProduct()
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvProduct.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                List<String> list = new List<string>();
                list.Add(this.txtProductName.Text);
                list.Add(this.txtProSupplierID.Text);
                list.Add(this.cbCaterogyID.SelectedValue.ToString());
                list.Add(this.txtProUnitPrice.Text);
                if (this.radYes.Checked)
                {
                    list.Add("True");
                }
                else
                {
                    list.Add("False");
                }
                new products().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (validateEmp() == false)
                return;
            UpdateEmp();
            LoadEmp();
        }

        void UpdateEmp()
        {
            if (dgvEmp.SelectedRows.Count > 0)
            {
                List<String> list = new List<string>();
                DataGridViewRow r = dgvEmp.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                list.Add(this.txtEmpLastName.Text);
                list.Add(this.txtEmpFirstName.Text);
                list.Add(this.txtEmpTitle.Text);
                list.Add(this.txtEmpTitleOfCourtesy.Text);
                //Date
                list.Add(this.dtpEmpBirthdate.Value.ToShortDateString());
                list.Add(this.dtpEmpHireDate.Value.ToShortDateString());
                //
                list.Add(this.txtEmpAddress.Text);
                list.Add(this.txtEmpCity.Text);
                list.Add(this.txtEmpRegion.Text);
                list.Add(this.txtEmpPosCode.Text);
                list.Add(this.cbEmpCountry.Text);
                list.Add(this.mtbEmpPhone.Text);
                list.Add(this.txtEmpManagerID.Text);
                new employee().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
            LoadSupplier();
        }

        private void UpdateSupplier()
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvSupplier.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                List<String> list = new List<string>();
                list.Add(this.txtSupCompanyName.Text);
                list.Add(this.txtSupContactName.Text);
                list.Add(this.txtSupContactTitle.Text);
                list.Add(this.txtSupAdd.Text);
                list.Add(this.txtSupCity.Text);
                list.Add(this.txtSupRegion.Text);
                list.Add(this.txtSupPosCode.Text);
                list.Add(this.cbSupCountry.Text);
                list.Add(this.mtbSupPhone.Text);
                list.Add(this.txtSupFax.Text);
                new Supplier().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory();
            LoadCategory();
        }

        private void UpdateCategory()
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCategory.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                List<String> list = new List<string>();
                list.Add(this.txtCateName.Text);
                list.Add(this.txtCateDescription.Text);
                new Categori().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {
            if (validateShipper() == false)
                return;
            UpdateShipper();
            LoadShipper();
        }

        private void UpdateShipper()
        {
            if (dgvShipper.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvShipper.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());
                List<String> list = new List<string>();
                list.Add(this.txtShipperCompany.Text);
                list.Add(this.mtbShipperPhone.Text);
                new Shipper().update(point, list);
            }
            else
                MessageBox.Show("Select row to update!");
        }


        #endregion

        #region search
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" &
                txtCusComName.Text == "" &
                txtCusName.Text == "" &
                txtCusTitle.Text == "" &
                txtCusAddress.Text == "" &
                txtCusCity.Text == "" &
                txtCusRegion.Text == "" &
                txtCusPosCode.Text == "" &
                mtbCusPhone.Text == "" &
                txtCusFax.Text == "" &
                cbCusCountry.SelectedIndex == -1
                )
            {
                //All text empty
                MessageBox.Show("========================");
            }
            else
            {
                List<String> list = new List<string>();
                list.Add(txtCusComName.Text);
                list.Add(txtCusName.Text);
                list.Add(txtCusTitle.Text);
                list.Add(txtCusAddress.Text);
                list.Add(txtCusCity.Text);
                list.Add(txtCusRegion.Text);
                list.Add(txtCusPosCode.Text);
                list.Add(cbCusCountry.Text);
                list.Add(mtbCusPhone.Text);
                list.Add(txtCusFax.Text);
                SqlDataReader dr = new customer().search(list);
                dgvCustomer.Rows.Clear();
                while (dr.Read())
                {
                    dgvCustomer.Rows.Add(
                        dr.GetInt32(0),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString(),
                        dr[7].ToString(),
                        dr[8].ToString(),
                        dr[9].ToString(),
                        dr[10].ToString()
                        );
                }
                dr.Close();
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            //Còn lỗi chưa xử lí đc

            if( txtOrderCusID.Text == ""&
                txtOrderEmpID.Text == ""&
                dtpOrderDate.Text == DateTime.Now.ToShortDateString()&
                dtpRequireDate.Text == DateTime.Now.ToShortDateString()&
                dtpShippedDate.Text == DateTime.Now.ToShortDateString()&
                txtOrderShiperID.Text == ""&
                mtbOrderFreight.Text == ""&
                txtOrderShipName.Text == "" &
                txtOrderShipAddress.Text == ""&
                txtOrderShipCity.Text == ""&
                txtOrderShipRegion.Text == ""&
                txtOrderShipPosCode.Text == ""&
                cbOrderShipCountry.SelectedIndex == -1)
            {
                MessageBox.Show("====================");
            }
            else
            {
                List<String> list = new List<string>();
                list.Add(txtOrderCusID.Text);
                list.Add(txtOrderEmpID.Text);
                list.Add(dtpOrderDate.Value.ToShortDateString());
                list.Add(dtpRequireDate.Value.ToShortDateString());
                list.Add(dtpShippedDate.Value.ToShortDateString());
                list.Add(txtOrderShiperID.Text);
                list.Add(mtbOrderFreight.Text);
                list.Add(txtOrderShipName.Text);
                list.Add(txtOrderShipAddress.Text);
                list.Add(txtOrderShipCity.Text);
                list.Add(txtOrderShipRegion.Text);
                list.Add(txtOrderShipPosCode.Text);
                list.Add(cbOrderShipCountry.Text);
                SqlDataReader dr = new order().search(list);
                dgvCustomer.Rows.Clear();
                while (dr.Read())
                {
                    dgvCustomer.Rows.Add(
                        dr.GetInt32(0),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString(),
                        dr[7].ToString(),
                        dr[8].ToString(),
                        dr[9].ToString(),
                        dr[10].ToString(),
                        dr[11].ToString(),
                        dr[12].ToString()
                        );
                }
                dr.Close();
            }
            
        }

        #endregion


        #region new text
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCusComName.Text = "";
            txtCusName.Text = "";
            txtCusTitle.Text = "";
            txtCusAddress.Text = "";
            txtCusCity.Text = "";
            txtCusRegion.Text = "";
            txtCusPosCode.Text = "";
            mtbCusPhone.Text = "";
            txtCusFax.Text = "";
            cbCusCountry.SelectedIndex = -1;
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtOrderCusID.Text = "";
            txtOrderEmpID.Text = "";
            dtpOrderDate.Text = DateTime.Now.ToShortDateString();
            dtpRequireDate.Text = DateTime.Now.ToShortDateString();
            dtpShippedDate.Text = DateTime.Now.ToShortDateString();
            txtOrderShiperID.Text = "";
            mtbOrderFreight.Text = "";
            txtOrderShipName.Text = "";
            txtOrderShipAddress.Text = "";
            txtOrderShipCity.Text = "";
            txtOrderShipRegion.Text = "";
            txtOrderShipPosCode.Text = "";
            cbOrderShipCountry.SelectedIndex = -1;
        }

        private void btnNewDetail_Click(object sender, EventArgs e)
        {
            //Mô tả tính năng: cbDetailProductID sử dụng giúp người dùng chọn nhanh Product ID từ tab Product
            cbDetailProductID.SelectedIndex = -1;
            txtDetailQuantity.Text = "";
            txtDetailUnitPrice.Text = "";
            txtDetailDiscount.Text = "";
        }
        #endregion

        
        private void btnSearchDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (validateOrderDetail() == false)    //chua hien thuc ham validateOrderDetail
                return;
            AddDetail();
            LoadDetailByOrder();
        }
        private void AddDetail()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvOrder.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());

                List<String> list = new List<string>();
                list.Add(cbDetailProductID.SelectedValue.ToString());
                list.Add(txtDetailQuantity.Text);
                list.Add(txtDetailUnitPrice.Text);
                list.Add(txtDetailDiscount.Text);

                new orderDetail().insert(point,list);
            }
        }
        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddDetail.Enabled = true;
            btnNewDetail.Enabled = true;
            btnDeleteDetail.Enabled = true;
            btnUpdateDetail.Enabled = true;
            btnSearchDetail.Enabled = true; 
            LoadDetailByOrder();
        }

        private void LoadDetailByOrder()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvOrder.SelectedRows[0];
                Int32 point = Int32.Parse(r.Cells[0].Value.ToString());

                SqlDataReader dr = (new orderDetail()).searchByID(point);// list);
                dgvDetail.Rows.Clear();
                while (dr.Read())
                {
                    dgvDetail.Rows.Add(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        decimal.Parse(dr[2].ToString()),
                        dr.GetInt16(3),
                        decimal.Parse(dr[4].ToString())
                        );
                }
                dr.Close();     
            }
        }






    }
}
