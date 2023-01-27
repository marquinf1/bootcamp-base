using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Tarefas.Web.Models;

public class Tarefa
{
    public int Id { get; set; }

    [Required (ErrorMessage ="A descrição da tarefa deve ser preenchida")]
    [DisplayName("Título")]
    public string? Titulo { get; set; }

    [Required (ErrorMessage ="A descrição da tarefa deve ser preenchida")]
    [DisplayName("Descrição")]
    public string? Descricao { get; set; }

    [Required (ErrorMessage ="A descrição da tarefa deve ser preenchida")]
    [DisplayName("Concluída")]
    public bool Concluida { get; set; }
}