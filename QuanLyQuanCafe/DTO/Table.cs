using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{

    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.status = status;
        }
        public Table (DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private string status;
        public string Status { get => status; set => status = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private int iD;

        public int ID { get => iD; set => iD = value; }
    }
}
