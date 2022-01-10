using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        //Để khi nhấn nút Xem không lỗi khi dữ liệu thay đổi nó vẫn binding đc hạn chế việc mất kết nối binding; 
        BindingSource foodList = new BindingSource();
        BindingSource foodCategoryList = new BindingSource();
        BindingSource tableFoodList = new BindingSource();

        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();

            Load();
        }

        #region methods
        //hàm để load một lần cho tiện của cả Form;
        void Load()
        {
            dtgvFood.DataSource = foodList; //tag thức ăn;
            dtgvCategory.DataSource = foodCategoryList; //tag danh mục;
            dtgvTableFood.DataSource = tableFoodList; //tag bàn ăn;
            dtgvAccount.DataSource = accountList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

            LoadListFood();
            LoadCategoryIntoCombobox(cbbFoodCategory);
            AddFoodBinding();

            LoadListFoodCategory();
            AddFoodCategoryBinding();

            LoadListTableFood();
            AddTableFoodBinding();

            LoadAccount();
            AddAccountBinding();
        }
        //Begin load TK;
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccountBinding()
        {
            tbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            tbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        //Thêm, sửa, xóa Account;
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn!");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        //Begin Load data bên Tag Doanh Thu;
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        //End tag Doanh thu;

        //Begin Load data bên Tag Thức Ăn;
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            //Mỗi khi cập nhật dữ liệu chỉ cần cập nhật lại binding source này thôi thay vì đi cập nhật lại datagridview
        }
        //Hàm tìm kiếm thức ăn theo tên;
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        void AddFoodBinding()
        {
            tbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            //true thì gs một bên là chuỗi một bên là số nó sẽ tự động ép kiểu, DSUM.Never là không cho thay đổi 
            //tức chỉ đi theo một luồng duy nhất;
            tbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            //cbbFoodCategory.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "CategoryID"));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        //Hàm Load combobox lên để tùy chọn k Binding vì để thuận tiện cho việc thêm xóa sửa bên Tag Thức ăn;
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        //End Tag Thức ăn;

        //Begin Load Danh mục;
        void LoadListFoodCategory()
        {
            foodCategoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddFoodCategoryBinding()
        {
            tbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        //Begin load Bàn ăn;
        void LoadListTableFood()
        {
            tableFoodList.DataSource = TableDAO.Instance.LoadTableList();
        }
        void AddTableFoodBinding()
        {
            tbTableID.DataBindings.Add(new Binding("Text", dtgvTableFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbTableName.DataBindings.Add(new Binding("Text", dtgvTableFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            cbTableStatus.DataBindings.Add(new Binding("Text", dtgvTableFood.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        
        #endregion

        #region events
        //Begin tag Doanh thu;
        //Click vào Thông kê để xem thông tin trong vòng bao nhiêu ngày;
        private void btnViewBill_Click_1(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        //End tag Daonh thu;

        //Begin tag Thức ăn
        //Để xem thông tin bên Tà thức ăn khi Click vào Xem;
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void tbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0) //Cách lấy dữ liệu từ dtgv ra:
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    //Khi chọn một ô bất kỳ trên dataGridView đó (SelectedCells[0] => chọn đc nhiều cell
                    //là danh sách những cái ô mà mình chọn mình lấy ra 1 ô đầu tiên trong ds SelectedCells[0] thôi sau đó
                    //OwningRow là lấy ra cái dòng đang chứa ô này SelectedCells[0] rồi lấy ra các ô 
                    //Cells["CategoryID"] của dòng OwningRow  là lấy ra cái tg có tên IDCategory)
                    //Cách lấy ra 1 Cell mà ta mong muốn trong datagridview.
                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbbFoodCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbbFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(tbSearchFoodName.Text);
        }
        private void btnAddFood_Click_1(object sender, EventArgs e)
        {
            string name = tbFoodName.Text;
            int categoryID = (cbbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private void btnEditFood_Click_1(object sender, EventArgs e)
        {
            string name = tbFoodName.Text;
            int categoryID = (cbbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(tbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        //End tag Thức ăn;

        //Begin tag Danh mục;
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = tbCategory.Text;
            if (CategoryDAO.Instance.InsertFoodCategory(name))
            {
                MessageBox.Show("Thêm loại thức ăn thành công");
                LoadListFoodCategory();
                if (insertFoodCategory != null)
                    insertFoodCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm loại thức ăn");
            }
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteFoodCategory(id))
            {
                MessageBox.Show("Xóa loại thức ăn thành công");
                LoadListFoodCategory();
                if (deleteFoodCategory != null)
                    deleteFoodCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa loại thức ăn");
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = tbCategory.Text;
            int id = Convert.ToInt32(tbCategoryID.Text);
            if (CategoryDAO.Instance.UpdateFoodCategory(id, name))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFoodCategory();
                if (updateFoodCategory != null)
                    updateFoodCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListFoodCategory();
        }

        private event EventHandler insertFoodCategory;
        public event EventHandler InsertFoodCategory
        {
            add { insertFoodCategory += value; }
            remove { insertFoodCategory -= value; }
        }

        private event EventHandler deleteFoodCategory;
        public event EventHandler DeleteFoodCategory
        {
            add { deleteFoodCategory += value; }
            remove { deleteFoodCategory -= value; }
        }

        private event EventHandler updateFoodCategory;
        public event EventHandler UpdateFoodCategory
        {
            add { updateFoodCategory += value; }
            remove { updateFoodCategory -= value; }
        }
        //End tag Danh mục;

        //Begin tag Bàn ăn;
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTableFood();
        }
        private void btnAddTable_Click_1(object sender, EventArgs e)
        {
            string name = tbTableName.Text;
            string status = cbTableStatus.Text;

            if (TableDAO.Instance.InsertTableFood(name, status))
            {
                MessageBox.Show("Thêm bàn ăn thành công");
                LoadListTableFood();
                if (insertTableFood != null)
                    insertTableFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn ăn");
            }
        }
        private void btnUpdateTable_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableID.Text);
            string name = tbTableName.Text;
            string status = cbTableStatus.Text;

            if (TableDAO.Instance.UpdateTableFood(id, name, status))
            {
                MessageBox.Show("Sửa bàn ăn thành công");
                LoadListTableFood();
                if (updateTableFood != null)
                    updateTableFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn ăn");
            }
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableID.Text);
           
            if (TableDAO.Instance.DeleteTableFood(id))
            {
                MessageBox.Show("Xóa bàn ăn thành công");
                LoadListTableFood();
                if (deleteTableFood != null)
                    deleteTableFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private event EventHandler insertTableFood;
        public event EventHandler InsertTableFood
        {
            add { insertTableFood += value; }
            remove { insertTableFood -= value; }
        }

        private event EventHandler deleteTableFood;
        public event EventHandler DeleteTableFood
        {
            add { deleteTableFood += value; }
            remove { deleteTableFood -= value; }
        }

        private event EventHandler updateTableFood;
        public event EventHandler UpdateTableFood
        {
            add { updateTableFood += value; }
            remove { updateTableFood -= value; }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string displayName = tbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;

            DeleteAccount(userName);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string displayName = tbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;

            ResetPass(userName);
        }
        
        //Tạo pageBill;
        private void btnFirstBillPage_Click(object sender, EventArgs e)
        {
            tbPageBill.Text = "1";
        }

        private void btnLastBillPage_Click_1(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
                lastPage++;

            tbPageBill.Text = lastPage.ToString();
        }

        private void tbPageBill_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(tbPageBill.Text));
        }

        private void btnPrevioursBillPage_Click_1(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(tbPageBill.Text);

            if (page > 1)
                page--;

            tbPageBill.Text = page.ToString();
        }

        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(tbPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            if (page < sumRecord)
                page++;

            tbPageBill.Text = page.ToString();
        }
    }
    #endregion

}
