using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModels
{
    public class CreateTodoViewModels
    {
        [Required]
        public string Title { get; set; }
    }
}
