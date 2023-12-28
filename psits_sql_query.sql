
create database PSITS;


CREATE TABLE administrative(
	admin_id int primary key identity,
	admin_name nvarchar(50) not null,
	admin_email_address nvarchar(50) not null,
	admin_password nvarchar(50) not null,
	admin_status nvarchar(5)

);

CREATE TABLE create_event(
	event_id int primary key identity,
	event_name nvarchar(50),
	event_created date
);

CREATE TABLE students(
	student_id int primary key identity,
	student_id_number nvarchar(20) not null,
	student_name nvarchar(50) not null,
	student_yearLevel int,
	student_course nvarchar(10),
	event_id int,
	foreign key(event_id) references create_event(event_id)
);
