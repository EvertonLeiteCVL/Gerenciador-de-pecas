using System;
using System.Windows.Forms;
using GerenciadorDePecas.Apresentacao;

namespace GerenciadorDePecas.Apresentacao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }  

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastroPeça();
            formCadastro.Show();
        }

        // Método para o botão Consulta
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var formConsulta = new FormConsultaPeça();
            formConsulta.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            var formVenda = new FormVendaPecas();
            formVenda.Show();
        }
    }
}
