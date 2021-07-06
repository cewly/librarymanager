﻿using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace sqlconnection
{
    public class Sqldatabase
    {
        public void Setdatabase()//连接sql库
        {
            connStr = "server = localhost; user = manager; database = library; port = 3306; password = 123456";
            conn = new MySqlConnection(connStr);
            try { conn.Open(); Console.WriteLine("SQL连接成功"); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }


        public void Closedatabase()//关闭sql库连接
        {
            try { conn.Close(); Console.WriteLine("SQL关闭成功"); }
            finally { }
        }

        public MySqlDataReader Listbook()//连接图书类数据库
        {
            string sql = "SELECT * from book ";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            return rdr;
        }
        public int Checkuser(string name,string password)//登录操作
        {
            string sql = "SELECT * from user where name=\"" + name + "\" and password=\"" + password + "\"";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            //判断权限返回相应参数
            if (rdr.Read())
            {
                if (rdr[2].ToString() == "1") 
                { rdr.Close(); return 1; }
                else 
                { rdr.Close(); return 2; }
            }else
            {
                rdr.Close();
                return 0;
            }

        }
        public void Signupuser(string username,string password,string number)//用户注册
        {
            try
            {
                string sql = "INSERT INTO user ( name , password , number,authority )VALUES( \"" + username + "\", \"" + password + "\", \"" + number + "\"," + "2)";//默认权限为普通用户
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("用户注册成功！");
            }
            catch
            {
                MessageBox.Show("用户注册失败！");
            }
        }
        private string connStr;
        private MySqlConnection conn;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;
    }
}
