/*  STRING DE CONEXÃO NO C#:
  Data Source=DESKTOP-8JGGFEG\\MASTERDB;Initial Catalog=tcmrestaurante;User ID=sa;Password=1234567
  Data Source=DESKTOP-PQKTQDT\\MASTERDB;Initial Catalog=tcmrestaurante;User ID=sa;Password=1234567 
Esses comandos abaixo garante que será iniciado uma 
database do zero para que não haja divirgêncais
e problemas futuros. 
Foi observado que a primeira execusão corre um erro
mas que não tem impacto na criação do DB.*/

use master
go
drop database tcmrestaurante
go
create database tcmrestaurante
go
use tcmrestaurante
go
create table funcionario(
codFunc int identity(1,1) NOT NULL,
nomeFunc char(100) not null,
usuarioFunc char(100) not null,
senhaFunc char(100) not null, 
cargoFunc char(100) not null,
PRIMARY KEY(codFunc)
)
go
insert into funcionario values ('Marcos','adminAD','anadev','Analista de Desenvolvimento')
go
insert into funcionario values ('Leonardo','adminFE','frontend','FrontEnd')
go
insert into funcionario values ('Richard','adminDB','bancodedados','Banco de Dados')
go
insert into funcionario values ('Nathan','adminD','design','Design')
go
insert into funcionario values ('Michael','adminHTML','html','Web Design')
go
insert into funcionario values ('Carlos','adminbe','backend','Back End')
go
create table fornecedor(
codForn int not null,
nomeForn char(100) not null,
cnpjForn char(100) not null,
PRIMARY KEY(codForn)
)
go
insert into fornecedor values (1,'Coca-Cola','44.227.819/0001-61')
go
insert into fornecedor values (2,'Adega Ltda','38.427.150/0001-59')
go
insert into fornecedor values (3,'Pão de Açucar','75.901.741/0001-42')
go
insert into fornecedor values (4,'China Ltda','44.038.556/0001-42')
go
create table estoque(
codProd int identity(1,1) NOT NULL,
nomeProd char(100) not null,
qtdProd int,
fornProd char(50) not null,
descProd char(100) not null,
PRIMARY KEY(codProd)
)
go
insert into estoque 
values('Arroz',500,'Pantanal do Arroz','Arroz direto da china boa qualidade.')
go
insert into estoque 
values('Salmão',200,'Peixaria Ltda','Salmão das águas profundas ótima qualidade.')
go
insert into estoque 
values('Bebidas',200,'Coca-Cola','Refrigerantes diversos.')
go
insert into estoque 
values('Frutas',200,'Pão de Açucar','Frutas para sucos diversos.')
go
insert into estoque 
values('Talharim',200,'China Ltda','Macarrão de boa qualidade.')
go
insert into estoque 
values('Bebidas',200,'Adega Ltda','Bebidas afrodisíacas.')
go
create table comanda(
codComandaPK int primary key,
observacaoComanda char(50),
)
go
create table pedido
(
codPedidoDeComandaFK int primary key,
entrada char(20),
bebida char(20),
prato char(20)
constraint fk_comanda foreign key (codPedidoDeComandaFK) references comanda(codComandaPK)
)
go