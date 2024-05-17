# Projeto ASP.NET Core com Entity Framework Core e Banco de Dados Oracle

Este projeto  um exemplo de uma aplicao ASP.NET Core que utiliza o Entity Framework Core para se conectar a um banco de dados Oracle. O projeto inclui operaes CRUD (Create, Read, Update, Delete) bsicas para um modelo `Usuario`.

## Requisitos

- .NET 6 SDK ou superior
- Visual Studio 2022 ou superior
- Oracle Database (Local ou Remoto)
- Pacotes NuGet:
  - `Oracle.EntityFrameworkCore`
  - `Oracle.ManagedDataAccess.Core`
  - `Swashbuckle.AspNetCore`

## Configurao do Projeto

### 1. Instalar Pacotes NuGet

No Console do Gerenciador de Pacotes NuGet, execute os seguintes comandos:

```sh
Install-Package Oracle.EntityFrameworkCore
Install-Package Oracle.ManagedDataAccess.Core
Install-Package Swashbuckle.AspNetCore

### 2. Configurar a String de Conexao:

No arquivo appsettings.json, adicione a string de conexo do Oracle:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "User Id=seu_usuario;Password=sua_senha;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=seu_host)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=seu_servico)))"
  }
}

### 3. Executar Migracoes:

No Console do Gerenciador de Pacotes NuGet, execute os seguintes comandos para adicionar e aplicar a migrao inicial:

```sh
Add-Migration InitialCreate
Update-Database
