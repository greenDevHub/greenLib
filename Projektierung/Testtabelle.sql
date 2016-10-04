use Test001
drop table Testtabelle
create table Testtabelle
(
Kundennummer varchar (255), 
Artikel varchar (255),
Bauteil1 varchar (255),
Bauteil2 varchar (255),
Primary Key (Kundennummer)
);

insert into Testtabelle values('001', 'Asus', 'Intel Core i5', 'GTX1070'),
							  ('002', 'Acer', 'Intel Core i7', 'GTX980'),
							  ('003', 'Apple', 'Intel Pentium', 'GT630'),
							  ('004', 'AlienWare', 'Intel Core i7', 'GTX 1060'),
							  ('005', 'Dell', 'Intel Atom', 'GTX 650');
select * from Testtabelle 		