using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaChat : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;
        private Conversa conversa;

        public TelaChat(Usuario usuario, int usuarioIndex, Usuario amigo)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;

            conversa = ListaMensagens.Instance.ObterConversa(usuarioLogado, amigo);

            if (conversa == null)
            {
                conversa = new Conversa(amigo);
                ListaMensagens.Instance.Conversas[$"{usuarioLogado.Indice}-{amigo.Indice}"] = conversa;
            }
        }

        private void btVoltarTelaAmigos_Click(object sender, EventArgs e)
        {
            TelaAmigos telaAmigos = new TelaAmigos(usuarioLogado, usuarioLogadoIndex);
            telaAmigos.Show();
            this.Hide();
        }

        private void btEnviarMensagem_Click(object sender, EventArgs e)
        {
            string conteudo = txtNovaMensagem.Text;
            if (!string.IsNullOrWhiteSpace(conteudo))
            {
                Mensagem novaMensagem = new Mensagem
                {
                    Conteudo = conteudo,
                    Remetente = usuarioLogado
                };

                ListaMensagens.Instance.AdicionarMensagem(usuarioLogado, conversa.Amigo, novaMensagem);

                ExibirMensagens();

                txtNovaMensagem.Text = string.Empty;
            }
        }

        private void ExibirMensagens()
        {
            int posY = lblNicknameAmigo.Location.Y + lblNicknameAmigo.Height + 10;

            foreach (Mensagem mensagem in conversa.Mensagens)
            {
                PictureBox novoPictureBox = new PictureBox();
                novoPictureBox.Image = mensagem.Remetente.FotoPerfil;
                novoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                novoPictureBox.Size = new Size(30, 30);
                novoPictureBox.Location = new Point(pictureBoxFotoPerfilAmigo.Location.X, posY);

                this.Controls.Add(novoPictureBox);

                Label lblNickname = new Label();
                lblNickname.Text = mensagem.Remetente.Nickname;
                lblNickname.AutoSize = true;
                lblNickname.Location = new Point(novoPictureBox.Location.X + novoPictureBox.Width + 5, posY);

                this.Controls.Add(lblNickname);

                Label lblMensagem = new Label();
                lblMensagem.Text = $"{mensagem.Conteudo}";
                lblMensagem.AutoSize = true;
                lblMensagem.Location = new Point(lblNickname.Location.X + lblNickname.Width + 5, posY);

                this.Controls.Add(lblMensagem);

                posY += novoPictureBox.Height + 5;
            }
        }

        private void TelaChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            string chaveConversa = $"{usuarioLogado.Indice}-{conversa.Amigo.Indice}";
            ListaMensagens.Instance.Conversas[chaveConversa] = conversa;
        }

        private void TelaChat_Load(object sender, EventArgs e)
        {
            ExibirMensagens();
        }
    }
}
