using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sqlconnection;


namespace librarymanager
{
    public partial class addaction : Form
    {
        private int leftbook;
        private int leftart;
        private int leftCD;
        public addaction(int book,int CD,int art)
        {
            InitializeComponent();
            leftbook = book;
            leftCD = CD;
            leftart = art;
        }

        private void bookRButton_CheckedChanged(object sender, EventArgs e)
        {
            setbook();
            if (leftbook == 0) { button1.Enabled = false; MessageBox.Show("图书库已满!"); }
        }

        private void CDRButton_CheckedChanged(object sender, EventArgs e)
        {
            setCD();
            if (leftbook == 0) { button1.Enabled = false; MessageBox.Show("视频光盘库已满!"); }
        }

        private void artRButton_CheckedChanged(object sender, EventArgs e)
        {
            setart();
            if (leftbook == 0) { button1.Enabled = false; MessageBox.Show("图画库已满!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookRButton.Checked == true)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                if (Msqldatabase.bookadd(numberBox.Text,nameBox.Text,authorBox.Text,levelBox.Text,textBox1.Text,textBox2.Text,textBox3.Text) == 1 ||int.Parse(numberBox.Text)>=20000) { MessageBox.Show("该编码已存在或不合法！"); }
                Msqldatabase.Closedatabase();
                this.Close();
            }
            if (artRButton.Checked == true)
            {
                Sqldatabase Msqldatabase = new Sqldatabase();
                Msqldatabase.Setdatabase();
                if (Msqldatabase.artadd(numberBox.Text, nameBox.Text, authorBox.Text, levelBox.Text, textBox1.Text, textBox2.Text) == 1 || int.Parse(numberBox.Text) >= 30000 || int.Parse(numberBox.Text) < 20000) { MessageBox.Show("该编码已存在或不合法！"); }
                Msqldatabase.Closedatabase();
                this.Close();
            }
            if (CDRButton.Checked == true)
            {
                 Sqldatabase Msqldatabase = new Sqldatabase();
                 Msqldatabase.Setdatabase();
                if (Msqldatabase.CDadd(numberBox.Text, nameBox.Text, authorBox.Text, levelBox.Text, textBox1.Text, textBox2.Text, textBox3.Text) == 1 || int.Parse(numberBox.Text) < 30000) { MessageBox.Show("该编码已存在或不合法！"); }
                Msqldatabase.Closedatabase();
                this.Close();
            }
        }
        public void setbook()
        {
            button1.Enabled = true;
            label3.Show();
            textBox3.Show();
            label1.Text = "出版社:";
            label2.Text = "ISBN号:";
            label3.Text = "页数:";
        }
        public void setCD()
        {
            button1.Enabled = true;
            label3.Show();
            textBox3.Show();
            label1.Text = "出品者:";
            label2.Text = "出品年份:";
            label3.Text = "视频时长:";
        }
        public void setart()
        {
            button1.Enabled = true;
            label1.Text = "出品国籍:";
            label2.Text = "长和宽:";
            label3.Hide();
            textBox3.Hide();
        }


    }
}
