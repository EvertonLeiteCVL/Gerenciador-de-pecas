using GerenciadorDePecas.Negocios; 
using System;  
using System.Windows.Forms;  

namespace GerenciadorDePecas.Apresentacao
{
    public partial class FormCadastroPeça : Form
    {
        private TextBox txtNome;
        private TextBox txtFabricante;
        private TextBox txtPrecoCompra;
        private TextBox txtPrecoVenda;

        public FormCadastroPeça()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtFabricante.Text) ||
                    string.IsNullOrEmpty(txtPrecoCompra.Text) || string.IsNullOrEmpty(txtPrecoVenda.Text))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                    return;
                }

                var peca = new Peca
                {
                    Nome = txtNome.Text,
                    Fabricante = txtFabricante.Text,
                    PrecoCompra = decimal.Parse(txtPrecoCompra.Text),
                    PrecoVenda = decimal.Parse(txtPrecoVenda.Text),
                    Status = "ativo"
                };

                var controller = new PecaController();
                controller.CadastrarPeça(peca);

                MessageBox.Show("Peça cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
