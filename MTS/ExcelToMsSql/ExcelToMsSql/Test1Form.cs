using ExcelToMsSql.Infrastructure;
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
    public partial class Test1Form : Form
    {
        public Test1Form()
        {
            InitializeComponent();
        }

        private void Test1Form_Load(object sender, EventArgs e)
        {

        }

        private void button_create_excel_Click(object sender, EventArgs e)
        {
            using (var excel = new ExcelHelper())
            {
                var year = textBox_year.Text;
                var headers = CreateHeaders();

                excel.Open(textBox_filePath.Text);

                for (int i = 1; i <= headers.Count; i++)
                {
                    excel.Set(1, i, headers[i - 1]);
                }

                var db = new ModelDb();
                var list = db.Mts.Where(x => x.executor_of_2_and_3_tasks != null).
                    Where(x => x.planning_completion_date_for_5_task.Value.ToString("yyyy") == year).
                    GroupBy(x => x.district).ToList();
                    //.GroupBy(x => x.executor_of_2_and_3_tasks).ToList();

                var rowCount = list.Count;

                for (int i = 1; i <= headers.Count; i++)
                {
                    for (int j = 2; j <= rowCount; j++)
                    {
                        excel.Set(j, i, list[j - 2].Key);
                        excel.Set(j, i, list[j - 2].Key);
                        excel.Set(j, i, list[j - 2].Key);
                        excel.Set(j, i + 1, list[j - 2].Key);

                    }
                }

                excel.Save();
            }
        }

        private List<string> CreateHeaders()
        {
            return new List<string>()
                {
                    "Округ",
                    "Локация",
                    "Подрядная организация (3)",
                    "Всего объектов",
                    "Количество выполненных Задача1",
                    "Количество выполненных Задача2",
                    "Готовность к выполнению Задачи3",
                    "Количество выполненных Задача3",
                    "Готовность к выполнению Задачи4",
                    "Количество выполненных Задача5",
                };
        }
    }
}
