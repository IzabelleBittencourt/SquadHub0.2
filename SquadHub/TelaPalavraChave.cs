using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaPalavraChave : Form
    {
        public TelaPalavraChave()
        {
            InitializeComponent();
        }

        private void btVoltarTelaLogin_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Close();
        }

        private void btTelaAlterarSenha_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string palavraChave = txtPalavraChave.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(palavraChave))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuarioEncontrado = ListaUsuarios.Instance.Usuarios.Find(busca => busca.Email == email && busca.PalavraChave == palavraChave);

            if (usuarioEncontrado != null)
            {
                TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha(usuarioEncontrado);
                telaAlterarSenha.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado. Verifique o email e a palavra-chave.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
