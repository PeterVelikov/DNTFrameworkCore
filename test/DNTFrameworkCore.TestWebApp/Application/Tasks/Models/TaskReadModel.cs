using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.TestWebApp.Domain.Tasks;

namespace DNTFrameworkCore.TestWebApp.Application.Tasks.Models
{
    public class TaskReadModel : Model
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public TaskState State { get; set; } = TaskState.Todo;
    }
}