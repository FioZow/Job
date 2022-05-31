﻿using ExcelToMsSql.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToMsSql
{
    public partial class Test0Form : Form
    {
        public Test0Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var table = ExcelReader.ExcelParse(@"..\..\..\Задание_.xlsx", "Статус работ");
            var db = new ModelDb();
            MsSqlWriter.WriteToSql(table, db);
            Close();
        }
    }
}