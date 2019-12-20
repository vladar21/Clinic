use clinic;
go
insert into patients(name) values
('Patient1'),
('Patient2'),
('Patient3'),
('Patient4'),
('Patient5');
go
insert into docs(name) values
('Doc1'),
('Doc2'),
('Doc3');

use clinic;
go
delete from patients where id > 5
select * from patients
delete from docs where id > 3
select * from docs