Create DataBase SisVendaDB;

use SisVendaDB;

Create Table Clientes (
						ID INT IDENTITY(1,1) PRIMARY KEY not null,
						CPF VARCHAR(15) not null,
						Nome VARCHAR(50) not null,
						Endereco VARCHAR(100) not null,
						Bairro VARCHAR(30) not null,
						Cidade VARCHAR(40) not null,
						CEP VARCHAR(12) not null,
						UF CHAR(2) not null,
						Telefone VARCHAR(11) not null,
						Email VARCHAR(50) not null
					);

Create Table Produtos (
						ID INT IDENTITY(1,1) PRIMARY KEY not null,
						CodEAN BIGINT not null,
						Nome VARCHAR(50) not null,
						Preco MONEY not null,
						Estoque INT not null default(0),
						CaminhoImagem varchar(600) null
					  );

Create Table Vendas (
						ID INT IDENTITY(1,1) PRIMARY KEY not null,
						ID_Cliente INT not null,
						ValorTotal MONEY not null
						FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID)
					);

Create Table ItemVenda (
						ID INT IDENTITY(1,1) PRIMARY KEY not null,
						ID_Venda INT not null,
						ID_Produto INT not null,
						ValorUnitario MONEY not null,	
						Quantidade INT not null,
						ValorTotal MONEY
						FOREIGN KEY (ID_Venda) REFERENCES Vendas(ID),
						FOREIGN KEY (ID_Produto) REFERENCES Produtos(ID)
						);

