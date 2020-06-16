using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLcreate
{
    class ExcelProcess
    {
        public string ExcelFullName { get; set; }
        //建構子
        public ExcelProcess(string fileName)
        {
            this.ExcelFullName = fileName;
        }

        
        

        //將Excel Import 到DataGridView
        public DataSet Import()
        {
            try
            {
                DataSet ds = new DataSet();

                FileInfo file = new FileInfo(this.ExcelFullName);

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorkbook workbook = package.Workbook;
                    if (workbook != null)
                    {
                        if (workbook.Worksheets.Count > 0)
                        {
                            DataTable dt = null;

                            for (int i = 1; i <= workbook.Worksheets.Count;  i++)
                            {

                                //獲取Worksheet
                                ExcelWorksheet worksheet = workbook.Worksheets[i];
                                //轉成dataTable
                                dt = WorksheetToTable(worksheet);
                                ds.Tables.Add(dt);
                            }

                        }
                    }
                }
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //private 這個方法只有在這個class用 static 不需要實例化就可以用
        private static DataTable WorksheetToTable(ExcelWorksheet worksheet)
        {
            try
            {
                //1.建立dataTable物件
                int rows = worksheet.Dimension.End.Row;
                int cols = worksheet.Dimension.End.Column;
                DataTable dt = new DataTable(worksheet.Name);

                //2.設定DataColumn 第一欄的標題
                for (int i = 1; i <= cols; i++)
                {
                    dt.Columns.Add(worksheet.Cells[1, i].Text);
                }
                //3.設定dataRow 每一列的資料 再一列一列插入

                for (int i = 2; i <= rows; i++)
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 1; j <= cols; j++)
                    {
                        dr[j - 1] = worksheet.Cells[i, j].Value;
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
