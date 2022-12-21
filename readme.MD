<p align="center">

</p>
<h1 align="center"> 🛠️ Aplicação para cadastro de cliente </h1>

## 🔍 Sobre
Esta é uma aplicação proposta como desafio para participação no processo seletivo
da empresa Upd8 na vaga como desenvolvedor .NET.
Essa aplicação foi desenvolvida em MVC utilizando o framework ASP.Net para cadastro, 
pesquisa, alteração e exclusão de clientes fictícios.

## 🧑‍💻 Tecnologias
* C# 
* ASP.Net 
* Razor
* Bootstrap
* Javascript
* SQL Server

## ⚙️ Como executar?
Após clonar a aplicação localmente no seu VSCode basta rodar o comando
```bash
dotnet build
```
E em seguida
```bash
dotnet run
```
Lembrando que precisa também ter o banco de dados instalado localmente e configurado com as credenciais no arquivo 'appsettings.json':

```json
"ConnectionStrings": {
    "CustomerRegistrationConnection": "Server=NomeDoSeuServidor; Database=CustomerRegistrationDb; Integrated Security=True; trustServerCertificate=true;"
  }
```
