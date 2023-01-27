using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    public int Id { get; set; }

    [MinLength(5, ErrorMessage ="O título deve ter no mínimo 5 caracteres")]
    [Required (ErrorMessage ="Por favor informe o título da tarefa")]
    [DisplayName("Título")]
    public string? Titulo { get; set; }

    [Required (ErrorMessage ="Por favor informe a descrição da tarefa")]
    [DisplayName("Descrição")]
    public string? Descricao { get; set; }

    [Required (ErrorMessage ="Por favor informe o status de conclusão da tarefa")]
    [DisplayName("Concluída")]
    public bool Concluida { get; set; }
}