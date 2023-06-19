create database api
use api
create table Cadastro
(
	Cpf numeric (11) primary key,
	Nome varchar (30) not null,
	Apelido varchar (20),
	Dt_nasc date not null,
	Email varchar not null,
	Senha varchar (15) not null,
	Nivel numeric (1),
)
drop table Cadastro