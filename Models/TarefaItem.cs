using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Models
{
    public class TarefaItem
    {
        public int Id { get; set; }
        [Display(Name = "Tarefa Completa")]
        public bool EstaCompleta { get; set; }
        [Required(ErrorMessage = "O nome da tarefa é obrigatório")]
        [StringLength(200)]
        public string Nome { get; set; }
        [Display(Name = "Data de Conclusão")]
        public DateTimeOffset? DataConclusao { get; set; }
    }
}
