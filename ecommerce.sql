CREATE DATABASE ecommerce

USE ecommerce

CREATE TABLE tblusuario (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL,
email VARCHAR(100) UNIQUE NOT NULL,
senha VARCHAR(255) NOT NULL,
status_ativo CHAR(1) DEFAULT 'A' CHECK (status_ativo IN ('A','I'))
)

INSERT INTO tblusuario (nome, email, senha) 
VALUES ('Lucas', 'lucas@teste.com', 'COLE_O_HASH_AQUI');

SELECT * FROM tblusuario

SELECT senha, LEN(senha)
FROM tblusuario
WHERE email = 'lucas@teste.com';


UPDATE tblusuario 
SET senha = '$2a$11$e5J3mpXI9a40V.P1u1zS9.vb/uEfY.YJQLWLlkXHYyU/d3u1P5zca' 
WHERE email = 'lucas@teste.com'

CREATE TABLE tblcliente (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL,
cpf VARCHAR(14) UNIQUE NOT NULL,
datanascimento DATE,
email VARCHAR (100) NOT NULL,
celular VARCHAR (15) NOT NULL,
telefone VARCHAR(15),
senha VARCHAR(255) NOT NULL,
status_ativo CHAR(1) DEFAULT 'A' CHECK (status_ativo IN ('A','I'))
)

CREATE TABLE tblfornecedor (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL,
nomefantasia VARCHAR(100) NOT NULL,
cnpj VARCHAR(18) UNIQUE NOT NULL,
email VARCHAR(100),
telefone VARCHAR(15),
celular VARCHAR(15),
cep CHAR(9),
rua VARCHAR(100),
numero CHAR(5),
bairro VARCHAR(100),
cidade VARCHAR(100),
estado CHAR(2),
observacoes VARCHAR(MAX),
status_ativo CHAR(1) DEFAULT 'A' CHECK (status_ativo IN ('A','I'))
)

CREATE TABLE tblcategoria(
id INT PRIMARY KEY IDENTITY,
nome VARCHAR(100) NOT NULL,
descricao VARCHAR(255),
status_ativo CHAR(1) NOT NULL DEFAULT 'A' CHECK (status_ativo IN ('A','I'))
)


CREATE TABLE tblendereco(
id INT PRIMARY KEY IDENTITY,
cliente_id INT NOT NULL FOREIGN KEY REFERENCES tblcliente(id),
rua VARCHAR(100) NOT NULL,
numero CHAR (5) NOT NULL,
complemento VARCHAR(50),
bairro VARCHAR(100),
cidade VARCHAR(100) NOT NULL,
estado char (2) NOT NULL,
cep CHAR(9) NOT NULL,
observacoes VARCHAR(MAX)
)



CREATE TABLE tblproduto (
id INT PRIMARY KEY IDENTITY,
nome VARCHAR(100) NOT NULL,
preco DECIMAL(10,2) NOT NULL CHECK (preco > 0),
estoque INT NOT NULL CHECK (estoque >= 0),
peso DECIMAL(10,3),
altura DECIMAL(10,2),
largura DECIMAL(10,2),
comprimento DECIMAL(10,2),
descricao VARCHAR(MAX),
marca VARCHAR(100),
ean CHAR(13) UNIQUE,
sku VARCHAR(50) UNIQUE,
imagem1 VARCHAR(255),
imagem2 VARCHAR(255),
imagem3 VARCHAR(255),
fornecedor_id INT NOT NULL FOREIGN KEY REFERENCES tblfornecedor(id),
categoria_id INT NOT NULL FOREIGN KEY REFERENCES tblcategoria(id),
status_ativo CHAR(1) DEFAULT 'A' CHECK (status_ativo IN ('A','I'))
)

CREATE TABLE tblformapagamento (
id INT PRIMARY KEY IDENTITY,
descricao VARCHAR(50) NOT NULL,
status_ativo CHAR(1) NOT NULL DEFAULT 'A' CHECK (status_ativo IN ('A','I'))
)
INSERT INTO tblformapagamento (descricao)
VALUES
('PIX'),
('Cartão de Crédito'),
('Cartão de Débito'),
('Boleto'),
('Dinheiro');


CREATE TABLE tblpedido (
id INT PRIMARY KEY IDENTITY,
cliente_id INT NOT NULL,
data_pedido DATETIME NOT NULL DEFAULT GETDATE(),
subtotal DECIMAL(10,2) NOT NULL DEFAULT 0,
desconto DECIMAL(10,2) NOT NULL DEFAULT 0,
total DECIMAL(10,2) NOT NULL DEFAULT 0,
endereco_id INT NOT NULL FOREIGN KEY REFERENCES tblendereco(id),
status VARCHAR(20) NOT NULL DEFAULT 'Pendente',
forma_pagamento_id INT NULL,
CONSTRAINT FK_Pedido_Cliente
FOREIGN KEY (cliente_id) REFERENCES tblcliente(id),

CONSTRAINT FK_Pedido_Endereco
FOREIGN KEY (endereco_id) REFERENCES tblendereco(id),

CONSTRAINT FK_Pedido_FormaPagamento 
FOREIGN KEY (forma_pagamento_id) REFERENCES tblformapagamento(id)

)

