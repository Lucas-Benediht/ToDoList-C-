using ToDoList.Data;
using ToDoList.Interface;
using ToDoList.Models;

public class TarefaService : ITarefaService
{
    private readonly TodoContext _context;

    public TarefaService(TodoContext context)
    {
        _context = context;
    }

    public void AdicionarTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();
    }

    public IEnumerable<Tarefa> ObterTarefas()
    {
        return _context.Tarefas.ToList();
    }

    public Tarefa ObterTarefaPorId(int id)
    {
        return _context.Tarefas.Find(id);
    }

    public void AtualizarTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Update(tarefa);
        _context.SaveChanges();
    }

    public void ExcluirTarefa(int id)
    {
        var tarefa = _context.Tarefas.Find(id);
        if (tarefa != null)
        {
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
        }
    }
}