CREATE TABLE mts(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	district nvarchar(100),
	location nvarchar(100),
	first_stage_manager nvarchar(100),
	contractor_for_1_task nvarchar(100),
	status nvarchar(100),
	object_number nvarchar(100),
	object_number_db nvarchar(100),
	address nvarchar(max),
	placement_equipment_A nvarchar(100),
	accessory_equipment_A nvarchar(250),
	programm_number int,
	request_date Date,
	realization_rejected bit,

	planning_completion_date_for_1_task Date,
	submission_date_of_1_task_result_for_approval Date,
	predict_approval_date_for_1_task_result Date,
	factual_approval_date_for_1_task_result Date,

	planning_completion_date_for_2_task Date,
	factual_completion_date_for_2_task Date,
	factual_ready_for_execution_date_for_2_task Date,
	factual_approval_date_for_2_task_result Date,
	note_for_2_task nvarchar(max),

	factual_ready_for_execution_date_for_3_task Date,
	employees_list_receiving_date_for_access_for_3_task Date,
	access_permission_notification_date_for_3_task Date,
	planning_ready_for_execution_date_for_3_task Date,
	access_permission_note_for_3_task nvarchar(max),

	name_KA nvarchar(100),

	planning_completion_date_for_4_task Date,
	predict_completion_date_for_4_task_result Date,
	factual_completion_date_for_4_task_result Date,
	note_for_4_task nvarchar(max),
	object_class int,

	planning_completion_date_for_5_task Date,
	factual_completion_date_for_5_task_result Date,

	planning_start_date_for_3_task Date,
	factual_start_date_for_3_task Date,
	planning_finish_date_for_3_task Date,
	factual_finish_date_for_3_task Date,

	menager_of_4_task nvarchar(100),

	planning_ready_to_start_date_for_2_task Date,
	planning_ready_to_start_date_for_3_task Date,
	executor_of_2_and_3_tasks nvarchar(max)
);