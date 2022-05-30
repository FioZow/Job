﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToMsSql
{
    public class ExcelReader
    {
        public static DataTable ExcelParse(string fileName, string workSheetName)
        {
            DataTable table = new DataTable();
            using (System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0; " +
                         "data source='" + fileName + "';" +
                            "Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\" "))
            {


                using (System.Data.OleDb.OleDbDataAdapter import = new System.Data.OleDb.OleDbDataAdapter("select * from [" + workSheetName + "$]", con))
                    import.Fill(table);
            }
            return table;
        }
    }
}
