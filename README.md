# E-commerce Desktop

Aplicativo desktop de gestão para uma loja, desenvolvido como projeto de estudo e portfólio. O sistema reúne cadastros, consulta de endereços, ponto de venda (PDV), controle de estoque e relatórios em uma aplicação Windows.

> Os pagamentos são simulados. O projeto não processa transações reais e não deve receber dados reais de cartão.

## Tecnologias

- C# e .NET 10 para Windows Forms
- SQL Server e ADO.NET (`Microsoft.Data.SqlClient`)
- BCrypt para verificação de senhas
- API ViaCEP para consulta de endereços por CEP

## Funcionalidades

- Login de usuário com senha armazenada como hash BCrypt.
- Cadastro, consulta, edição e exclusão lógica de clientes, produtos, fornecedores e categorias.
- Cadastro de endereços associados a clientes e preenchimento de rua, bairro, cidade e estado pelo ViaCEP.
- PDV com busca de produtos, carrinho, quantidades, descontos, seleção de cliente/endereço e registro de pedidos.
- Cadastro de até três imagens por produto, armazenadas localmente.
- Registro de formas de pagamento demonstrativas: Pix, cartão, boleto e dinheiro, com cálculo de troco para dinheiro.
- Relatórios de vendas por período, produtos mais vendidos, vendas por forma de pagamento e estoque baixo.
- Persistência do pedido e dos itens em uma transação SQL; o banco possui um gatilho para baixar o estoque.

## Estrutura

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

Os formulários WinForms contêm as telas e parte das operações de banco de dados. O arquivo `ecommerce.sql` reúne a estrutura do banco, procedimentos, gatilhos e consultas de exemplo.

## Requisitos

- Windows
- SDK do .NET 10
- SQL Server acessível pela máquina
- Permissão para criar/usar o banco `ecommerce`

## Configuração local

1. Clone o repositório:

   ```powershell
   git clone https://github.com/lucaslh33/E-Commerce.git
   cd E-Commerce
   ```

2. Configure a conexão com o SQL Server em `E-commerce/WinFormsApp1/Conexão.cs`. A configuração atual usa o servidor local (`localhost`), o banco `ecommerce` e autenticação integrada do Windows. Ajuste o servidor e o método de autenticação para o seu ambiente.

3. Prepare o banco `ecommerce` usando `ecommerce.sql` no SQL Server Management Studio. **O script está em evolução e ainda não é um instalador de execução única:** as instruções `CREATE PROCEDURE` precisam estar em lotes separados (`GO`), e a consulta de relatório ao final depende das variáveis `@dataInicio` e `@dataFim`. Revise e execute o arquivo por seções; não o rode em um banco com dados importantes sem conferir os comandos de exemplo.

4. Garanta que exista um usuário ativo em `tblusuario` com senha compatível com BCrypt. Use uma conta de teste; não reutilize uma senha pessoal.

5. Restaure as dependências e inicie o aplicativo:

   ```powershell
   dotnet run --project .\E-commerce\WinFormsApp1\Ecommerce.csproj
   ```

## Escopo e limitações atuais

- Pix, boleto e cartão são apenas formas registradas pelo aplicativo; não há integração com banco, adquirente ou serviço de pagamento.
- A tela de cartão solicita número, validade e CVV para a simulação. Embora o banco guarde somente os últimos dígitos, use exclusivamente dados fictícios.
- O campo de conexão está definido no código e inclui `TrustServerCertificate=True`, adequado apenas para desenvolvimento local controlado. Não use essa configuração como padrão de produção.
- A opção débito da tela de cartão ainda é registrada no banco como cartão de crédito; a distinção precisa ser corrigida antes de usar o relatório por forma de pagamento para essa comparação.
- A configuração do banco e as instruções de inicialização ainda precisam ser consolidadas em um processo reproduzível.

## Próximas melhorias

- Separar acesso a dados e regras de negócio dos formulários para facilitar manutenção e testes.
- Adicionar testes automatizados para descontos, estoque e totalização de pedidos.
- Centralizar a configuração do banco fora do código-fonte.
- Finalizar a preparação automatizada do banco e documentar uma conta de demonstração segura.
- Integrar um provedor de pagamentos antes de qualquer uso com transações reais.

## Autor

Lucas Henrique Silva Pereira · [GitHub](https://github.com/lucaslh33) · [LinkedIn](https://linkedin.com/in/lucas-henrique-78a76a381)
