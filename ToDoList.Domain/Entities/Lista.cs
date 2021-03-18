using ToDoList.Domain.Interfaces;

namespace ToDoList.Domain.Entities
{
    public class Lista : BaseDomain, IAtivo
    {
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
