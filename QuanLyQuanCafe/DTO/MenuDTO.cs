using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MenuDTO
    {
        public MenuDTO(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public MenuDTO(DataRow row)
        {
            this.FoodName = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
