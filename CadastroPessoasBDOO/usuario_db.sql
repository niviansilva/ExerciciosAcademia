create database usuarios_db  

use usuarios_db

create table usuario (
idUsuario int primary key not null, 
nomeCompleto varchar(50),
email varchar(100)
)