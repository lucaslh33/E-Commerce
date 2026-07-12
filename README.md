# 🛒 E-commerce Desktop

Sistema de E-commerce Desktop desenvolvido em **C# (.NET Windows Forms)** utilizando **SQL Server** como banco de dados.

O objetivo do projeto é simular um sistema utilizado por empresas para gerenciamento de clientes, produtos, fornecedores, categorias e vendas, aplicando conceitos utilizados no mercado de desenvolvimento de software.

---

## 🚀 Tecnologias utilizadas

- C#
- .NET Framework (Windows Forms)
- SQL Server
- ADO.NET
- API REST (ViaCEP)
- JSON
- Git
- GitHub

---

## 📌 Funcionalidades

### 👤 Clientes

- Cadastro de clientes
- Consulta de clientes
- Alteração de dados
- Exclusão lógica (Soft Delete)
- Cadastro de endereço
- Busca automática de endereço via ViaCEP

### 📦 Produtos

- Cadastro de produtos
- Consulta de produtos
- Alteração de produtos
- Exclusão lógica
- Controle de estoque
- Relacionamento com fornecedor e categoria

### 🏢 Fornecedores

- Cadastro
- Consulta
- Alteração
- Exclusão lógica

### 🏷 Categorias

- Cadastro
- Consulta
- Alteração
- Exclusão lógica

### 🛒 Pedidos

- Criação de pedidos
- Associação de clientes
- Associação de endereço
- Inclusão de produtos

### 💳 PDV (Em desenvolvimento)

- Pesquisa rápida de produtos
- Carrinho de compras
- Alteração de quantidade
- Cálculo automático do total
- Finalização da venda
- Baixa automática de estoque

---

## 🗄 Banco de Dados

O projeto utiliza SQL Server com:

- Procedures
- Triggers
- Transactions
- Foreign Keys
- Constraints
- Relacionamentos
- Soft Delete

---

## 🌐 Integração com API

Atualmente o sistema realiza integração com a API pública do ViaCEP.

Funcionalidades:

- Busca automática do endereço
- Preenchimento de:
  - Rua
  - Bairro
  - Cidade
  - Estado

---

## 📂 Estrutura do Projeto

```
Ecommerce
│
├── Clientes
├── Produtos
├── Categorias
├── Fornecedores
├── Endereços
├── Pedidos
├── PDV
├── Banco de Dados
└── API ViaCEP
```

---

## 🎯 Objetivos do Projeto

Este projeto foi desenvolvido com o objetivo de praticar:

- Programação Orientada a Objetos
- Desenvolvimento Desktop
- Banco de Dados Relacional
- SQL Server
- ADO.NET
- Integração com APIs REST
- Boas práticas de programação
- Organização de código
- Versionamento com Git

---

## 📸 Imagens

Em breve serão adicionadas capturas de tela do sistema.

---

## 📈 Próximas implementações

- [ ] Upload de imagens dos produtos
- [x] Integração com ViaCEP
- [ ] Login de usuários
- [ ] Controle de permissões
- [ ] Relatórios
- [ ] Dashboard
- [ ] Impressão de comprovante
- [ ] Exportação para PDF
- [ ] Melhorias na interface
- [ ] Finalização do módulo PDV

---

## 👨‍💻 Autor

**Lucas Henrique Silva Pereira**

LinkedIn:
https://www.linkedin.com/in/lucas-henrique-78a76a381

GitHub:
https://github.com/lucaslh33