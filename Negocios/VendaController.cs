using GerenciadorDePecas.Dados;
using NHibernate;  
using System;

namespace GerenciadorDePecas.Negocios
{
    public class VendaController
    {
        public void CadastrarVenda(Venda venda)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())  
                {
                    try
                    {
                        session.Save(venda);
                        transaction.Commit();  
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();  // Rollback em caso de erro
                        throw new Exception("Erro ao salvar a venda.", ex);
                    }
                }
            }
        }
    }
}
