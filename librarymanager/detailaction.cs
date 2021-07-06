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

namespace librarymanager
{
    public partial class detailaction : Form
    {
        public detailaction(string number,int authority)
        {
            InitializeComponent();
            //导入数据库数据
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            //设置详情页面信息
            if (int.Parse(number)>=30000)
                {
                    setart();
                 }else
                { 
                   if (int.Parse(number)>=20000)
                     { setCD(); }
                   else 
                     { setbook(); }
                 }
            if (authority == 2)//限制用户修改权限
            {
                modifyButton.Enabled = false;
                nameBox.ReadOnly = true;
                numberBox.ReadOnly = true;
                levelBox.ReadOnly = true;
                authorBox.ReadOnly = true;
                typeBox.ReadOnly = true;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
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

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
