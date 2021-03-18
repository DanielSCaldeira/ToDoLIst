using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Domain.Entities;

namespace ToDoList.Repository
{
    public class ListaMap : BaseDomainMap<Lista>
    {
        public ListaMap() : base("TB_LISTA"){}
        public override void Configure(EntityTypeBuilder<Lista> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Descricao).HasColumnName("DESCRICAO").HasMaxLength(250).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ATIVO").IsRequired();
        }
    }
}
