using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            private set { TableDAO.instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;

        private TableDAO() { }


        //Hàm chuyển bàn;
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        public void GopBan(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_GopBan @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public bool InsertTableFood(string name, string status)
        {
            string query = string.Format("INSERT dbo.TableFood ( name, status )VALUES  ( N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTableFood(int idTableFood, string name, string status)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}', status = N'{1}' WHERE id = {2}", name, status, idTableFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTableFood(int idTableFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idTableFood);

            string query = string.Format("Delete dbo.TableFood where id = {0}", idTableFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
