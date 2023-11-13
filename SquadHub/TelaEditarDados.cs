using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SquadHub
{
    public partial class TelaEditarDados : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaEditarDados(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;

            txtNome.Text = usuarioLogado.Nome;
            txtNickname.Text = usuarioLogado.Nickname;
            txtNickname.TextChanged += txtNickname_TextChanged;
            txtBio.Text = usuarioLogado.Biografia;
            pictureBoxFotoPerfil.Image = usuarioLogado.FotoPerfil;
            pictureBoxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btVoltarTelaPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil(usuarioLogado, usuarioLogadoIndex);
            telaPerfil.Show();
            this.Hide();
        }

        private void btAtualizarDados_Click(object sender, EventArgs e)
        {
            usuarioLogado.Nome = txtNome.Text;
            usuarioLogado.Nickname = txtNickname.Text;
            usuarioLogado.Biografia = txtBio.Text;

            if (pictureBoxFotoPerfil.Image != null)
            {
                usuarioLogado.FotoPerfil = pictureBoxFotoPerfil.Image;
            }

            if (ListaUsuarios.Instance.Usuarios.Any(u => u.Nickname == txtNickname.Text && u.Indice != usuarioLogadoIndex))
            {
                MessageBox.Show("Este nickname já está em uso. Por favor, escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListaUsuarios.Instance.Usuarios[usuarioLogadoIndex] = usuarioLogado;

            MessageBox.Show("Dados atualizados com sucesso!");

            TelaPerfil telaPerfil = new TelaPerfil(usuarioLogado, usuarioLogadoIndex);
            telaPerfil.Show();
            this.Hide();
        }

        private void btSelecionarFotoPerfil_Click(object sender, EventArgs e)
        {
            ConexaoImagens conexaoImagens = new ConexaoImagens();

            pictureBoxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;

            string caminhoImagem = conexaoImagens.SelecionarImagem();

            if (caminhoImagem != null)
            {
                pictureBoxFotoPerfil.Image = Image.FromFile(caminhoImagem);
            }
        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {
            txtNickname.Text = txtNickname.Text.Replace(" ", "_");

            if (!txtNickname.Text.StartsWith("@"))
            {
                txtNickname.Text = "@" + txtNickname.Text;
            }

            txtNickname.SelectionStart = txtNickname.Text.Length;
        }
    }
}
