use master;
go
drop database clinic;
go
create database clinic;
go
use clinic;
go
create table docs(
	id int not null identity primary key, 
	name varchar(100)
);
go
create table patients(
	id int not null identity primary key,
	name varchar(100)
);
go
create table appointments(
	id int not null identity primary key,
	extra varchar(100),
	patient_id int,
	doc_id int,
	appday date,
	foreign key (patient_id) references patients(id),
	foreign key (doc_id) references docs(id)
);