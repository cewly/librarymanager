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
    public partial class signupaction : Form
    {
        public signupaction()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)//转到登录页面
        {
            this.Close();
            loginaction login = new loginaction();
            login.Show();
        }

        private void signupButton_Click(object sender, EventArgs e)//注册用户
        {
            //调用数据库
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();

            //获取注册信息
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string number = numberBox.Text;
            Msqldatabase.Signupuser(username, password, number);

            //关闭数据库
            Msqldatabase.Closedatabase();
        }
    }
}
