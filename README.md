# E-commerce Desktop

Aplicativo desktop para gestão de uma loja, desenvolvido em C# com Windows Forms e SQL Server como projeto de estudo e portfólio.

> **Projeto demonstrativo:** os pagamentos são simulados. Não há integração com banco ou operadora, então use apenas dados fictícios no formulário de cartão.

## Funcionalidades

- Login com verificação de senha usando BCrypt.
- Cadastro, consulta, edição e desativação de clientes, produtos, fornecedores e categorias.
- Cadastro de endereços de clientes e preenchimento de endereço pelo CEP usando a API ViaCEP.
- Cadastro de até três imagens por produto, armazenadas localmente.
- PDV com busca de produtos, carrinho, seleção de cliente e endereço, descontos percentuais ou por valor e registro de pedidos.
- O desconto é validado e limpo quando os itens do carrinho são alterados.
- Formas de pagamento demonstrativas: Pix, crédito, débito, boleto e dinheiro. Para dinheiro, o sistema calcula o troco.
- Relatórios de vendas por período, produtos mais vendidos, formas de pagamento e estoque baixo.
- Pedido e itens gravados em uma transação SQL. Gatilhos do banco recalculam os totais e baixam o estoque, impedindo a venda quando não há quantidade suficiente.

## Tecnologias

- C# e .NET 10 com Windows Forms.
- SQL Server e ADO.NET (`Microsoft.Data.SqlClient`).
- `BCrypt.Net-Next` para verificação de senhas.
- API ViaCEP para consulta de endereços.
- Newtonsoft.Json para leitura de respostas JSON.

## Estrutura do repositório

```text
E-Commerce/
├── ecommerce.sql
└── E-commerce/
    ├── E-commerce.slnx
    └── WinFormsApp1/
        ├── Ecommerce.csproj
        ├── Program.cs
        ├── Conexão.cs
        ├── frm*.cs
        └── ...
```

O arquivo `ecommerce.sql`, na raiz, cria o banco, as tabelas, procedimentos armazenados e gatilhos. Os formulários da pasta `WinFormsApp1` contêm as telas e parte das operações com o banco.

## Requisitos

- Windows.
- SDK do .NET 10.
- SQL Server.
- SQL Server Management Studio (SSMS) para executar o script do banco.
- Internet para consultar endereços pela API ViaCEP.

## Como executar

1. Clone o repositório:

   ```powershell
   git clone https://github.com/lucaslh33/E-Commerce.git
   cd E-Commerce
   ```

2. Inicie uma instância do SQL Server. No SSMS, abra e execute `ecommerce.sql`.

   O script cria o banco `ecommerce` quando ele ainda não existe, cria tabelas ausentes, insere as formas de pagamento padrão sem duplicá-las e cria ou atualiza procedimentos e gatilhos. **Ele não atualiza a estrutura de tabelas que já existem.** Se você já tiver um banco `ecommerce`, confira a estrutura e faça backup antes de executar o script.

3. Confira a conexão em `E-commerce/WinFormsApp1/Conexão.cs`. O valor publicado usa o servidor `localhost`, o banco `ecommerce` e autenticação integrada do Windows. Ajuste o servidor para a sua instalação local.

4. Crie um usuário de teste. O script não cria uma conta de login. Gere um hash BCrypt localmente usando a dependência do projeto:

   ```csharp
   string hash = BCrypt.Net.BCrypt.EnhancedHashPassword("SuaSenhaDeTeste");
   Console.WriteLine(hash);
   ```

   Em seguida, use o hash gerado para inserir uma conta de teste no banco:

   ```sql
   INSERT INTO dbo.tblusuario (nome, email, senha, status_ativo)
   VALUES ('Usuário de teste', 'teste@exemplo.com', 'COLE_AQUI_O_HASH_GERADO', 'A');
   ```

   Use uma senha temporária que não seja utilizada em outros serviços.

5. Execute o aplicativo a partir da pasta do repositório:

   ```powershell
   dotnet run --project .\E-commerce\WinFormsApp1\Ecommerce.csproj
   ```

## Escopo e limitações

- Pix, cartão e boleto são registrados apenas para demonstração. O sistema não processa pagamentos reais.
- A tela de cartão solicita dados para a simulação, mas o banco armazena somente tipo, nome do titular e últimos quatro dígitos. Não informe dados reais.
- A string de conexão está definida no código e contém `TrustServerCertificate=True`, configuração usada aqui para desenvolvimento local. Não use essa configuração como padrão para produção.
- O script inicializa objetos ausentes, mas não substitui um sistema de migrações para alterar tabelas existentes.

## Próximas melhorias

- Separar as regras de negócio e o acesso a dados dos formulários.
- Adicionar testes automatizados para descontos, estoque e totalização de pedidos.
- Mover a configuração da conexão para um arquivo de configuração local, fora do código-fonte.

## Autor

Lucas Henrique Silva Pereira · [GitHub](https://github.com/lucaslh33) · [LinkedIn](https://linkedin.com/in/lucas-henrique-78a76a381)
