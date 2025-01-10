using GerenciadorDePecas.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GerenciadorDePecas.Apresentacao
{
    public partial class FormConsultaPeça : Form
    {
        private readonly PecaController _pecaController;  

        public FormConsultaPeça()
        {
            InitializeComponent(); 
            _pecaController = new PecaController();  
        }
        private void ListarPecas()
        {
            try
            {
               
                var pecas = _pecaController.ListarPecas();

             
                dgvPecas.DataSource = pecas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar as peças: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para buscar peça por nome
        private void BuscarPecaPorNome(string nome)
        {
            try
            {
                var pecas = _pecaController.BuscarPecaPorNome(nome);

                // Atribui o resultado da busca ao DataGridView
                dgvPecas.DataSource = pecas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar peça: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarPecas(); 
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nomePeca = txtNomePeca.Text;  // Pega o nome digitado no TextBox

            if (!string.IsNullOrEmpty(nomePeca))
            {
                BuscarPecaPorNome(nomePeca);  // Chama o método para buscar a peça pelo nome
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome da peça.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento de carregamento do formulário
        private void FormConsultaPeça_Load(object sender, EventArgs e)
        {
            ListarPecas();
        }
        private void ExcluirPeca(int idPeca)
        {
            try
            {
                // Chama o controller para excluir a peça
                _pecaController.ExcluirPeca(idPeca);
                MessageBox.Show("Peça excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a lista de peças
                ListarPecas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir peça: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPecas.SelectedRows.Count > 0)
            {
                int idPeca = Convert.ToInt32(dgvPecas.SelectedRows[0].Cells["Id"].Value);

                // Confirmação de exclusão
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir esta peça?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ExcluirPeca(idPeca);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma peça para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
