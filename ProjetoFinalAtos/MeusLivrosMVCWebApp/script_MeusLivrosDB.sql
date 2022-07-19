--create database MeusLivros_DB;

--use meusLivros_DB;

create table Generos (
					  ID int identity(1,1) Primary Key not null,
					  Estilo_Genero varchar(60) not null
					)

create table Livros (
						ID int identity(1,1) not null PRIMARY KEY,
						NomeLivro varchar(200) not null,
						Autor varchar(100) not null,
						Editora varchar(50) not null,
						ID_Genero int not null,
						Sinopse text null,
						FotoCapa varchar(200) null,
						StatusLivro bit default(1) not null
						CONSTRAINT FK_IDGenero FOREIGN KEY (ID_Genero) REFERENCES Generos (ID)
					);

					
create table LivrosEmprestados (
								 ID int identity(1,1) not null,
								 IDLivro int not null,
								 NomeAmigo varchar(50) not null,
								 Telefone varchar(14) null,
								 Email varchar(100) null,
								 DataInicio datetime not null,
								 DataDevolucao datetime null
								 PRIMARY KEY (ID),
								 CONSTRAINT FK_IDLIVRO FOREIGN KEY (IDLivro) REFERENCES Livros (ID)
								);

Create table VisaoLivros (
							ID int identity(1,1) not null,
							IDLivro int not null,
							NomeLivro varchar(200) not null,
							Autor varchar(100) not null,
							Editora varchar(50) not null,
							Genero varchar(60) not null,
							StatusLivro bit default(1) not null
							);

Create table VisaoEmprestados (
							ID int identity(1,1) not null,
							IDLivroEmprestado int not null,
							NomeLivro Varchar(200) not null,
							NomeAmigo varchar(50) not null,
							Telefone varchar(14) null,
							Email varchar(100) null,
							DataInicio datetime not null,
							DataDevolucao datetime null,
							StatusLivro bit default(1) not null
							);




