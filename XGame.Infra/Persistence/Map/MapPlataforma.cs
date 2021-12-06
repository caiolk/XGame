using System.Data.Entity.ModelConfiguration;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence.Map
{
    public class MaPlataforma : EntityTypeConfiguration<Plataforma>
    {
        public MaPlataforma()
        {
            ToTable("Plataforma");

            Property(p => p.Nome).HasMaxLength(50).IsRequired();
            
            

        }
    }
}