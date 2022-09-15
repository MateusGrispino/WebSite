create database bdSoftware;
use bdSoftware;

-- criação tabela
create table tbProjeto(
codProjeto int primary key auto_increment,
TipoProjeto varchar(50),
Cep varchar(10),
Contato varchar(50),
Email varchar(50),
Telefone varchar(15),
Descricao varchar(5000)
);

-- select
select*from tbProjeto; 