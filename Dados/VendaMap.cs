using FluentNHibernate.Mapping;

namespace GerenciadorDePecas.Dados
{
    public class VendaMap : ClassMap<Venda>
    {
        public VendaMap()
        {
            Table("Vendas");
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.ValorVenda);
            Map(x => x.DataVenda);
            References(x => x.Peça).Column("IDPeça");
        }
    }
}
