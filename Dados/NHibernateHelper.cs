using GerenciadorDePecas.Negocios;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;

namespace GerenciadorDePecas.Dados
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        static NHibernateHelper()
        {
            var config = new Configuration();

            // Configuração do Banco de Dados para SQL Server
            string connectionstr = "Data Source=Everton\\SQLEXPRESS;Initial Catalog=EstoqueVeiculos;Integrated Security=True;";
            config.DataBaseIntegration(x =>
            {
                x.ConnectionString = connectionstr;
                x.Dialect<NHibernate.Dialect.MsSql2012Dialect>(); 
                x.Driver<NHibernate.Driver.SqlClientDriver>(); 
            });

            // Adiciona os assemblies
            config.AddAssembly(Assembly.GetExecutingAssembly());
            config.AddAssembly(typeof(Peca).Assembly);  

            // Adiciona os arquivos 
            config.AddFile("C:\\Users\\everton\\Documentos\\GitHub\\GerenciadordePecas\\Mappings\\Peca.hbm.xml");

            _sessionFactory = config.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
