# ApiToDo_Balta
Curso Todo App: API com ASP.NET Core, CQRS e EF Core do balta.io

## Estrutura da Api
* ### Todo.Domain: Onde fica o núcleo da sua aplicação, mas não tem instância de nada, apenas é declarado
    * Commands: São os comandos que chegarão, por exemplo "Criar novo Todo"
    * Entities: As entidades de sua aplicação, nesse caso temos apenas o Todo
    * Handlers: Feito para manipular os comandos
    * Queries: Comandos para leitura de dados do banco
    * Repositories: Onde ficas as representações (interface) das entidades no banco de dados.

* ### Todo.Domain.Infra: Aqui fica a implementação de fato da aplicação, onde fica as "sujeiras" como migrations
    * Contexts
    * Migrations: Pasta de controle de migração das informações com o banco de dados
    * Repositories: Aqui é implementado o Repositório real
    
* ### Todo.Api: 
    * Controllers: São os itens que recebem as requisições, gerencia e devolve o resultado
    * Models: Models são a referência ao banco de dados


* ### Todo.Domain.Tests: Aqui onde se programa os testes do domain
    * CommandTests: Teste dos comandos chegados
    * EntitiyTests: Teste das entidades
    * HandlerTests: Teste de manipulação dos comandos
    * Repositories: Onde será implementado a interface do repositório, para os testes, conhecido com FakeRepository