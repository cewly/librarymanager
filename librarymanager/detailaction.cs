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
        public detailaction(string number)
        {
            InitializeComponent();
            //设置详情页面信息
            if(int.Parse(number)>=30000)
                {
                    setart();
                 }else
                { 
                   if (int.Parse(number)>=20000)
                     { setCD(); }
                   else 
                     { setbook(); }
                 }
            //导入数据库数据
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
        }
        public void setbook()
        {

        }
        public void setCD()
        {

        }
        public void setart()
        {

        }
        private void detailaction_Load(object sender, EventArgs e)
        {

        }
    }
}
