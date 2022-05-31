using ExcelToMsSql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToMsSql
{
    public class MsSqlWriter
    {
        public static void WriteToSql(DataTable table, ModelDb db)
        {
            foreach (DataRow row in table.Rows)
            {
                var entity = new Mts();
                entity.district = ValidateString(row[0]);
                entity.location = ValidateString(row[1]);
                entity.first_stage_manager = ValidateString(row[2]);
                entity.contractor_for_1_task = ValidateString(row[3]);
                entity.status = ValidateString(row[4]);
                entity.object_number = ValidateString(row[5]);
                entity.object_number_db = ValidateString(row[6]);
                entity.address = ValidateString(row[7]);
                entity.placement_equipment_A = ValidateString(row[8]);
                entity.accessory_equipment_A = ValidateString(row[9]);
                entity.programm_number = ValidateNumber(row[10]);
                entity.request_date = ValidateDate(row[11]);

                if (row[12].ToString().ToLower() == "да")
                    entity.realization_rejected = true;
                else
                    entity.realization_rejected = false;

                entity.planning_completion_date_for_1_task = ValidateDate(row[13]);
                entity.submission_date_of_1_task_result_for_approval = ValidateDate(row[14]);
                entity.predict_approval_date_for_1_task_result = ValidateDate(row[15]);
                entity.factual_approval_date_for_1_task_result = ValidateDate(row[16]);
                entity.planning_completion_date_for_2_task = ValidateDate(row[17]);
                entity.factual_completion_date_for_2_task = ValidateDate(row[18]);
                entity.factual_ready_for_execution_date_for_2_task = ValidateDate(row[19]);
                entity.factual_approval_date_for_2_task_result = ValidateDate(row[20]);
                entity.note_for_2_task = ValidateString(row[21]);
                entity.factual_ready_for_execution_date_for_3_task = ValidateDate(row[22]);
                entity.employees_list_receiving_date_for_access_for_3_task = ValidateDate(row[23]);
                entity.access_permission_notification_date_for_3_task = ValidateDate(row[24]);
                entity.planning_ready_for_execution_date_for_3_task = ValidateDate(row[25]);
                entity.access_permission_note_for_3_task = ValidateString(row[26]);
                entity.name_KA = ValidateString(row[27]);
                entity.planning_completion_date_for_4_task = ValidateDate(row[28]);
                entity.predict_completion_date_for_4_task_result = ValidateDate(row[29]);
                entity.factual_completion_date_for_4_task_result = ValidateDate(row[30]);
                entity.note_for_4_task = ValidateString(row[31]);
                entity.object_class = ValidateNumber(row[32]);
                entity.planning_completion_date_for_5_task = ValidateDate(row[33]);
                entity.factual_completion_date_for_5_task_result = ValidateDate(row[34]);
                entity.planning_start_date_for_3_task = ValidateDate(row[35]);
                entity.factual_start_date_for_3_task = ValidateDate(row[36]);
                entity.planning_finish_date_for_3_task = ValidateDate(row[37]);
                entity.factual_finish_date_for_3_task = ValidateDate(row[38]);
                entity.menager_of_4_task = ValidateString(row[39]);
                entity.planning_ready_to_start_date_for_2_task = ValidateDate(row[40]);
                entity.planning_ready_to_start_date_for_3_task = ValidateDate(row[41]);
                entity.executor_of_2_and_3_tasks = ValidateString(row[42]);

                db.Mts.Add(entity);
            }
            db.SaveChanges();
        }

        private static DateTime? ValidateDate(object row)
        {
            var date = new DateTime();
            int days;
            if (DateTime.TryParse(row.ToString(), out date))
            {
                return date;
            }
            else if (int.TryParse(row.ToString(), out days))
            {
                var d = new DateTime(1900, 1, 1);
                return d.AddDays(days - 2);
            }
            else
                return null;
        }

        private static string ValidateString(object row)
        {
            if (row.ToString() != "")
            {
                return row.ToString();
            }
            else
                return null;
        }

        private static int? ValidateNumber(object row)
        {
            if (row.ToString() != "")
            {
                return Convert.ToInt32(row);
            }
            else
                return null;
        }
    }
}
