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
    public partial class detailaction : Form
    {
        private int id;
        public detailaction(string number, int authority)
        {
            InitializeComponent();
            //导入数据库数据
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            MySqlDataReader rdr = Msqldatabase.numbersearch(number);
            rdr.Read();
            //设置详情页面信息
            if (int.Parse(number) >= 30000)
            {
                nameBox.Text = rdr[1].ToString();
                numberBox.Text = rdr[0].ToString();
                authorBox.Text = rdr[2].ToString();
                levelBox.Text = rdr[3].ToString();
                borrowBox.Text = rdr[4].ToString();
                textBox1.Text = rdr[5].ToString();
                textBox2.Text = rdr[6].ToString();
                setart();
            }
            else
            {
                if (int.Parse(number) >= 20000)
                {
                    nameBox.Text = rdr[1].ToString();
                    numberBox.Text = rdr[0].ToString();
                    authorBox.Text = rdr[2].ToString();
                    levelBox.Text = rdr[3].ToString();
                    borrowBox.Text = rdr[4].ToString();
                    textBox1.Text = rdr[5].ToString();
                    textBox2.Text = rdr[6].ToString();
                    textBox3.Text = rdr[7].ToString();
                    setCD();
                }
                else
                {
                    nameBox.Text = rdr[1].ToString();
                    numberBox.Text = rdr[0].ToString();
                    authorBox.Text = rdr[2].ToString();
                    levelBox.Text = rdr[3].ToString();
                    borrowBox.Text = rdr[4].ToString();
                    textBox1.Text = rdr[5].ToString();
                    textBox2.Text = rdr[6].ToString();
                    textBox3.Text = rdr[7].ToString();
                    setbook();
                }
            }
            rdr.Close();
            Msqldatabase.Closedatabase();
            nameBox.ReadOnly = true;
            numberBox.ReadOnly = true;
            id = int.Parse(numberBox.Text);
            if (authority == 2)//限制用户修改权限
            {
                deleteButton.Enabled = false;
                modifyButton.Enabled = false;
                levelBox.ReadOnly = true;
                authorBox.ReadOnly = true;
                borrowBox.ReadOnly = true;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
           
            borrow.Hide();
            borrowBox.Hide();
        }
            public void setbook()
        {
            label1.Text = "出版社:";
            label2.Text = "ISBN号:";
            label3.Text = "页数:";
        }
        public void setCD()
        {
            label1.Text = "出品者:";
            label2.Text = "出品年份:";
            label3.Text = "视频时长:";
        }
        public void setart()
        {
            label1.Text = "出品国籍:";
            label2.Text = "长和宽:";
            label3.Hide();
            textBox3.Hide();
        }
        private void detailaction_Load(object sender, EventArgs e)
        {

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            try
            {
                Msqldatabase.deletedata(numberBox.Text);
                MessageBox.Show("删除成功!");
            }
            catch
            {
                MessageBox.Show("删除失败!");
            }
            Msqldatabase.Closedatabase();
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (id<20000)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                Msqldatabase.bookupdata(numberBox.Text, authorBox.Text, levelBox.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("修改成功!");
                Msqldatabase.Closedatabase();
                this.Close();
            }
            if (id >= 30000)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                Msqldatabase.artupdata(numberBox.Text, authorBox.Text, levelBox.Text, textBox1.Text, textBox2.Text);
                MessageBox.Show("修改成功!");
                Msqldatabase.Closedatabase();
                this.Close();
            }

            if (id >=20000 && id <=30000)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                Msqldatabase.CDupdata( numberBox.Text, authorBox.Text, levelBox.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("修改成功!");
                Msqldatabase.Closedatabase();
                this.Close();
            }
        }
    }
}
