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
    public partial class loginaction : Form
    {
        public loginaction()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void loginButton_Click(object sender, EventArgs e)//登录
        {
            //调用数据库
            Sqldatabase Msqldatabase =new Sqldatabase();
            Msqldatabase.Setdatabase();
            //获取数据
            string username = this.usernameBox.Text;
            string password = this.passwordBox.Text;
            //验证数据
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else 
            {
                    int pw = Msqldatabase.Checkuser(username, password);
                    Console.WriteLine("权限为："+pw);
                    if (pw!=0)
                    {
                        MessageBox.Show("登录成功！");
                        mainwindow main = new mainwindow(pw);
                        this.Hide();
                    main.Show();
                    }
                    else
                    { 
                            MessageBox.Show("用户名或密码错误！");
                    }

            }
            //关闭数据库
            Msqldatabase.Closedatabase();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            signupaction signup = new signupaction();
            this.Hide();
            signup.Show();
        }

    }
}
