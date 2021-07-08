using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
using MySql.Data.MySqlClient;
using sqlconnection;

namespace librarymanager
{
    class excelaction
    {
        private MySqlDataReader rdr;
        public void createxcel()
        {
            //创建1个工作簿，相当于1个Excel文件　　　　　　　　 //Excel的文档结构是 Workbook->Worksheet（1个book可以包含多个sheet）
            Workbook workbook = new Workbook();

            //获取第一个sheet，进行操作，下标是从0开始
            Worksheet sheet = workbook.Worksheets[0];
            Worksheet sheet1 = workbook.Worksheets[1];
            Worksheet sheet2 = workbook.Worksheets[2];

            //change sheet name
            sheet.Name = "图书";
            sheet1.Name = "视频光盘";
            sheet2.Name = "图画";

            //向A1单元格写入文字
            sheet.Range["A1"].Text = "编号";
            sheet.Range["B1"].Text = "标题";
            sheet.Range["C1"].Text = "作者";
            sheet.Range["D1"].Text = "评级";
            sheet.Range["E1"].Text = "出版社";
            sheet.Range["F1"].Text = "ISBN号";
            sheet.Range["G1"].Text = "页数";

            sheet1.Range["A1"].Text = "编号";
            sheet1.Range["B1"].Text = "标题";
            sheet1.Range["C1"].Text = "作者";
            sheet1.Range["D1"].Text = "评级";
            sheet1.Range["E1"].Text = "出品者";
            sheet1.Range["F1"].Text = "出品年份";
            sheet1.Range["G1"].Text = "视频时长";

            sheet2.Range["A1"].Text = "编号";
            sheet2.Range["B1"].Text = "标题";
            sheet2.Range["C1"].Text = "作者";
            sheet2.Range["D1"].Text = "评级";
            sheet2.Range["E1"].Text = "出品国籍";
            sheet2.Range["F1"].Text = "作品长宽";

            int count = 2;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            rdr = Msqldatabase.Listbook();
            while (rdr.Read())
            {
                sheet.Range["A" + count.ToString()].Text = rdr[0].ToString();
                sheet.Range["B" + count.ToString()].Text = rdr[1].ToString();
                sheet.Range["C" + count.ToString()].Text = rdr[2].ToString();
                sheet.Range["D" + count.ToString()].Text = rdr[3].ToString();
                sheet.Range["E" + count.ToString()].Text = rdr[5].ToString();
                sheet.Range["F" + count.ToString()].Text = rdr[6].ToString();
                sheet.Range["G" + count.ToString()].Text = rdr[7].ToString();
                count++;
            }
            rdr.Close();
            count = 2;
            rdr = Msqldatabase.ListCD();
            while (rdr.Read())
            {
                sheet1.Range["A" + count.ToString()].Text = rdr[0].ToString();
                sheet1.Range["B" + count.ToString()].Text = rdr[1].ToString();
                sheet1.Range["C" + count.ToString()].Text = rdr[2].ToString();
                sheet1.Range["D" + count.ToString()].Text = rdr[3].ToString();
                sheet1.Range["E" + count.ToString()].Text = rdr[5].ToString();
                sheet1.Range["F" + count.ToString()].Text = rdr[6].ToString();
                sheet1.Range["G" + count.ToString()].Text = rdr[7].ToString();
                count++;
            }
            rdr.Close();
            count = 2;
            rdr = Msqldatabase.Listart();
            while (rdr.Read())
            {
                sheet2.Range["A" + count.ToString()].Text = rdr[0].ToString();
                sheet2.Range["B" + count.ToString()].Text = rdr[1].ToString();
                sheet2.Range["C" + count.ToString()].Text = rdr[2].ToString();
                sheet2.Range["D" + count.ToString()].Text = rdr[3].ToString();
                sheet2.Range["E" + count.ToString()].Text = rdr[5].ToString();
                sheet2.Range["F" + count.ToString()].Text = rdr[6].ToString();
                count++;
            }
            rdr.Close();
            Msqldatabase.Closedatabase();
            //将Excel文件保存到指定文件,还可以指定Excel版本
            workbook.SaveToFile("D:\\c++\\librarymanager\\导出数据.xls", ExcelVersion.Version97to2003);
        }
        public int readexcel(int book, int CD, int art)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile("D:\\c++\\librarymanager\\导入数据.xls");
            Worksheet sheet = workbook.Worksheets[0];
            Worksheet sheet1 = workbook.Worksheets[1];
            Worksheet sheet2 = workbook.Worksheets[2];
            int bz = 0;
            int add = 0 ;
            Sqldatabase Msqldatabase = new Sqldatabase();
            Msqldatabase.Setdatabase();
            while (sheet.Range["A2"].Text != "")
            {
                add = Msqldatabase.bookadd(sheet.Range["A2"].Text, sheet.Range["B2"].Text, sheet.Range["C2"].Text, sheet.Range["D2"].Text, sheet.Range["E2"].Text, sheet.Range["F2"].Text, sheet.Range["G2"].Text);
                sheet.DeleteRow(2);
                book--;
                if (add == 1||book==0) { bz = 1; break; }
            }
            add = 0;
            while (sheet1.Range["A2"].Text != "")
            {
                add = Msqldatabase.CDadd(sheet1.Range["A2"].Text, sheet1.Range["B2"].Text, sheet1.Range["C2"].Text, sheet1.Range["D2"].Text, sheet1.Range["E2"].Text, sheet1.Range["F2"].Text, sheet1.Range["G2"].Text);
                sheet1.DeleteRow(2);
                CD--;
                if (add == 1 || CD== 0) { bz = 1; break; }
            }
            add = 0;
            while (sheet2.Range["A2"].Text != "")
            {
                add = Msqldatabase.artadd(sheet2.Range["A2"].Text, sheet2.Range["B2"].Text, sheet2.Range["C2"].Text, sheet2.Range["D2"].Text, sheet2.Range["E2"].Text, sheet2.Range["F2"].Text);
                sheet2.DeleteRow(2);
                art--;
                if (add == 1 || art == 0) { bz = 1; break; }
            }
            Msqldatabase.Closedatabase();
            return bz;
        }
    }
}

