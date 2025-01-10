using GerenciadorDePecas.Negocios;
using System;
using System.Windows.Forms;

namespace GerenciadorDePecas.Apresentacao
{
    public partial class FormVendaPecas : Form
    {
        public FormVendaPecas()
        {
            InitializeComponent();
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            // Verificando se os campos de entrada contêm valores válidos
            if (int.TryParse(txtIDPeça.Text, out int idPeça) && decimal.TryParse(txtValorVenda.Text, out decimal valorVenda))
            {
                try
                {
                    //método para registrar a venda
                    var controller = new VendaController();
                    controller.RegistrarVenda(idPeça, valorVenda);
                    MessageBox.Show("Venda registrada com sucesso!");
                }
                catch (Exception ex)
                {
                    //mensagem de erro caso algo dê errado
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
            else
            {
                // mensagem caso algum valor seja inválido
                MessageBox.Show("Por favor, insira valores válidos para a ID da peça e o valor da venda.");
            }
        }
    }
}

