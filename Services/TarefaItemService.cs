using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Data;
using Tarefas.Models;

namespace Tarefas.Services
{
    public class TarefaItemService : ITarefaItemService
    {
        private readonly ApplicationDbContext _context;

        public TarefaItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TarefaItem>> GetItemAsync()
        {
            var model = _context.Tarefas
                        .Where(t => t.EstaCompleta == false)
                        .ToArray();

            return (model);
        }

        public async Task<bool> AdicionarItem(TarefaItem novoItem)
        {

            var tarefa = new TarefaItem
            {
                EstaCompleta = false,
                Nome = novoItem.Nome,
                DataConclusao = novoItem.DataConclusao
            };

            _context.Tarefas.Add(tarefa);
            var result =  await _context.SaveChangesAsync();

            return result == 1;
        }
    }
}
