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
using Spire.Xls;

namespace librarymanager
{
    public partial class mainwindow : Form
    {
        private MySqlDataReader rdr;
        public mainwindow(int power)
        {
            InitializeComponent();
            authority = power;
            if (authority == 2)
            {
                this.addBookButton.Enabled = false;
                this.deleteButton.Enabled = false;
                this.deleteBox.ReadOnly = true;
            }
            //初始化列表
            this.listView.Columns.Clear();
            this.listView.Columns.Add("标题", 200, HorizontalAlignment.Center);
            this.listView.Columns.Add("编号", 80, HorizontalAlignment.Center);
            this.listView.Columns.Add("作者", 80, HorizontalAlignment.Center);
            this.listView.Columns.Add("评级", 80, HorizontalAlignment.Center);
           //this.listView.Columns.Add("借阅情况", 100, HorizontalAlignment.Center);
            this.listView.Items.Clear();
        }

        private void BookListButton_Click(object sender, EventArgs e)
        {
            this.listView.Items.Clear();
            //导入数据库数据;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            rdr = Msqldatabase.Listbook();
            while (rdr.Read())
            {
                printtoscreen();
            }
            rdr.Close();
            Msqldatabase.Closedatabase();
        }

        private void CDListButton_Click(object sender, EventArgs e)
        {
            this.listView.Items.Clear();
            //导入数据库数据;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            rdr = Msqldatabase.ListCD();
            while (rdr.Read())
            {
                printtoscreen();
            }
            rdr.Close();
            Msqldatabase.Closedatabase();
        }

        private void ArtListButton_Click(object sender, EventArgs e)
        {
            this.listView.Items.Clear();
            //导入数据库数据;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            rdr = Msqldatabase.Listart();
            while (rdr.Read())
            {
                printtoscreen();
            }
            rdr.Close();
            Msqldatabase.Closedatabase();
        }

        private void DetailButton_Click(object sender, EventArgs e)//显示选中列表的详细信息
        {
            foreach (ListViewItem lv in listView.SelectedItems)
            {
                detailaction detail = new detailaction(lv.SubItems[1].Text,authority);
                detail.Show();
            }
        }       
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

        public int authority;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool bz = false;
            if (numberRButton.Checked == true)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                rdr = Msqldatabase.numbersearch(SearchBox.Text);
                this.listView.Items.Clear();
                while (rdr.Read())
                {
                    printtoscreen();
                    bz = true;
                }
                rdr.Close();
                Msqldatabase.Closedatabase();
                if (!bz) { MessageBox.Show("该编号不存在！"); }
            }
            if (titalRButton.Checked == true)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                rdr = Msqldatabase.namesearch(SearchBox.Text);
                this.listView.Items.Clear();
                while (rdr.Read())
                {
                    printtoscreen();
                    bz = true;
                }
                rdr.Close();
                Msqldatabase.Closedatabase();
                if (!bz) { MessageBox.Show("该标题不存在！"); }
            }
            if (typeRButton.Checked == true)
            {if (SearchBox.Text == "图书" || SearchBox.Text == "图画" || SearchBox.Text == "视频光盘")
                {
                    Sqldatabase Msqldatabase = new Sqldatabase();
                    Msqldatabase.Setdatabase();
                    rdr = Msqldatabase.typesearch(SearchBox.Text);
                    this.listView.Items.Clear();
                    while (rdr.Read())
                    {
                        printtoscreen();
                        bz = true;
                    }
                    rdr.Close();
                    Msqldatabase.Closedatabase();
                }
                if (!bz) { MessageBox.Show("该类别没有物品！"); }
            }
        }
        public void printtoscreen()
        {
            ListViewItem lv = new ListViewItem();
            lv.Text = rdr[1].ToString();//设置第一行显示的数据
                                        //绑定剩余列的数据
            lv.SubItems.Add(rdr[0].ToString());
            lv.SubItems.Add(rdr[2].ToString());
            lv.SubItems.Add(rdr[3].ToString());
            //lv.SubItems.Add(rdr[4].ToString());
            //一定记得行数据创建完毕后添加到列表中
            listView.Items.Add(lv);
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            Mupdata();
            if (total == MAXTOTAL)
            {
                MessageBox.Show("数据库已满!");
            }
            else
            {
                addaction add = new addaction(MAXBOOK - book, MAXCD - CD,MAXART-art) ;
                add.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Mupdata();
            if (total == 0)
            {
                MessageBox.Show("数据库为空!");
            }
            else
            {
                if (IsNumber(deleteBox.Text) == true)
                {
                    Sqldatabase Msqldatabase = new Sqldatabase();
                    Msqldatabase.Setdatabase();
                    rdr = Msqldatabase.numbersearch(deleteBox.Text);
                    if (rdr.Read())
                    {
                        try
                        {
                            Msqldatabase.deletedata(deleteBox.Text);
                            MessageBox.Show("删除成功!");
                        }
                        catch
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该编号不存在!");
                    }
                    Msqldatabase.Closedatabase();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请输入编号！");
                    deleteBox.Clear();
                }
            }
        }

        private void deleteBox_TextChanged(object sender, EventArgs e)
        {

        }
        public  bool IsNumber(string str)
        {
            if (str == null || str.Length == 0)    //验证这个参数是否为空
                return false;                           //是，就返回False
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例
            byte[] bytestr = ascii.GetBytes(str);         //把string类型的参数保存到数组里

            foreach (byte c in bytestr)                   //遍历这个数组里的内容
            {
                if (c < 48 || c > 57)                          //判断是否为数字
                {
                    return false;                              //不是，就返回False
                }
            }
            return true;                                        //是，就返回True
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            Mupdata();
            MessageBox.Show("图书: "+book+"/"+MAXBOOK+"\n光盘: " + CD + "/" + MAXCD + "\n图画: " + art + "/" + MAXART + "\n总库存: " + total + "/" + MAXTOTAL);
            this.listView.Items.Clear();
            //导入数据库数据;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            rdr = Msqldatabase.Listbook();
            while (rdr.Read())
            {
                printtoscreen();
            }
            rdr.Close();
            rdr = Msqldatabase.ListCD();
            while (rdr.Read())
            {
                printtoscreen();
            }
            rdr.Close();
            rdr = Msqldatabase.Listart();
            while (rdr.Read())
            {
                printtoscreen();
            }
            rdr.Close();
            Msqldatabase.Closedatabase();

        }
        public void Mupdata()
        {
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            book = Msqldatabase.searchtotal("book");
            art = Msqldatabase.searchtotal("art");
            CD = Msqldatabase.searchtotal("CD");
            total = book + art + CD;
            Msqldatabase.Closedatabase();
        }
        private int book;
        private int art;
        private int CD;
        private int total;
        private const int MAXTOTAL = 9;
        private const int MAXCD = 3;
        private const int MAXART = 3;
        private const int MAXBOOK = 3;

        private void UserMenu_Click(object sender, EventArgs e)
        {

        }

        private void loadinmenu_Click(object sender, EventArgs e)
        {
            Mupdata();
            excelaction excel = new excelaction();
            int bz= excel.readexcel(MAXBOOK - book, MAXCD - CD, MAXART - art);
            if(bz==1)
            {
                MessageBox.Show("库存已满或存在重复编号！");
            }
            else
            {
                MessageBox.Show("导入成功！");
            }
        }

        private void loadoutmenu_Click(object sender, EventArgs e)
        {
            excelaction excel = new excelaction();
            excel.createxcel();
            MessageBox.Show("导出成功！");
        }
    }
}
