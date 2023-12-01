using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaAlterarSenha : Form
    {
        private Usuario usuario;

        public TelaAlterarSenha(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            txtSenha.UseSystemPasswordChar = true;
            txtConfirmacaoSenha.UseSystemPasswordChar = true;
        }

        private void btVoltarTelaPalavraChave_Click(object sender, EventArgs e)
        {
            TelaPalavraChave telaPalavraChave = new TelaPalavraChave();
            telaPalavraChave.Show();
            this.Close();
        }

        private void btConfirmarNovaSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txtSenha.Text;
            string confirmacaoSenha = txtConfirmacaoSenha.Text;

            if (string.IsNullOrWhiteSpace(novaSenha) || string.IsNullOrWhiteSpace(confirmacaoSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novaSenha != confirmacaoSenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Senha = novaSenha;

            MessageBox.Show("Senha alterada com sucesso!");

            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }

        private void btMostrarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void btMostrarConfirmacaoSenha_Click(object sender, EventArgs e)
        {
            txtConfirmacaoSenha.UseSystemPasswordChar = !txtConfirmacaoSenha.UseSystemPasswordChar;
        }
    }
}
