using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status, int discount)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut= dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"]; //vì nó trả về một object nên ta phải ép kiểu;
            this.DateCheckIn = (DateTime?)row["dateCheckin"]; //Datime? : ? cho phép nó null;
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "") 
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"];
            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
            //this.Discount = (int)row["discount"];
        }
        private int iD;
        private DateTime? dateCheckIn; //dấu chấm hỏi thêm vô cho phép null được;
        private DateTime? dateCheckOut;
        private int status;
        private int discount;
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
