using System;
using System.Windows.Forms;

namespace Gerenciador_de_pecas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Lógica para o cadastro de peças
            string nome = txtNome.Text;
            string fabricante = txtFabricante.Text;

            // Exemplo simples de como usar os valores
            MessageBox.Show($"Cadastro de Peça: {nome}, Fabricante: {fabricante}");
        }
    }
}
