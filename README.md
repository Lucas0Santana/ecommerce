# REQUISITOS PARA RODAR A APLICAÇÃO

## Listagem de ferramentas necessárias:

### [<img align="center" alt="Lucas-" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/csharp/csharp-original.svg"> .Net SDK](https://dotnet.microsoft.com/en-us/download), SDK do .Net, versão 8 utilizada na aplicação;
### [<img align="center" alt="Lucas-" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/vscode/vscode-original.svg"> VsCode](https://code.visualstudio.com/), pode ser qualquer IDE que excute DotNet, porém a aplicação foi feita no Visual Studio Code;
### [<img align="center" alt="Lucas-" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/postgresql/postgresql-original.svg"> PgAdmin](https://www.pgadmin.org/download/), SGBD;
### [<img align="center" alt="Lucas-" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/postgresql/postgresql-original.svg"> PostgreSQL](https://www.postgresql.org/download/), BD.

## Recomendação:

#### [<img align="center" alt="Lucas-" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/vscode/vscode-original.svg"> .NET Core Extension Pack](https://marketplace.visualstudio.com/items?itemName=doggy8088.netcore-extension-pack), pack de extensões que melhoram o trabalho com .Net no VsCode.

## Passo a passo para executar a API:

1. Após todas as instalações e com o projeto aberto, é necessário atualizar o User Id e o Passaword na **string de conexão** no arquivo appsettings.Development, na raiz do projeto;
2. É necessário instalar o DotNet EF para poder usufruir dos *migrations*, no próprio terminal do VsCode executar **dotnet tool install --global dotnet-ef**_;
3. Para gerar os *migrations* ainda no terminal, execute **dotnet ef database update**_;
4. Para executar, caso tenha baixado as extenssões, é só teclar **F5**;

## Pronto, agora você tem a API na sua maquina com banco de dados local!

### [PDF](https://drive.google.com/file/d/1EYXhGPC2xeYi8Mo-lou9Nlm0DxFWD5WK/view?usp=sharing), Documentação.
