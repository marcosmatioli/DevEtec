create database bdClinica;
use bdClinica;

create table tbPaciente(
codPaciente int primary key auto_increment,
nomePaciente varchar(50),
enderecoPaciente varchar(50),
telPaciente varchar(50),
celPaciente varchar(50)
);

create table tbEspecialidade(
codEspecialidade int primary key auto_increment,
Especialidade varchar(50)
);

create table tbMedico(
codMedico int primary key auto_increment,
nomeMedico varchar(50),
codEspecialidade int,
foreign key (codEspecialidade) References tbEspecialidade(codEspecialidade)
);

create table tbAgendamento(
codAgendamento int primary key auto_increment,
codPaciente int,
codMedico int,
horaAgendamento varchar(10),
dataAgendamento varchar(10),
reclamacaoPaciente varchar(100),
foreign key (codPaciente) References tbPaciente(codPaciente),
foreign key (codMedico) References tbMedico(codMedico)
);
create table tbAtendimento(
codAtendimento int primary key auto_increment,
codPaciente int,
codMedico int,
dataAtendimento varchar(10),
horaAtendimento varchar(10),
Diagnostico varchar(100),
foreign key (codPaciente) References tbPaciente(codPaciente),
foreign key (codMedico) References tbMedico(codMedico)
);
create view vwAtendimento as select * from tbAtendimento;
create view vwEspecialidade as select * from tbEspecialidade;
create view vwPaciente as select * from tbPaciente;
create view vwMedico as select * from tbMedico;
create view vwAgendamento as select * from tbAgendamento;

#drop database bdClinica

/*
select * from tbAtendimento;
select * from tbEspecialidade;
select * from tbPaciente;
select * from tbMedico;
select * from tbAgendamento;

select * from vwAtendimento;
select * from vwEspecialidade;
select * from vwPaciente;
select * from vwMedico;
select * from vwAgendamento;
*/
