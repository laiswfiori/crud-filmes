# 🎬 Sistema de Gerenciamento de Filmes

Aplicação desktop desenvolvida em **C# com Windows Forms** para gerenciamento de **filmes, atores e países**, utilizando **Entity Framework Core** para persistência de dados em **PostgreSQL**.

O sistema permite realizar operações completas de cadastro e relacionamento entre entidades, simulando um cenário real de gerenciamento de catálogo de filmes.

---

## 📌 Funcionalidades

- 🎭 Cadastro, edição, listagem e remoção de **atores**
- 🎬 Cadastro, edição e listagem de **filmes**
- 🔗 Associação de atores aos filmes (elenco)
- 🌍 Relacionamento de filmes e atores com **país de origem**
- 🔍 Busca de atores por nome
- 🗄 Persistência de dados em banco de dados PostgreSQL
- 🖥 Interface gráfica com múltiplos formulários

---

## 🛠 Tecnologias Utilizadas

- C#
- .NET
- Windows Forms
- Entity Framework Core
- PostgreSQL
- LINQ
- Lazy Loading Proxies
- Data Annotations

---

## 🧠 Conceitos Aplicados

- CRUD completo
- Programação Orientada a Objetos (POO)
- Relacionamentos entre entidades
- ORM com Entity Framework
- LINQ para consultas ao banco de dados
- Separação de responsabilidades
- Manipulação de eventos em aplicações desktop

---

## 🗂 Estrutura do Projeto

- **Models**  
  Contém as classes de domínio (`Filme`, `Ator`, `Pais`) e o `DbContext`.

- **Forms**  
  Interfaces gráficas para interação com o usuário (cadastro, edição, busca e listagem).

---

## 🚀 Como Executar o Projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
2. Abra o projeto no Visual Studio
3. Certifique-se de que você possui o PostgreSQL instalado e em execução
4. Ajuste a string de conexão no arquivo Contexto.cs, se necessário:
   ```bash
   optionsBuilder.UseNpgsql("Host=localhost;Database=filmes2A;Username=postgres;Password=postgres");
5. Execute a aplicação (F5)
