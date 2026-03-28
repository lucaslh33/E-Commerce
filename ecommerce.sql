CREATE DATABASE ecommerce

USE ecommerce

CREATE TABLE Cliente (
id INT PRIMARY KEY IDENTITY,
nome VARCHAR(100) NOT NULL,
cpf VARCHAR(14) UNIQUE NOT NULL,
datanascimento DATE,
email VARCHAR (100) NOT NULL,
celular VARCHAR (15) NOT NULL,
rua VARCHAR(100) NOT NULL,
numero CHAR (5) NOT NULL,
cidade VARCHAR(100) NOT NULL,
estado char (2) NOT NULL
)

CREATE TABLE Produto (
id INT PRIMARY KEY IDENTITY,
nome VARCHAR(100) NOT NULL,
preco DECIMAL(10,2) NOT NULL CHECK (preco > 0),
estoque INT NOT NULL CHECK (estoque >= 0)
)

CREATE TABLE Pedido (
id INT PRIMARY KEY IDENTITY,
cliente_id INT NOT NULL,
data_pedido DATETIME DEFAULT GETDATE(),
total DECIMAL(10,2) DEFAULT 0,
status VARCHAR(20) DEFAULT 'Pendente',

CONSTRAINT FK_Pedido_Cliente
FOREIGN KEY (cliente_id) REFERENCES Cliente(id)
)

CREATE TABLE ItemPedido (
id INT PRIMARY KEY IDENTITY,
pedido_id INT NOT NULL,
produto_id INT NOT NULL,
quantidade INT NOT NULL CHECK (quantidade > 0),
preco DECIMAL (10,2) NOT NULL,
data_inclusao DATETIME DEFAULT GETDATE(),

CONSTRAINT FK_ItemPedido_Pedido
FOREIGN KEY (pedido_id)REFERENCES Pedido(id),

CONSTRAINT FK_ItemPedido_Produto
FOREIGN KEY (produto_id) REFERENCES Produto(id)
)

CREATE PROCEDURE sp_CadastrarProduto
	@nome VARCHAR(100),
	@preco DECIMAL(10,2),
	@estoque INT
AS
BEGIN
	INSERT INTO Produto (nome, preco, estoque)
	VALUES (@nome, @preco, @estoque)
END
EXEC sp_CadastrarProduto tridente, 2.50, 10

select * from Produto

CREATE PROCEDURE sp_CriarPedido
	@cliente_id INT

AS
BEGIN
DECLARE @pedido_id INT

	INSERT INTO Pedido (cliente_id)
	VALUES (@cliente_id)

	SET @pedido_id = SCOPE_IDENTITY()
	SELECT @pedido_id AS pedido_id
END
