using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaCadastroComplementar : Form
    {
        private Usuario usuario;

        public TelaCadastroComplementar(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void LimparCampos()
        {
            txtNickname.Clear();
            boxFotoPerfil.Image = null;
            txtBiografia.Clear();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname.Text;
            string biografia = txtBiografia.Text;
            Image fotoPerfil = boxFotoPerfil.Image;

            if (string.IsNullOrWhiteSpace(nickname) || fotoPerfil == null)
            {
                MessageBox.Show("Por favor, escolha um nickname e uma foto de perfil!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Nickname = nickname;
            usuario.Biografia = biografia;
            usuario.FotoPerfil = fotoPerfil;

            ListaUsuarios.Instance.Usuarios[usuario.Indice] = usuario;

            MessageBox.Show("Cadastro complementar realizado com sucesso!");

            LimparCampos();

            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }

        private void btSelecionarImagemPerfil_Click(object sender, EventArgs e)
        {
            ConexaoImagens conexaoImagens = new ConexaoImagens();

            boxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;

            string caminhoImagem = conexaoImagens.SelecionarImagem();

            if (caminhoImagem != null)
            {
                boxFotoPerfil.Image = Image.FromFile(caminhoImagem);
            }
        }
    }
}
