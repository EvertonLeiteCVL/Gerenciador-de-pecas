using FluentNHibernate.Mapping;
using GerenciadorDePecas.Negocios;

namespace GerenciadorDePecas.Dados
{
    public class PecaMap : ClassMap<Peça>
    {
        public PecaMap()
        {
            Table("Pecas");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable();
            Map(x => x.Fabricante).Not.Nullable();
            Map(x => x.PrecoCompra).Not.Nullable();
            Map(x => x.PrecoVenda).Not.Nullable();
            Map(x => x.Status).Not.Nullable();
        }
    }
}
