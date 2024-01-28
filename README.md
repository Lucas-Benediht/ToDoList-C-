# ToDoList em C# 📓

Este é um aplicativo simples de lista de tarefas (ToDoList) implementado em C#.

## Funcionalidades

- Adicionar uma nova tarefa.
- Listar todas as tarefas.
- Atualizar o status de uma tarefa (concluída/não concluída).
- Excluir uma tarefa.

## Tecnologias Utilizadas

- Visual Studio
- SQLite

## Bibliotecas e Frameworks

- Entity Framework Core: Utilizado para acesso ao banco de dados.
- Dependency Injection: Utilizado para injeção de dependência.

## Estrutura do Projeto

- **Models**: Contém a definição da classe `Tarefa`.
- **Data**: Contém o contexto do banco de dados (`TodoContext`).
- **Interface**: Contém a interface `ITarefaService`.
- **TarefaService**: Implementa a interface `ITarefaService`.
- **Program.cs**: Contém a lógica principal do aplicativo.

## Pré-requisitos

Certifique-se de ter o SDK do .NET instalado em sua máquina.

## Como Executar

1. Clone este repositório em sua máquina local.
2. Abra o terminal e navegue até o diretório raiz do projeto.
3. Execute o comando `dotnet run` para iniciar o aplicativo.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests para melhorias.

## Autor

- Lucas Benediht Caldeira

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
