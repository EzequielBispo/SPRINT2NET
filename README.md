# Projeto CRUD com Persistncia de Dados.

## Requisitos

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
```

### 2. Configurar a String de Conexao:

No arquivo appsettings.json, adicione a string de conexo do Oracle:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "User Id=seu_usuario;Password=sua_senha;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=seu_host)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=seu_servico)))"
  }
}
```

### 3. Executar Migracoes:

No Console do Gerenciador de Pacotes NuGet, execute os seguintes comandos para adicionar e aplicar a migrao inicial:

```sh
Add-Migration InitialCreate
Update-Database
```

## EndPoints
`GET` {/api/Usuarios/id} <br>
#### Códigos de Status

|código|descrição
|------|---------
|200| Listagem de usuários
|404| Not Found
---

`POST` {/api/Usuarios/id} <br>
#### Códigos de Status

|código|descrição
|------|---------
|200| Usuário criado
|500| Falta ou excesso de argumentos
---

`PUT` {/api/Usuarios/id} <br>
#### Códigos de Status

|código|descrição
|------|---------
|201| Dados atualizados
|404| Conta não encontrada
---

`DELETE` {/api/Usuarios/id} <br>
#### Códigos de Status

|código|descrição
|------|---------
|200| Conta deletada com sucesso
|404| Conta não encontrada
---


