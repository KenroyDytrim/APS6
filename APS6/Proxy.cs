using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS6
{
    public interface User
    {
        string getInfo(int id);
    }
    class RealUser : User
    {
        public int idU = -1;
        public string getInfo(int id)
        {
            idU = id;
            string sql = $"SELECT * FROM user_list WHERE id={id}";
            DataTable dt = Records.LoadData(sql, "");
            string str = "Информация" + "\n" + "Логин: " + dt.Rows[0].ItemArray[1].ToString() + "\n" + "Email: " + dt.Rows[0].ItemArray[2].ToString();
            return (str);
        }   
    }
    class Proxy : User
    {
        private RealUser _realUser;
        private string UserInfo = null;
        public int idU = -1;
        public Proxy(RealUser realUser)
        {
            this._realUser = realUser;
            this.idU = realUser.idU;
        }
        public string getInfo(int id)
        {
            if (this.UserInfo != null)
            {
                return this.UserInfo;
            }
            else
            {
                idU = id;
                UserInfo = this._realUser.getInfo(id);
                return UserInfo;
            }
        }
        public void removeProxy()
        {
            this.UserInfo = null;
        }

    }
}
