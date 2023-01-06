<p align="center">
    <img src="https://github.com/marioalvesx/CustomerRegistration-Upd8/blob/master/CustomerRegistration.png" width="700px"/>
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

## ⚛️ Recursos Extras

* Integração: Exibe todos os estados e cidades do Brasil utilizando a API pública do IBGE.
https://servicodados.ibge.gov.br/api/docs/localidades#api-UFs-estadosGet
* Paginação client side e busca de clientes utilizando DataTables do JQuery.
* Máscara de CPF utilizando Javascript puro.
* Validação customizada permitindo a inclusão apenas de clientes maiores de idade.
* Validação customizada do CPF utilizando biblioteca Caelum.Stella.CSharp.Validation.

## ⚙️ Como executar?
Após clonar a aplicação localmente, no seu VSCode basta rodar no terminal do repositório o comando
```bash
dotnet build
```
E em seguida
```bash
dotnet run
```
Lembrando que precisa também ter o banco de dados instalado localmente e configurado com as credenciais corretas no arquivo 'appsettings.json':

```json
"ConnectionStrings": {
    "CustomerRegistrationConnection": "Server=NomeDoSeuServidor; Database=CustomerRegistrationDb; Integrated Security=True; trustServerCertificate=true;"
  }
```
