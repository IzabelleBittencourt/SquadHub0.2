using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaPerfil : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;
        private int publicacaoAtual;
        private Publicacao publicacaoExibida;

        public TelaPerfil(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            if (usuarioLogadoIndex >= 0 && usuarioLogadoIndex < ListaUsuarios.Instance.Usuarios.Count)
            {
                Usuario usuario = ListaUsuarios.Instance.Usuarios[usuarioLogadoIndex];

                lblNomePerfil.Text = " " + usuario.Nome;
                lblEmailPerfil.Text = " " + usuario.Email;
                lblNicknamePerfil.Text = " " + usuario.Nickname;
                lblBiografiaPerfil.Text = " " + usuario.Biografia;
                boxFotoPerfil.Image = usuario.FotoPerfil;
                boxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;

                LimparControles();

                foreach (Publicacao publicacao in usuario.Publicacoes)
                {
                    ExibirPublicacaoPerfil(publicacao);
                }
            }
        }

        private void ExibirPublicacaoPerfil(Publicacao publicacao)
        {
            publicacaoExibida = publicacao;

            pictureBoxImagem.Image = publicacao.Imagem;
            labelLegenda.Text = publicacao.Legenda;

            pictureBoxImagem.SizeMode = PictureBoxSizeMode.Zoom;

            labelLike.Text = " " + publicacao.Likes.Count.ToString();
            labelDislike.Text = " " + publicacao.Dislikes.Count.ToString();

            AtualizarComentariosPerfil(publicacao);

            btProximaPublicacao.Click -= (sender, e) => AvancarPublicacao();
            btProximaPublicacao.Click += (sender, e) => AvancarPublicacao();

            btPublicacaoAnterior.Click -= (sender, e) => RetrocederPublicacao();
            btPublicacaoAnterior.Click += (sender, e) => RetrocederPublicacao();

            btLike.Click -= (sender, e) => CurtirPublicacao();
            btLike.Click += (sender, e) => CurtirPublicacao();

            btDislike.Click -= (sender, e) => DescurtirPublicacao();
            btDislike.Click += (sender, e) => DescurtirPublicacao();

            btEnviarComentario.Click -= (sender, e) => EnviarComentario();
            btEnviarComentario.Click += (sender, e) => EnviarComentario();
        }

        private void AvancarPublicacao()
        {
            if (publicacaoAtual < usuarioLogado.Publicacoes.Count - 1)
            {
                publicacaoAtual++;
                ExibirPublicacaoPerfil(usuarioLogado.Publicacoes[publicacaoAtual]);
            }
        }

        private void RetrocederPublicacao()
        {
            if (publicacaoAtual > 0)
            {
                publicacaoAtual--;
                ExibirPublicacaoPerfil(usuarioLogado.Publicacoes[publicacaoAtual]);
            }
        }

        private void CurtirPublicacao()
        {
            if (publicacaoExibida != null)
            {
                if (!publicacaoExibida.Likes.Contains(usuarioLogado))
                {
                    publicacaoExibida.Likes.Add(usuarioLogado);

                    if (publicacaoExibida.Dislikes.Contains(usuarioLogado))
                    {
                        publicacaoExibida.Dislikes.Remove(usuarioLogado);
                    }

                    labelLike.Text = " " + publicacaoExibida.Likes.Count.ToString();
                    labelDislike.Text = " " + publicacaoExibida.Dislikes.Count.ToString();
                }
                else
                {
                    publicacaoExibida.Likes.Remove(usuarioLogado);
                    labelLike.Text = " " + publicacaoExibida.Likes.Count.ToString();
                }
            }
        }

        private void DescurtirPublicacao()
        {
            if (publicacaoExibida != null)
            {
                if (!publicacaoExibida.Dislikes.Contains(usuarioLogado))
                {
                    publicacaoExibida.Dislikes.Add(usuarioLogado);

                    if (publicacaoExibida.Likes.Contains(usuarioLogado))
                    {
                        publicacaoExibida.Likes.Remove(usuarioLogado);
                    }

                    labelDislike.Text = " " + publicacaoExibida.Dislikes.Count.ToString();
                    labelLike.Text = " " + publicacaoExibida.Likes.Count.ToString();
                }
                else
                {
                    publicacaoExibida.Dislikes.Remove(usuarioLogado);
                    labelDislike.Text = " " + publicacaoExibida.Dislikes.Count.ToString();
                }
            }
        }

        private void EnviarComentario()
        {
            string comentarioTexto = txtComentario.Text;

            if (!string.IsNullOrEmpty(comentarioTexto))
            {
                Comentario novoComentario = new Comentario
                {
                    Autor = usuarioLogado,
                    Texto = comentarioTexto
                };

                publicacaoExibida.Comentarios.Add(novoComentario);

                txtComentario.Clear();

                AtualizarComentarios();
            }
        }

        private void AtualizarComentarios()
        {
            if (publicacaoExibida != null)
            {
                labelComentario.Text = "";

                foreach (Comentario comentario in publicacaoExibida.Comentarios)
                {
                    labelComentario.Text += $"{comentario.Autor.Nickname}: {comentario.Texto}\n";
                }
            }
        }

        private void LimparControles()
        {
            pictureBoxImagem.Image = null;
            labelLegenda.Text = "";
            labelLike.Text = "";
            labelDislike.Text = "";
            labelComentario.Text = "";
        }

        private void AtualizarComentariosPerfil(Publicacao publicacao)
        {
            labelComentario.Text = "";

            foreach (Comentario comentario in publicacao.Comentarios)
            {
                labelComentario.Text += $"{comentario.Autor.Nickname}: {comentario.Texto}\n";
            }
        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }

        private void btTelaEditarDados_Click(object sender, EventArgs e)
        {
            TelaEditarDados telaEditarDados = new TelaEditarDados(usuarioLogado, usuarioLogadoIndex);
            telaEditarDados.Show();
            this.Hide();
        }
    }
}
