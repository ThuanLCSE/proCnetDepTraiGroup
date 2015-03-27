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
            Categories();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                txtCusPhone.Text = r.Cells[9].Value.ToString();
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
                mtbOrderFreight.Text = r.Cells[6].Value.ToString();
                txtOrderShipName.Text = r.Cells[7].Value.ToString();
                txtOrderShipAddress.Text = r.Cells[8].Value.ToString();
                txtOrderShipCity.Text = r.Cells[9].Value.ToString();
                txtOrderShipRegion.Text = r.Cells[10].Value.ToString();
                txtOrderShipPosCode.Text = r.Cells[11].Value.ToString();
                cbOrderShipCountry.Text = r.Cells[12].Value.ToString();
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
            if (txtCusPhone.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusPhone, "Enter Custumber's phone number!!!");
                error = false;
            }
            return error;
        }

        private bool validateOrder()
        {
            bool error = true;
            if (txtOrderEmpID.Text.Length == 0)
            {
                errorProvider1.SetError(txtProductName, "Enter Employee's ID!!!");
                error = false;
            }
            if (mtbOrderFreight.Text.Length == 0)
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
            //if (cbCaterogyID.Text.Length == 0)
            //{
            //    errorProvider1.SetError(cbCaterogyID, "Enter Category ID!!!");
            //    error = false;
            //}
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
            if (currYear - birthYear < 0)
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
            if (txtEmpRegion.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpRegion, "Enter Employee's Region!!!");
                error = false;
            }
            if (txtEmpPosCode.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpPosCode, "Enter Postal Code!!!");
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
            if (cbCusCountry.Text.Length == 0)
            {
                errorProvider1.SetError(cbCusCountry, "Select Country!");
                error = false;
            }
            if (txtSupPhone.Text.Length == 0)
            {
                errorProvider1.SetError(txtSupPhone, "Enter Number!");
                error = false;
            }
            return error;

        }

        private bool validateCategory()
        {
            bool error = true;
            return error;
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
        }

        private bool validateShipper()
        {
            bool error = true;
            if (txtShipperCompany.Text.Length == 0)
            {
                errorProvider1.SetError(txtShipperCompany, "Enter Company!");
                error = false;
            }
            if (txtShipperPhone.Text.Length == 0)
            {
                errorProvider1.SetError(txtShipperPhone, "Enter Phone Number!");
                error = false;
            }
            return false;
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
                int mgrid;
                if (dr[13] == DBNull.Value)
                    mgrid = 0;
                else mgrid = dr.GetInt32(0);
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
                if (dr.GetBoolean(5)==true)
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
        #endregion



        #region combo box
        void Categories()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"server=(local);database=TSQLFundamentals2008;uid=sa;pwd=123456";

            SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryID,CategoryName FROM Production.Categories",con);
            DataTable dt = new DataTable("Production.Categories");
            da.Fill(dt);

            cbCaterogyID.DataSource = dt;
            cbCaterogyID.DisplayMember = "CategoryName";
            cbCaterogyID.ValueMember = "CategoryID";
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
            list.Add(txtCusPhone.Text);
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
            list.Add(mtbOrderFreight.Text);
            list.Add(txtOrderShipName.Text);
            list.Add(txtOrderShipAddress.Text);
            list.Add(txtOrderShipCity.Text);
            list.Add(txtOrderShipRegion.Text);
            list.Add(txtOrderShipPosCode.Text);
            list.Add(cbOrderShipCountry.Text);
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
            list.Add(this.txtProductID.Text);
            list.Add(this.txtProductName.Text);
            list.Add(this.txtSupID.Text);
            list.Add(this.cbCaterogyID.Text);
            list.Add(this.txtProUnitPrice.Text);
            if (this.radYes.Checked)
            {
                list.Add("True");
            }
            else
            {
                list.Add("False");
            }
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
            list.Add(this.txtEmployID.Text);
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
            new employee().insert(list);
        }


        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
        }

        private void AddSupplier()
        {
            List<String> list = new List<string>();
            list.Add(this.txtSupID.Text);
            list.Add(this.txtSupCompanyName.Text);
            list.Add(this.txtSupContactName.Text);
            list.Add(this.txtSupAdd.Text);
            list.Add(this.txtSupCity.Text);
            list.Add(this.txtSupRegion.Text);
            list.Add(this.txtSupPosCode.Text);
            list.Add(this.cbSupCountry.Text);
            list.Add(this.txtSupPhone.Text);
            list.Add(this.txtSupFax.Text);
            new Supplier().insert(list);
        }

        //private void addOrderDetail_Click(object sender, EventArgs e)
        //{
        //    List<String> list = new List<string>();
        //    list.Add(this.txtOrDeDetailID.Text);
        //    list.Add(this.txtOrDeProID.Text);
        //    list.Add(this.txtOrDeUnitPrice.Text);
        //    list.Add(this.txtOrDeQuantity.Text);
        //    list.Add(this.txtOrDeDiscount.Text);
        //    new orderDetail().insert(list);
        //}

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            list.Add(this.txtCateID.Text);
            list.Add(this.txtCateName.Text);
            list.Add(this.txtCateDescription.Text);
            new Categori().insert(list);
        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            list.Add(this.txtShipperID.Text);
            list.Add(this.txtShipperCompany.Text);
            list.Add(this.txtShipperPhone.Text);
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

        void DeleteProduct()
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
        }

        private void DeleteSupplier()
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvSupplier.SelectedRows[0];
                new employee().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void DeleteCategory()
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvCategory.SelectedRows[0];
                new employee().delete(Int32.Parse(r.Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Select row to delete");
        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            DeleteShipper();
        }

        private void DeleteShipper()
        {
            if (dgvShipper.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvShipper.SelectedRows[0];
                new employee().delete(Int32.Parse(r.Cells[0].Value.ToString()));
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
                list.Add(txtCusPhone.Text);
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



        #endregion

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProduct()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
            }
            else
                MessageBox.Show("Select row to update!");
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {

        }








    }
}
