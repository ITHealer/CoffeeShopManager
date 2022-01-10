using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class CategoryDAO
    {   
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set { CategoryDAO.instance = value; }
        }
        public CategoryDAO() { }

        //Hàm lấy danh sách Loại thức ăn;
        public List<Category> GetListCategory() ///lấy list Category load lên combobox;
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        //Hàm lấy danh sách Loại thức ăn theo id;
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from FoodCategory where id = " + id;
            //string query = string.Format("select * from FoodCategory where name = N'{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }


        //Begin Thêm sửa xóa;
        public bool InsertFoodCategory(string name)
        {
            string query = string.Format("INSERT dbo.FoodCategory ( name ) VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFoodCategory(int idCategory, string name)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {1}", name, idCategory);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFoodCategory(int idFoodCategory)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFoodCategory);

            string query = string.Format("Delete dbo.FoodCategory where id = {0}", idFoodCategory);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        
    }
}
