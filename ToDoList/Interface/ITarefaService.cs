using ToDoList.Models;

namespace ToDoList.Interface
{
    public interface ITarefaService
    {
        void AdicionarTarefa(Tarefa tarefa);
        IEnumerable<Tarefa> ObterTarefas();
        Tarefa ObterTarefaPorId(int id);
        void AtualizarTarefa(Tarefa tarefa);
        void ExcluirTarefa(int id);
    }
}
