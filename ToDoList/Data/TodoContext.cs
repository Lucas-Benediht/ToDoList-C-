using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class TodoContext: DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string caminhoBancoDeDados = @"C:\Users\Benee\Documents\Lucas Benediht\Challenges e Estudos\ToDoList\todo.db";

            optionsBuilder.UseSqlite($"Data Source={caminhoBancoDeDados}"); ;
        }
    }
}
