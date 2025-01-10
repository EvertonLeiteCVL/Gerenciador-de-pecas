using GerenciadorDePecas.Dados;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDePecas.Negocios
{
    public class PecaController
    {
        // Método para consultar todas as peças
        public List<Peca> ConsultarPecas()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Peca>().ToList();
            }
        }

        // Método para cadastrar uma peça
        public void CadastrarPeça(Peca peca)
        {
            if (peca.PrecoVenda < peca.PrecoCompra)
            {
                throw new Exception("O preço de venda não pode ser menor que o preço de compra.");
            }

            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(peca);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao salvar a peça no banco de dados.", ex);
                    }
                }
            }
        }

        // Método para editar uma peça
        public void EditarPeca(Peca peca)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(peca);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao editar a peça no banco de dados.", ex);
                    }
                }
            }
        }

        // Método para excluir uma peça
        public void ExcluirPeça(int idPeça)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var peca = session.Get<Peca>(idPeça);
                        if (peca != null)
                        {
                            peca.Status = "excluída";
                            session.Update(peca);
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("Peça não encontrada.");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao excluir a peça.", ex);
                    }
                }
            }
        }

        // Método para buscar uma peça por nome
        public List<Peca> BuscarPecaPorNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Peca>()
                              .Where(p => p.Nome.Contains(nome))
                              .ToList();
            }
        }
    }
}
