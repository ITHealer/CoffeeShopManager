using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        //Hàm dựng để truyền dữ liệu;
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            Load();
        }

        #region Method
        //Hàm để load một lần cho tiện của cả Form;
        void Load()
        {
            loadTable();
            LoadCategory();
            LoadComboboxTableSwitchTable(cbbSwitchTable);
            LoadComboboxTableGopBan(cbbGopBan);
        }

        //Hàm Load data cho Thông tin tài khoản;
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1; //Nếu khác 1 thì không phải Admin thì nút Admin sẽ không cho phép User sử dụng;
            MnInfo.Text += " (" + LoginAccount.DisplayName + ")"; //Hiển thị tên hiển thị của TK tại mục Thông tin cá nhân;
            thôngTinToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")"; //Hiển thị tên hiển thị của TK tại mục Thông tin TK;
            lbUser.Text += "" + LoginAccount.DisplayName + ""; //Hiển thị tên hiển thị của TK tại mục Lable Chào Mừng;
        }
        //Hàm Load danh sách Loại thức ăn lên Combobox (chỉ load Name);
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "Name";
        }

        //Hàm Load danh sách thức ăn theo id của loại thức ăn truyền vào;
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbbFood.DataSource = listFood;
            cbbFood.DisplayMember = "Name";
        }
        
        //Hàm Load Bàn ăn hiển thị các trạng thái Bàn;
        void loadTable()  
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status; //Environment.NewLine == \n;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Lavender;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        //Hàm hiển thị Bill lên ListView với các trường và format cho kiểu hiển thị tổng tiền;
        void ShowBill(int id)
        {
            lsvTable.Items.Clear();
            List<QuanLyQuanCafe.DTO.MenuDTO> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyQuanCafe.DTO.MenuDTO item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvTable.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN"); //format cho gia trị tiền tệ; en- kiểu đa ngôn ngữ
            //Thread.CurrentThread.CurrentCulture = culture; //chỉ thay đổi định dạng tại ctrinh nay chứ k phải đổi ở máy, setting lại cái luồng đang chạyđể nó chuyển thành culture này
            tbTotalPrice.Text = totalPrice.ToString("c", culture); //tức chỉ có tg này nó chuyển thành culture mình muốn k ảnh hưởng gì đến thread
        }

        void LoadComboboxTableSwitchTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        void LoadComboboxTableGopBan(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Events
        //Hàm khi Click vào Bàn nào sẽ thực hiện các lệnh như bên trong;
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvTable.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void MnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnInfo_Click(object sender, EventArgs e)
        {
            fAccountProfile fTTCN = new fAccountProfile(loginAccount);
            fTTCN.UpdateAccount += fTTCN_UpdateAccount;
            this.Hide();
            fTTCN.ShowDialog();
            this.Show();
        }
        //Hàm Up date lại TK sau khi cập nhật thông tin TK mà không cần đăng xuất;
        void fTTCN_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
            MnInfo.Text = "Thông tin cá nhân (" + e.Acc.DisplayName + ")";
            lbUser.Text = e.Acc.DisplayName;
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAd = new fAdmin();

            fAd.loginAccount = LoginAccount;

            fAd.InsertFood += fAd_InsertFood;
            fAd.DeleteFood += fAd_DeleteFood;
            fAd.UpdateFood += fAd_UpdateFood;

            fAd.InsertFoodCategory += fAd_InsertFoodCategory;
            fAd.DeleteFoodCategory += fAd_DeleteFoodCategory;
            fAd.UpdateFoodCategory += fAd_UpdateFoodCategory;

            fAd.InsertTableFood += fAd_InsertTableFood;
            fAd.DeleteTableFood += fAd_DeleteTableFood;
            fAd.UpdateTableFood += fAd_UpdateTableFood;

            fAd.ShowDialog();
        }
        
        //Begin tag Bàn ăn;
        private void fAd_DeleteTableFood(object sender, EventArgs e)
        {
            loadTable();
        }

        private void fAd_UpdateTableFood(object sender, EventArgs e)
        {
            loadTable();
        }

        private void fAd_InsertTableFood(object sender, EventArgs e)
        {
            loadTable();
        }
        //End tag Bàn ăn;

        //Begin tag Category
        private void fAd_InsertFoodCategory(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodListByCategoryID((cbbCategory.SelectedItem as Category).ID);
            if (lsvTable.Tag != null)
                ShowBill((lsvTable.Tag as Table).ID);
        }

        private void fAd_UpdateFoodCategory(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodListByCategoryID((cbbCategory.SelectedItem as Category).ID);
            if (lsvTable.Tag != null)
                ShowBill((lsvTable.Tag as Table).ID);
        }

        private void fAd_DeleteFoodCategory(object sender, EventArgs e)
        {
            //LoadCategory();
            LoadFoodListByCategoryID((cbbCategory.SelectedItem as Category).ID);
            if (lsvTable.Tag != null)
                ShowBill((lsvTable.Tag as Table).ID);
            loadTable();
        }
        //End tag Category

        //Begin tag Thức ăn;
        void fAd_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbbCategory.SelectedItem as Category).ID);
            if (lsvTable.Tag != null)
                ShowBill((lsvTable.Tag as Table).ID);
        }

        void fAd_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbbCategory.SelectedItem as Category).ID);
            if (lsvTable.Tag != null)
                ShowBill((lsvTable.Tag as Table).ID);
            loadTable();
        }

        void fAd_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbbCategory.SelectedItem as Category).ID);
            if (lsvTable.Tag != null)
                ShowBill((lsvTable.Tag as Table).ID);
        }
        //End tag Thức ăn;

        //Hàm xd vị trí thay đổi của Loại thức ăn để từ đó load lại danh sách thức ăn có trong Loại thức ăn;;
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        //Hàm thêm món ăn;
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvTable.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            loadTable();
        }

        //Hàm sẽ cập nhật ngày CheckOut sau đó hiển thị Dialog Tổng tiền nếu chấp nhận thanh toán nhấn OK;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvTable.Tag as Table; //để lấy dữ liệu từ cái lsvTable;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(tbTotalPrice.Text.Split(',')[0].Replace(".", ""));
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    loadTable();
                }
            }
        }

        //Hàm thực hiện việc chuyển bàn;
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvTable.Tag as Table).ID;

            int id2 = (cbbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvTable.Tag as Table).Name, (cbbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                loadTable();
            }
        }
        private void btnGopBan_Click(object sender, EventArgs e)
        {
            int id1 = (lsvTable.Tag as Table).ID;

            int id2 = (cbbGopBan.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn gộp bàn {0} qua bàn {1}", (lsvTable.Tag as Table).Name, (cbbGopBan.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.GopBan(id1, id2);

                loadTable();
            }
        }

        #endregion

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        
    }
    //sender là cái tg gửi event và cái EventArg chính là cái paramater
}
