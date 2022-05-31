using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToMsSql
{
    public class ExcelHelper : IDisposable
    {
        private Excel.Workbook _workbook;
        private Excel.Application _excel;
        private string _filePath;

        public ExcelHelper()
        {
            _excel = new Excel.Application();
        }

        public void Open(string filePath)
        {
            if (File.Exists(filePath))
            {
                _workbook = _excel.Workbooks.Open(filePath);
            }
            else
            {
                _workbook = _excel.Workbooks.Add();
                _filePath = filePath;
            }
        }

        public void Set(int row, int column, object data)
        {
            ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
        }

        public void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
                _workbook.Save();
        }

        public void CreateReportByYear(int year)
        {
            
        }

        public void Dispose()
        {
            _workbook.Close();
        }
    }
}
