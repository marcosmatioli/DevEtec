CREATE DATABASE CONTATO
USE CONTATO

CREATE TABLE PESSOA (
ID INT PRIMARY KEY,
NOME VARCHAR(50),
CIDADE VARCHAR (10),
TELEFONE INT,
)

INSERT INTO PESSOA VALUES(1,'lu','testando','888888')
INSERT INTO PESSOA VALUES(2,'lu','testando','888888')
INSERT INTO PESSOA VALUES(3,'lu','testando','888888')
INSERT INTO PESSOA VALUES(4,'lu','testando','888888')



SELECT * FROM PESSOA