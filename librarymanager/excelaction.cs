using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace librarymanager
{
    class excelaction
    {
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
            //将Excel文件保存到指定文件,还可以指定Excel版本
            workbook.SaveToFile("D:\\c++\\librarymanager\\导出数据.xls", ExcelVersion.Version97to2003);
        }
    }
}
