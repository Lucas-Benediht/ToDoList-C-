using System;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Interface;
using ToDoList.Models;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddDbContext<ToDoList.Data.TodoContext>()
            .AddScoped<ITarefaService, TarefaService>()
            .BuildServiceProvider();

        using (var scope = serviceProvider.CreateScope())
        {
            var service = scope.ServiceProvider.GetRequiredService<ITarefaService>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Atualizar Tarefa");
                Console.WriteLine("4. Excluir Tarefa");
                Console.WriteLine("5. Sair");

                Console.Write("\nDigite sua opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa(service);
                        break;
                    case "2":
                        ListarTarefas(service);
                        break;
                    case "3":
                        AtualizarTarefa(service);
                        break;
                    case "4":
                        ExcluirTarefa(service);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void AdicionarTarefa(ITarefaService service)
    {
        Console.Clear();
        Console.Write("Digite a descrição da tarefa: ");
        string descricao = Console.ReadLine();

        var novaTarefa = new Tarefa { Descricao = descricao, Concluida = false };
        service.AdicionarTarefa(novaTarefa);

        Console.WriteLine("Tarefa adicionada com sucesso.");
    }

    static void ListarTarefas(ITarefaService service)
    {
        Console.Clear();
        Console.WriteLine("Lista de Tarefas:");
        var tarefas = service.ObterTarefas();
        foreach (var t in tarefas)
        {
            Console.WriteLine($"Tarefa: {t.Descricao} - Concluída: {t.Concluida} - Id {t.Id}");
        }
    }

    static void AtualizarTarefa(ITarefaService service)
    {
        Console.Clear();
        Console.Write("Digite o ID da tarefa a ser atualizada: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var tarefaParaAtualizar = service.ObterTarefaPorId(id);

            if (tarefaParaAtualizar == null)
            {
                Console.WriteLine("Tarefa não encontrada.");
                return;
            }
            tarefaParaAtualizar.Concluida = !tarefaParaAtualizar.Concluida;

            service.AtualizarTarefa(tarefaParaAtualizar);
            Console.WriteLine("\nStatus da tarefa atualizado com sucesso.");
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }

    }

    static void ExcluirTarefa(ITarefaService service)
    {
        Console.Clear();
        Console.Write("Digite o ID da tarefa a ser excluída: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            service.ExcluirTarefa(id);
            Console.WriteLine("Tarefa excluída com sucesso.");
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
            

    }
}
