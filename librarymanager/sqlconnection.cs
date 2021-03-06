using System;
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
            Console.WriteLine("图书库数据读取成功");
            return rdr;
        }

        public MySqlDataReader ListCD()//连接光盘类数据库
        {
            string sql = "SELECT * from CD ";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            Console.WriteLine("CD库数据读取成功");
            return rdr;
            
        }

        public MySqlDataReader Listart()//连接图画类数据库
        {
            string sql = "SELECT * from art";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            Console.WriteLine("CD库数据读取成功");
            return rdr;
        }

        public MySqlDataReader numbersearch(string number)//根据编号查找数据
        {
            //Console.WriteLine(number);
            if (int.Parse(number) >= 30000)
            {
                string sql = "SELECT * from art where id = "+number;
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            else
            {
                if (int.Parse(number) >= 20000)
                {
                    string sql = "SELECT * from cd where id = " + number;
                    cmd = new MySqlCommand(sql, conn);
                    rdr = cmd.ExecuteReader();
                    return rdr;
                }
                else
                {
                    string sql = "SELECT * from book where id = " + number;
                    cmd = new MySqlCommand(sql, conn);
                    rdr = cmd.ExecuteReader();
                    return rdr;
                }
            }
        }

        public MySqlDataReader namesearch(string name)//根据标题查询
        {
            string sql = "SELECT id from id_name where name = \"" + name+"\"";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string number = rdr[0].ToString();
            rdr.Close();
            rdr = numbersearch(number);
            return rdr;
        }

        public MySqlDataReader typesearch(string type)//根据类型查询
        {
            if (type == "图书") { rdr = Listbook(); }
            if (type == "图画") { rdr = Listart(); }
            if (type == "视频光盘") { rdr = ListCD(); }
            return rdr;
        }
        public void deletedata(string number)//数据删除操作
        {
            string sql;
            if (int.Parse(number) >= 30000)
            {
                sql = "DELETE FROM art WHERE id ="+number;
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                if (int.Parse(number) >= 20000)
                {
                    sql = "DELETE FROM cd WHERE id =" + number;
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    sql = "DELETE FROM book WHERE id =" + number;
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            sql = "DELETE FROM id_name WHERE id =" + number;
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
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
        public int bookadd(string id,string name,string author,string level,string publisher,string ISBN,string page)//添加图书
        {
            rdr = numbersearch(id);
            if (rdr.Read()) { rdr.Close(); return 1; }
            rdr.Close();
            string sql = "INSERT INTO book ( id,name,author,level,publisher,ISBN,page )VALUES( "+id+", \"" + name + "\", \"" + author + "\", \"" + level + "\",\"" +publisher+ "\",\""+ISBN+ "\","+page +")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "INSERT INTO id_name (id,name) values ("+ id +",\""+name+"\")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            return 0;
        }
        public int CDadd(string id, string name, string author, string level, string publisher, string year, string time)//添加视频光盘
        {
            rdr = numbersearch(id);
            if (rdr.Read()) { rdr.Close(); return 1; }
            rdr.Close();
            string sql = "INSERT INTO cd ( id,name,author,level,publisher,year,time )VALUES( " + id + ", \"" + name + "\", \"" + author + "\", \"" + level + "\",\"" + publisher + "\",\"" + year+ "\",\"" + time + "\")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "INSERT INTO id_name (id,name) values (" + id + ",\"" + name + "\")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            return 0;
        }
        public int artadd(string id, string name, string author, string level, string country, string size)//添加图画类
        {
            rdr = numbersearch(id);
            if (rdr.Read()) { rdr.Close(); return 1; }
            rdr.Close();          
            string sql = "INSERT INTO art ( id,name,author,level,country,size )VALUES( " + id + ", \"" + name + "\", \"" + author + "\", \"" + level + "\",\"" + country + "\",\"" + size + "\")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "INSERT INTO id_name (id,name) values (" + id + ",\"" + name + "\")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            return 0;
        }

        public void bookupdata(string id,string author, string level, string publisher, string ISBN, string page)
        {
            string sql = "UPDATE book set author=\""+author+"\", level=\""+level+"\",publisher=\""+publisher+"\",ISBN=\""+ISBN+"\",page=\""+page+"\" where id="+id;
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void CDupdata(string id, string author, string level, string publisher, string year, string time)
        {
            string sql = "UPDATE CD set author=\"" + author + "\", level=\"" + level + "\",publisher=\"" + publisher + "\",year=\"" + year+ "\",time=\"" + time + "\" where id=" + id;
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void artupdata(string id, string author, string level, string country, string size)
        {
            string sql = "UPDATE art set author=\"" + author + "\", level=\"" + level + "\",country=\"" + country + "\",size=\"" + size+ "\" where id=" + id;
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public int searchtotal(string table)
        {
            string number;
            string sql = "SELECT count(*) from "+table;
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            number = rdr[0].ToString();
            rdr.Close();
            return int.Parse(number); 
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
