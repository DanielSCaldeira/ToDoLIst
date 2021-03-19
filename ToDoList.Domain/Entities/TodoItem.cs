using ToDoList.Domain.Interfaces;

namespace ToDoList.Domain.Entities
{
    public class TodoItem : BaseDomain, IDone
    {
        public string Todo { get; set; }
        public bool Done { get; set; }
    }
}
