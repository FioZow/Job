CREATE TABLE mts(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	district nvarchar(100),
	location nvarchar(100),
	first_stage_manager nvarchar(100),
	contractor_for_1_task nvarchar(100),
	status nvarchar(100),
	object_number nvarchar(100),
	object_number_db nvarchar(100),
	address nvarchar(1000),
	placement_equipment_A nvarchar(100),
	accessory_equipment_A nvarchar(200),
	programm_number int,
	request_date DateTime,
	realization_rejected bit,

	planning_completion_date_for_1_task DateTime,
	submission_date_of_1_task_result_for_approval DateTime,
	predict_approval_date_for_1_task_result DateTime,
	factual_approval_date_for_1_task_result DateTime,

	planning_completion_date_for_2_task DateTime,
	factual_completion_date_for_2_task DateTime,
	factual_ready_for_execution_date_for_2_task DateTime,
	factual_approval_date_for_2_task_result DateTime,
	note_for_2_task nvarchar(1000),

	factual_ready_for_execution_date_for_3_task DateTime,
	employees_list_receiving_date_for_access_for_3_task DateTime,
	access_permission_notification_date_for_3_task DateTime,
	planning_ready_for_execution_date_for_3_task DateTime,
	access_permission_note_for_3_task nvarchar(1000),

	name_KA nvarchar(100),

	planning_completion_date_for_4_task DateTime,
	predict_completion_date_for_4_task_result DateTime,
	factual_completion_date_for_4_task_result DateTime,
	note_for_4_task nvarchar(1000),
	object_class int,

	planning_completion_date_for_5_task DateTime,
	factual_completion_date_for_5_task_result DateTime,

	planning_start_date_for_3_task DateTime,
	factual_start_date_for_3_task DateTime,
	planning_finish_date_for_3_task DateTime,
	factual_finish_date_for_3_task DateTime,

	menager_of_4_task nvarchar(100),

	planning_ready_to_start_date_for_2_task DateTime,
	planning_ready_to_start_date_for_3_task DateTime,
	executor_of_2_and_3_tasks nvarchar(1000)
);