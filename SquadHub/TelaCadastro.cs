using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmacaoSenha.Clear();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confirmacaoSenha = txtConfirmacaoSenha.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmacaoSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataNascimento = dataNascimentoPicker.Value;
            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            if (idade <= 10)
            {
                MessageBox.Show("Você precisa ter mais de 10 anos para se cadastrar.");
                return;
            }

            if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Insira um email válido (deve conter '@' e '.com')", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senha != confirmacaoSenha)
            {
                MessageBox.Show("A senha e a confirmação de senha estão diferentes. Por favor, verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            novoUsuario.Indice = ListaUsuarios.Instance.Usuarios.Count;

            ListaUsuarios.Instance.Usuarios.Add(novoUsuario);

            MessageBox.Show("Cadastro realizado com sucesso!");

            LimparCampos();

            TelaCadastroComplementar telaCadastroComplementar = new TelaCadastroComplementar(novoUsuario);
            telaCadastroComplementar.Show();
            this.Hide();
        }

        private void btVoltarTelaLogin_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Close();
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
