using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaNovaPublicacao : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaNovaPublicacao(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }

        private void btSelecionarImagem_Click(object sender, EventArgs e)
        {
            ConexaoImagens conexaoImagens = new ConexaoImagens();

            boxImagem.SizeMode = PictureBoxSizeMode.Zoom;

            string caminhoImagem = conexaoImagens.SelecionarImagem();

            if(caminhoImagem != null)
            {
                boxImagem.Image = Image.FromFile(caminhoImagem);
            }
        }

        private void txtLegenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxImagem_Click(object sender, EventArgs e)
        {

        }

        private void btPublicar_Click(object sender, EventArgs e)
        {
            if (boxImagem.Image != null)
            {
                Image imagem = boxImagem.Image;
                string legenda = txtLegenda.Text;

                Publicacao novaPublicacao = new Publicacao
                {
                    Imagem = imagem,
                    Legenda = legenda,
                    Autor = usuarioLogado
                };

                ListaPublicacoes.Instance.Publicacoes.Add(novaPublicacao);

                boxImagem.Image = null;
                txtLegenda.Clear();

                TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma imagem antes de publicar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
