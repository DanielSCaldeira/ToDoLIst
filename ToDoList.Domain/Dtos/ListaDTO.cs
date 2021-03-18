using System;

namespace ToDoList.Domain.Dtos
{
    public class ListaDTO
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
