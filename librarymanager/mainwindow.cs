using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlconnection;
using MySql.Data.MySqlClient;

namespace librarymanager
{
    public partial class mainwindow : Form
    {
        public mainwindow(int power)
        {
            InitializeComponent();
            authority = power;
            if (authority == 2)
            {
                this.addBookButton.Enabled=false;
            }
        }

        private void BookListButton_Click(object sender, EventArgs e)
        {
            //初始化图书列表
            this.listView.Columns.Clear();
            this.listView.Columns.Add("标题", 200, HorizontalAlignment.Center);
            this.listView.Columns.Add("编号", 80, HorizontalAlignment.Center);
            this.listView.Columns.Add("出版社", 120, HorizontalAlignment.Center);
            this.listView.Columns.Add("借阅情况", 100, HorizontalAlignment.Center);
            this.listView.Items.Clear();
            //导入数据库数据;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            MySqlDataReader rdr= Msqldatabase.Listbook();
            while(rdr.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = rdr[1].ToString();//设置第一行显示的数据
                //绑定剩余列的数据
                lv.SubItems.Add(rdr[0].ToString());
                lv.SubItems.Add(rdr[3].ToString());
                lv.SubItems.Add(rdr[6].ToString());
                //一定记得行数据创建完毕后添加到列表中
                listView.Items.Add(lv);
            }
            rdr.Close();
            Msqldatabase.Closedatabase();
        }

        private void DetailButton_Click(object sender, EventArgs e)//显示选中列表的详细信息
        {
            foreach (ListViewItem lv in listView.SelectedItems)
            {
                detailaction detail = new detailaction(lv.SubItems[1].Text);
            }
        }
        public int authority;

        private void switchuser_Click(object sender, EventArgs e)
        {
            loginaction login = new loginaction();
            login.Show();
            this.Close();
        }

        private void aboutappMenu_Click(object sender, EventArgs e)
        {
            aboutapp app = new aboutapp();
            app.Show();
        }
    }
}
