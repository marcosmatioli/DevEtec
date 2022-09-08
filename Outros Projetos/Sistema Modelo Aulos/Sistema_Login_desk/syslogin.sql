CREATE DATABASE SYSLOGIN

USE SYSLOGIN

CREATE TABLE logins(
email varchar(100),
senha varchar(20)
)

select * from logins

insert into logins values 
('well@gmail.com','12345'),
('joao@gmail.com','12345'),
('maria@gmail.com','12345'),
('jose@gmail.com','12345');


