# dotnet-minimal-api
This project presents a Minimal API built with .NET 8, aiming to demonstrate the creation of REST endpoints in a simple and organized way. The project uses Entity Framework Core with SQLite for persistence and includes automatic documentation via Swagger.

## Features
- API built using .NET 8 Minimal APIs
- Complete CRUD for item management
- Data persistence with Entity Framework Core
- Use of SQLite for local database
- Documentation with Swagger / OpenAPI
- Simple, clean, and easily extensible structure

## Technologies Used
- .NET 8
- C# 12
- Minimal API
- Entity Framework Core
- SQLite
- Swagger / Swashbuckle

## Prerequisites
To run the project, you need to have installed:

- .NET SDK 8 or higher
- (Optional) Visual Studio Code with the C# extension

## How to Run

Clone the repository:

```
git clone https://github.com/stephanie-lops/dotnet-minimal-api.git
```
Access the directory:

```
cd dotnet-minimal-api
```
Restore Dependencies:

```
dotnet restore
```
Create/update the database:

```
dotnet ef database update
```
Run the project:

```
dotnet run
```
The API will be available at:

```
https://localhost:5001

```
Swagger available at:

```
https://localhost:5001/swagger

```
## Endpoints
- GET /items Returns all registered items.

- GET /items/{id} Returns a specific item by ID.

- POST /items Creates a new item.

- PUT /items/{id} Updates an existing item.

- DELETE /items/{id} Removes an item.

All endpoints can be tested directly through Swagger.

--------------- PORTUGUESE ----------------
# dotnet-minimal-api
Este projeto apresenta uma Minimal API construída com .NET 8, com o objetivo de demonstrar a criação de endpoints REST de forma simples e organizada. O projeto utiliza Entity Framework Core com SQLite para persistência e inclui documentação automática via Swagger.

## Funcionalidades
- API construída utilizando .NET 8 Minimal APIs
- CRUD completo para gerenciamento de itens
- Persistência de dados com Entity Framework Core
- Utilização de SQLite para banco local
- Documentação com Swagger / OpenAPI
- Estrutura simples, limpa e facilmente extensível

## Tecnologias Utilizadas
- .NET 8
- C# 12
- Minimal API
- Entity Framework Core
- SQLite
- Swagger / Swashbuckle

## Pré-requisitos
Para executar o projeto, é necessário ter instalado:
- .NET SDK 8 ou superior
- (Opcional) Visual Studio Code com a extensão C#

## Como Executar

Clonar o repositório:
```
git clone https://github.com/stephanie-lops/dotnet-minimal-api.git
```
Acessar o diretório:
```
cd dotnet-minimal-api
```
Restaurar dependências:
```
dotnet restore
```
Criar/atualizar o banco de dados:
```
dotnet ef database update
```
Executar o projeto:
```
dotnet run
```
A API ficará disponível em:
```
https://localhost:5001
```
Swagger disponível em:
```
https://localhost:5001/swagger
```
## Endpoints
- GET /items
Retorna todos os itens cadastrados.
- GET /items/{id}
Retorna um item específico pelo ID.
- POST /items
Cria um novo item.
- PUT /items/{id}
Atualiza um item existente.
- DELETE /items/{id}
Remove um item.

Todos os endpoints podem ser testados diretamente pelo Swagger.
