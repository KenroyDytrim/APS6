using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS6
{
    public class Records
    {
        public static string getConnectionString()
        {
            string connectionString = string.Format($"Server ={DataBank.server}; User Id = {DataBank.userid}; Password ={DataBank.password}; Port ={DataBank.port}; Database ={DataBank.database};");
            return connectionString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable Perform(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt); 
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
        public static DataTable LoadData(string sql, string keyword)
        {
            Records.sql = sql;
            string strKeyword = string.Format("%{0}%", keyword);
            Records.cmd = new NpgsqlCommand(Records.sql, Records.con);
            Records.cmd.Parameters.Clear();
            Records.cmd.Parameters.AddWithValue("keyword", strKeyword);
            DataTable dt = Records.Perform(Records.cmd);
            return dt;
        }
    }
}
