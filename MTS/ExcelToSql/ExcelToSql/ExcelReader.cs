using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToSql
{
    public class ExcelReader
    {
        public static DataTable Parse(string fileName, string workSheetName)
        {
            DataTable table = new DataTable();
            using (var con = new OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0; " +
                         "data source='" + fileName + "';" +
                            "Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\" "))
            {


                using (var import = new System.Data.OleDb.OleDbDataAdapter("select * from [" + workSheetName + "$]", con))
                    import.Fill(table);
            }
            return table;
        }
    }
}
