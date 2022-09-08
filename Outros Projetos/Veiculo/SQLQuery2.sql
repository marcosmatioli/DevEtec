create database loja
go
use loja
go
/*String de conexão
Data Source=DESKTOP-8JGGFEG\\MASTERDB;Initial Catalog=loja;User ID=sa;Password=1234567
*/

create table carro
(
modelo varchar(50),
fabricante varchar(50),
ano int,
placa varchar(50),
cor varchar(50),
estado varchar(50),
cidade varchar(50),
foto varchar(50),
)
go
select * from carro
go