using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaPrincipal : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;
        private int publicacaoAtual;
        private Publicacao publicacaoExibida;

        public TelaPrincipal(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;

            if (ListaPublicacoes.Instance.Publicacoes.Count > 0)
            {
                publicacaoAtual = 0;
                publicacaoExibida = ListaPublicacoes.Instance.Publicacoes[publicacaoAtual];
                ExibirPublicacao(publicacaoAtual);
            }
        }

        private void ExibirPublicacao(int index)
        {
            if (index >= 0 && index < ListaPublicacoes.Instance.Publicacoes.Count)
            {
                publicacaoAtual = index;
                publicacaoExibida = ListaPublicacoes.Instance.Publicacoes[index];
                pictureBoxImagem.Image = publicacaoExibida.Imagem;
                labelLegenda.Text = publicacaoExibida.Legenda;

                pictureBoxImagem.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxFotoPerfilPublicacao.SizeMode = PictureBoxSizeMode.Zoom;

                if (publicacaoExibida.Autor != null)
                {
                    pictureBoxFotoPerfilPublicacao.Image = publicacaoExibida.Autor.FotoPerfil;
                    labelNicknamePublicacao.Text = " " + publicacaoExibida.Autor.Nickname;
                }

                if (publicacaoExibida != null)
                {
                    labelLike.Text = " " + publicacaoExibida.Likes.Count.ToString();
                    labelDislike.Text = " " + publicacaoExibida.Dislikes.Count.ToString();
                }

                AtualizarComentarios();
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes telaConfiguracoes = new TelaConfiguracoes(usuarioLogado, usuarioLogadoIndex);
            telaConfiguracoes.Show();
            this.Hide();
        }

        private void btTelaPessoasConectadas_Click(object sender, EventArgs e)
        {
            TelaPessoasConectadas telaPessoasConectadas = new TelaPessoasConectadas(usuarioLogado, usuarioLogadoIndex);
            telaPessoasConectadas.Show();
            this.Hide();
        }

        private void btTelaNovaPublicacao_Click(object sender, EventArgs e)
        {
            TelaNovaPublicacao telaNovaPublicacao = new TelaNovaPublicacao(usuarioLogado, usuarioLogadoIndex);
            telaNovaPublicacao.Show();
            this.Hide();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (usuarioLogadoIndex >= 0 && usuarioLogadoIndex < ListaUsuarios.Instance.Usuarios.Count)
            {
                Usuario usuario = ListaUsuarios.Instance.Usuarios[usuarioLogadoIndex];

                pictureBoxFotoPerfil.Image = usuario.FotoPerfil;
                labelNickname.Text = " " + usuario.Nickname;
                pictureBoxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (ListaPublicacoes.Instance.Publicacoes.Count > 0)
            {
                pictureBoxImagem.Visible = true;
                labelLegenda.Visible = true;

                pictureBoxFotoPerfilPublicacao.Visible = true;
                labelNicknamePublicacao.Visible = true;

                btLike.Visible = true;
                btDislike.Visible = true;

                labelLike.Visible = true;
                labelDislike.Visible = true;

                txtComentario.Visible = true;
                btEnviarComentario.Visible = true;
                labelComentario.Visible = true;
            }
            else
            {
                pictureBoxImagem.Visible = false;
                labelLegenda.Visible = false;

                pictureBoxFotoPerfilPublicacao.Visible = false;
                labelNicknamePublicacao.Visible = false;

                btLike.Visible = false;
                btDislike.Visible = false;

                labelLike.Visible = false;
                labelDislike.Visible = false;

                txtComentario.Visible = false;
                btEnviarComentario.Visible = false;
                labelComentario.Visible = false;
            }

            if (ListaPublicacoes.Instance.Publicacoes.Count > 1)
            {
                btProximaPublicacao.Visible = true;
                btPublicacaoAnterior.Visible = true;
            }
            else
            {
                btProximaPublicacao.Visible = false;
                btPublicacaoAnterior.Visible = false;
            }

            pictureBoxFotoPerfil.Click += PictureBoxPerfil_Click;
        }

        private void PictureBoxPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil(usuarioLogado, usuarioLogadoIndex);
            telaPerfil.Show();
            this.Hide();
        }

        private void btProximaPublicacao_Click(object sender, EventArgs e)
        {
            if (publicacaoAtual < ListaPublicacoes.Instance.Publicacoes.Count - 1)
            {
                publicacaoAtual++;
                ExibirPublicacao(publicacaoAtual);
            }
        }

        private void btPublicacaoAnterior_Click(object sender, EventArgs e)
        {
            if (publicacaoAtual > 0)
            {
                publicacaoAtual--;
                ExibirPublicacao(publicacaoAtual);
            }
        }

        private void btLike_Click(object sender, EventArgs e)
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

        private void btDislike_Click(object sender, EventArgs e)
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

        private void btEnviarComentario_Click(object sender, EventArgs e)
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

        private void btTelaNotificacoes_Click(object sender, EventArgs e)
        {
            TelaNotificacoes telaNotificacoes = new TelaNotificacoes(usuarioLogado, usuarioLogadoIndex);
            telaNotificacoes.Show();
            this.Hide();
        }

        private void btTelaAmigos_Click(object sender, EventArgs e)
        {
            TelaAmigos telaAmigos = new TelaAmigos(usuarioLogado, usuarioLogadoIndex);
            telaAmigos.Show();
            this.Hide();
        }
    }
}
