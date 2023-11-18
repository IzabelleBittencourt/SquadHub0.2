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

                posY += novoPictureBox.Height + 5;
            }
        }
    }
}
