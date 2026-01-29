# 🎬 Sistema de Gerenciamento de Filmes

Aplicação desktop desenvolvida em **C# com Windows Forms** para gerenciamento de **filmes, atores e países**, com persistência de dados em **PostgreSQL** utilizando **Entity Framework Core**.

O sistema simula um cenário real de gerenciamento de catálogo de filmes, permitindo o cadastro e o relacionamento completo entre as entidades.

---

## 🎯 Objetivo do Projeto

Desenvolver uma aplicação desktop para praticar conceitos de **Programação Orientada a Objetos**, **persistência de dados com ORM** e **relacionamentos entre entidades**, simulando um sistema de gerenciamento utilizado em contextos reais.

---

## 🛠️ Tecnologias Utilizadas

- Linguagem:
  - C#
- Frameworks e Plataformas:
  - .NET
  - Windows Forms
- Banco de dados:
  - PostgreSQL
- Bibliotecas e Ferramentas:
  - Entity Framework Core
  - LINQ
  - Lazy Loading Proxies
  - Data Annotations

---

## ⚙️ Funcionalidades

- Cadastro, edição, listagem e remoção de **atores**
- Cadastro, edição e listagem de **filmes**
- Associação de atores aos filmes (elenco)
- Relacionamento de filmes e atores com **país de origem**
- Busca de atores por nome
- Persistência de dados em banco de dados PostgreSQL
- Interface gráfica com múltiplos formulários

---

## 🧠 Conceitos Aplicados

- CRUD completo
- Programação Orientada a Objetos (POO)
- Relacionamentos entre entidades
- ORM com Entity Framework Core
- LINQ para consultas ao banco de dados
- Separação de responsabilidades
- Manipulação de eventos em aplicações desktop

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

- .NET SDK instalado
- PostgreSQL em execução
- Visual Studio
- Git

### Passo a passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
2. Abra o projeto no Visual Studio
3. Certifique-se de que o PostgreSQL está instalado e em execução
4. Ajuste a string de conexão no arquivo Contexto.cs, se necessário:
   ```bash
   optionsBuilder.UseNpgsql("Host=localhost;Database=filmes2A;Username=postgres;Password=postgres");

--- 

Projeto desenvolvido com foco em aprendizado, organização de código e aplicação de boas práticas de desenvolvimento.
