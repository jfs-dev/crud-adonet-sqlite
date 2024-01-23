# crud-adonet-sqlite
Operações CRUD com SQLite usando ADO.NET para acesso a dados

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como executar operações CRUD em um banco de dados SQLite usando ADO.NET para acesso a dados.

ADO.NET fornece uma camada de baixo nível para interagir com bancos de dados relacionais sem a abstração adicional oferecida por tecnologias ORM (Object-Relational Mapping) como o Entity Framework.

Ao utilizar ADO.NET, os desenvolvedores têm mais controle direto sobre as operações de banco de dados, o que pode ser benéfico em casos em que o desempenho é uma prioridade ou quando se precisa de uma manipulação de dados mais específica e detalhada.

**SqliteConnection:** A classe SqliteConnection representa uma conexão física com um banco de dados SQLite. Ela é usada para abrir, fechar e gerenciar a conexão com o banco de dados.

**SqliteCommand:** A classe SqliteCommand representa uma instrução SQL ou uma stored procedure que será executada no banco de dados. Ela é usada para executar consultas, comandos de atualização, inserção, exclusão e outras operações no banco de dados.

**SqliteDataReader** A classe SqliteDataReader é usada para ler um fluxo de dados de uma consulta SQL executada no banco de dados. Ela permite iterar sobre as linhas retornadas pela consulta.

<div align="center">
    <img src="https://github.com/jfs-dev/crud-adonet-sqlite/assets/54154628/90b136e7-2008-4d91-a2b3-9e2b6c8c011b"</img>
    <img src="https://github.com/jfs-dev/crud-adonet-sqlite/assets/54154628/a8c9ddc1-48b8-45bf-a451-a797573ab687"</img>
</div>

## Referências
https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/

https://learn.microsoft.com/pt-br/dotnet/standard/data/sqlite/?tabs=netcore-cli

https://www.sqlite.org/

https://sqlitebrowser.org/

## Licença
GPL-3.0 license

