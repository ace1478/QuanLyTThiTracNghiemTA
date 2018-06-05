using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class Account
    {

        public Account()
        {
            this.id = 0;
            this.UserName = null;
            this.Password = null;
            this.Hovaten = null;
            this.Email = null;
           
            this.id_LoaiTV = 0;

        }
        public Account(DataRow row)
        {
            this.id = (int)row["Id"];
            this.UserName = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.Hovaten = row["Hovaten"].ToString();
            this.Email = row["Email"].ToString();
           
            this.id_LoaiTV = (int)row["id_LoaiTV"];
        }
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        

        public string Hovaten { get; set; }
        public string Email { get; set; }
        public int id_LoaiTV { get; set; }


    }
}
