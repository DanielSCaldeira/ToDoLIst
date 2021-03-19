using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Domain.Entities;

namespace ToDoList.Repository
{
    public class ListaMap : BaseDomainMap<TodoItem>
    {
        public ListaMap() : base("TB_LISTA"){}
        public override void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Todo).HasColumnName("DESCRICAO").HasMaxLength(250).IsRequired();
            builder.Property(x => x.Done).HasColumnName("ATIVO").IsRequired();
        }
    }
}
