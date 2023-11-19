using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaAmigos : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaAmigos(Usuario usuario, int usuarioIndex)
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

        private void TelaAmigos_Load(object sender, EventArgs e)
        {
            ExibirAmigos();
        }

        private void ExibirAmigos()
        {
            int posY = lblNicknameAmigos.Location.Y + lblNicknameAmigos.Height + 10;

            foreach (Amigo amigo in usuarioLogado.ListaAmigos)
            {
                Usuario amigoUsuario = amigo.UsuarioAmigo;

                PictureBox novoPictureBox = new PictureBox();
                novoPictureBox.Image = amigoUsuario.FotoPerfil;
                novoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                novoPictureBox.Size = new Size(50, 50);
                novoPictureBox.Location = new Point(pictureBoxFotoPerfilAmigos.Location.X, posY);

                this.Controls.Add(novoPictureBox);

                Label novoLabel = new Label();
                novoLabel.Text = amigoUsuario.Nickname;
                novoLabel.AutoSize = true;
                novoLabel.Location = new Point(novoPictureBox.Location.X + novoPictureBox.Width + 5, posY);

                this.Controls.Add(novoLabel);

                Button novoBotaoChat = new Button();
                novoBotaoChat.Text = "Abrir Chat";
                novoBotaoChat.Size = new Size(80, 30);
                novoBotaoChat.Location = new Point(novoLabel.Location.X + novoLabel.Width + 5, posY);
                novoBotaoChat.Tag = amigoUsuario;
                novoBotaoChat.Click += btAbrirChat_Click;

                this.Controls.Add(novoBotaoChat);

                posY += novoPictureBox.Height + 5;
            }
        }

        private void btAbrirChat_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                Usuario amigoUsuario = botao.Tag as Usuario;

                if (amigoUsuario != null)
                {
                    AbrirTelaChat(usuarioLogado, amigoUsuario);
                }
            }
        }

        private void AbrirTelaChat(Usuario usuarioLogado, Usuario amigo)
        {
            string chaveConversa = $"{usuarioLogado.Indice}-{amigo.Indice}";

            if (!ListaMensagens.Instance.Conversas.ContainsKey(chaveConversa))
            {
                ListaMensagens.Instance.Conversas[chaveConversa] = new Conversa(amigo);
            }

            TelaChat telaChat = new TelaChat(usuarioLogado, usuarioLogadoIndex, amigo);
            telaChat.FormClosed += (s, args) => ExibirAmigos();
            telaChat.Show();
            this.Hide();
        }
    }
}