CREATE TABLE tblitempedido (
id INT PRIMARY KEY IDENTITY,
pedido_id INT NOT NULL,
produto_id INT NOT NULL,
quantidade INT NOT NULL CHECK (quantidade > 0),
preco DECIMAL (10,2) NOT NULL,
data_inclusao DATETIME DEFAULT GETDATE(),

CONSTRAINT FK_ItemPedido_Pedido
FOREIGN KEY (pedido_id)REFERENCES tblpedido(id),

CONSTRAINT FK_ItemPedido_Produto
FOREIGN KEY (produto_id) REFERENCES tblproduto(id)
)

CREATE TABLE tblenvio (
id INT PRIMARY KEY IDENTITY,
pedido_id INT NOT NULL FOREIGN KEY REFERENCES tblpedido(id),
endereco_id INT NOT NULL FOREIGN KEY REFERENCES tblendereco(id),
transportadora VARCHAR(100),
codigo_rastreio VARCHAR(100),
data_envio DATETIME,
data_previsao DATE,
data_entrega DATETIME,
status VARCHAR(30) DEFAULT 'Aguardando' 
)

CREATE PROCEDURE sp_CadastrarProduto
	@nome VARCHAR(100),
	@preco DECIMAL(10,2),
	@estoque INT,
	@fornecedor_id INT,
	@categoria_id INT
AS
BEGIN
	INSERT INTO tblproduto (nome, preco, estoque, fornecedor_id, categoria_id)
	VALUES (@nome, @preco, @estoque, @fornecedor_id, @categoria_id)
END

EXEC sp_CadastrarProduto
    @nome = 'Headset Gamer',
    @preco = 299.90,
    @estoque = 15,
    @fornecedor_id = 1,
    @categoria_id = 1;

select * from tblproduto

CREATE PROCEDURE sp_CriarPedido
    @cliente_id INT,
    @endereco_id INT,
	@forma_pagamento_id INT
AS
BEGIN
    DECLARE @pedido_id INT
    INSERT INTO tblpedido (cliente_id, endereco_id, forma_pagamento_id)
    VALUES (@cliente_id, @endereco_id, @forma_pagamento_id)
    SET @pedido_id = SCOPE_IDENTITY()
    SELECT @pedido_id AS pedido_id
END

EXEC sp_CriarPedido
    @cliente_id = 1,
    @endereco_id = 1,
    @forma_pagamento_id = 1;

CREATE PROCEDURE sp_AdicionarItemPedido
	@pedido_id INT,
	@produto_id INT,
	@quantidade INT
AS 
BEGIN
	DECLARE @preco DECIMAL (10,2)
	
	SELECT @preco = preco
	FROM tblproduto
	WHERE id = @produto_id

	INSERT INTO tblitempedido (pedido_id ,produto_id, quantidade, preco)
	VALUES (@pedido_id, @produto_id, @quantidade, @preco)
END
EXEC sp_AdicionarItemPedido
    @pedido_id = 1,
    @produto_id = 1,
    @quantidade = 2;
SELECT * FROM tblpedido
SELECT * FROM tblitempedido
SELECT * FROM tblproduto

CREATE TRIGGER trg_BaixarEstoque
ON tblitempedido
AFTER INSERT
AS 
BEGIN
	UPDATE tblproduto
	SET estoque = estoque - i.quantidade
	FROM tblproduto p
	INNER JOIN inserted i ON p.id = i.produto_id

	-- Verifica se algum produto ficou negativo
	IF EXISTS (SELECT 1 FROM tblproduto WHERE estoque < 0)
	BEGIN
		RAISERROR('Estoque insuficiente para um ou mais produtos.', 16, 1)
		ROLLBACK TRANSACTION
		END
END

CREATE TRIGGER trg_AtualizarTotalPedido
ON tblitemPedido
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	UPDATE tblpedido
	SET total = (
		SELECT ISNULL(SUM(quantidade * preco), 0 )
		From tblitempedido
		WHERE pedido_id = tblpedido.id
	)
	WHERE id IN (
	SELECT pedido_id FROM inserted
	UNION
	SELECT pedido_id FROM deleted
	)
END
EXEC sp_settriggerorder
	@triggername = 'trg_BaixarEstoque',
	@order = 'First',
	@stmttype = 'INSERT'
