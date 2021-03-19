using System;

namespace ToDoList.Domain.Dtos
{
    public class TodoDTO
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Todo { get; set; }
        public bool Done { get; set; }
    }
}
