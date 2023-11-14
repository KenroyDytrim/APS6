using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS6
{
    public partial class Form1 : Form
    {
        RealUser realUser = new RealUser();
        List<Proxy> proxies = new List<Proxy>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("config.txt");
            DataBank.server = lines[0];
            DataBank.userid = lines[1];
            DataBank.password = lines[2];
            DataBank.port = lines[3];
            DataBank.database = lines[4];

            string sql = "SELECT * FROM user_list ORDER BY id";
            DataTable dt = Records.LoadData(sql, "");

            for(int i=0; i < dt.Rows.Count; i++)
            {
                comboUsers.Items.Add(dt.Rows[i].ItemArray[1]);
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            int id=comboUsers.SelectedIndex+1;

            if (id != 0)
            {
                Info.Text = realUser.getInfo(id);    
            }
        }

        private void ViewProxy_Click(object sender, EventArgs e)
        {
            if(Info.Text != "") 
            {  
                int id = comboUsers.SelectedIndex + 1;
                Proxy buff = null;
                for (int i = 0; i < proxies.Count; i++) 
                {
                    if(proxies[i].idU == id)
                    {
                        buff = proxies[i];
                    }
                }
                if(buff != null && id != 0) 
                { 
                    ProxyInfo.Text = buff.getInfo(id);
                }
                else if(buff == null && id!=0)
                {
                    realUser.getInfo(id);
                    proxies.Add(new Proxy(realUser));
                    for (int i = 0; i < proxies.Count; i++)
                    {
                        if (proxies[i].idU == id)
                        {
                            buff = proxies[i];
                        }
                    }
                    ProxyInfo.Text = buff.getInfo(id);
                }
            }
            
        }

        private void CreateProxy_Click(object sender, EventArgs e)
        {
            if (comboUsers.SelectedIndex != -1 && Info.Text != "")
            {
                int id = comboUsers.SelectedIndex + 1;
                Proxy buff = null;
                for (int i = 0; i < proxies.Count; i++)
                {
                    if (proxies[i].idU == id)
                    {
                        buff = proxies[i];
                    }
                }
                if (buff == null)
                {
                    proxies.Add(new Proxy(realUser));
                    ProxyInfo.Text = "Прокси создан";
                }
                else
                {
                    buff.removeProxy();
                    buff.getInfo(id);
                    ProxyInfo.Text = "Прокси переписан";
                }
            }
        }
    }
}
