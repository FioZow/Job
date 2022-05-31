namespace ExcelToMsSql.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mts
    {
        public int id { get; set; }

        [StringLength(100)]
        public string district { get; set; }

        [StringLength(100)]
        public string location { get; set; }

        [StringLength(100)]
        public string first_stage_manager { get; set; }

        [StringLength(100)]
        public string contractor_for_1_task { get; set; }

        [StringLength(100)]
        public string status { get; set; }

        [StringLength(100)]
        public string object_number { get; set; }

        [StringLength(100)]
        public string object_number_db { get; set; }

        public string address { get; set; }

        [StringLength(100)]
        public string placement_equipment_A { get; set; }

        [StringLength(250)]
        public string accessory_equipment_A { get; set; }

        public int? programm_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? request_date { get; set; }

        public bool? realization_rejected { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_completion_date_for_1_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? submission_date_of_1_task_result_for_approval { get; set; }

        [Column(TypeName = "date")]
        public DateTime? predict_approval_date_for_1_task_result { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_approval_date_for_1_task_result { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_completion_date_for_2_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_completion_date_for_2_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_ready_for_execution_date_for_2_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_approval_date_for_2_task_result { get; set; }

        public string note_for_2_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_ready_for_execution_date_for_3_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? employees_list_receiving_date_for_access_for_3_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? access_permission_notification_date_for_3_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_ready_for_execution_date_for_3_task { get; set; }

        public string access_permission_note_for_3_task { get; set; }

        [StringLength(100)]
        public string name_KA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_completion_date_for_4_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? predict_completion_date_for_4_task_result { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_completion_date_for_4_task_result { get; set; }

        public string note_for_4_task { get; set; }

        public int? object_class { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_completion_date_for_5_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_completion_date_for_5_task_result { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_start_date_for_3_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_start_date_for_3_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_finish_date_for_3_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? factual_finish_date_for_3_task { get; set; }

        [StringLength(100)]
        public string menager_of_4_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_ready_to_start_date_for_2_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planning_ready_to_start_date_for_3_task { get; set; }

        public string executor_of_2_and_3_tasks { get; set; }
    }
}
