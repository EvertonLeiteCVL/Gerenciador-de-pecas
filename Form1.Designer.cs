using System;

namespace Gerenciador_de_pecas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(12, 38);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(200, 20);
            this.txtFabricante.TabIndex = 1;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(12, 64);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(200, 20);
            this.txtPrecoCompra.TabIndex = 2;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(12, 90);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(200, 20);
            this.txtPrecoVenda.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 116);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormCadastroPeça
            // 
            this.ClientSize = new System.Drawing.Size(224, 151);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtNome);
            this.Name = "FormCadastroPeça";
            this.Text = "Cadastro de Peça";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.TextBox txtNome;

        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

