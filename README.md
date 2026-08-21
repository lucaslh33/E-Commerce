# E-commerce Desktop

Sistema desktop de gestão para e-commerce, desenvolvido em **C# (.NET / Windows Forms)** com **SQL Server** como banco de dados.

O projeto simula o back-office de uma loja online: cadastro de clientes, produtos, fornecedores e categorias, além de um módulo de PDV (ponto de venda) para registrar as vendas. A ideia é praticar, de ponta a ponta, o que se usa no dia a dia de um desenvolvedor back-end — modelagem de banco relacional, regras de negócio, transações e consumo de API.

## Tecnologias

- C# / .NET (Windows Forms)
- SQL Server + ADO.NET (Microsoft.Data.SqlClient)
- API REST (ViaCEP) para consulta de endereço
- Git / GitHub

## O que já está funcionando

**Clientes, produtos, fornecedores e categorias**
CRUD completo pra cada um, com exclusão lógica (soft delete) em vez de apagar o registro do banco — mantém histórico e evita quebrar vendas antigas que referenciam esses dados.

**Endereços**
Cadastro vinculado ao cliente, com preenchimento automático de rua, bairro, cidade e estado via API do ViaCEP a partir do CEP.

**PDV (ponto de venda)**
- Busca de produto por código/nome/descrição
- Carrinho com controle de quantidade
- Aplicação de desconto (percentual ou valor fixo)
- Seleção de forma de pagamento (Pix, cartão, boleto, dinheiro — com cálculo de troco)
- Ao finalizar a venda, o pedido e os itens são gravados no banco dentro de uma transação: se algo falhar no meio do processo, tudo é desfeito (rollback), garantindo que não fique nenhum dado gravado pela metade

**Banco de dados**
Modelagem relacional com chaves estrangeiras entre clientes, endereços, produtos, categorias, fornecedores, pedidos e itens de pedido. Uso de trigger para baixa automática de estoque quando um item de venda é inserido.

## Em desenvolvimento

- Refinar o pagamento no cartão (hoje a forma é registrada, mas ainda não guardo detalhes como parcelas)
- Upload de imagem dos produtos
- Tela de login e controle de permissões
- Relatórios e dashboard de vendas
- Emissão/impressão de comprovante

## Estrutura do projeto

```
Ecommerce
├── Clientes
├── Endereços
├── Produtos
├── Categorias
├── Fornecedores
├── PDV / Pedidos
└── Banco de Dados (SQL Server)
```

## Sobre o projeto

Este é meu principal projeto de portfólio enquanto curso Técnico em Desenvolvimento de Sistemas no SENAC (conclusão prevista maio/2027). Ele existe pra eu praticar programação orientada a objetos, banco de dados relacional e boas práticas de back-end de forma aplicada — não só em exercícios isolados, mas num sistema com regras de negócio reais.

Fico corrigindo e evoluindo aos poucos, então commits recentes costumam ser onde a coisa mais interessante está acontecendo.

## Autor

**Lucas Henrique Silva Pereira**

[LinkedIn](https://www.linkedin.com/in/lucas-henrique-78a76a381) · [GitHub](https://github.com/lucaslh33)